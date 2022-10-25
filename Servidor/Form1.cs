using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Servidor
{
    public partial class frmServidor : Form
    {
        public frmServidor()
        {
            InitializeComponent();
        }

        byte[] clientData = new byte[1024];
        Socket ServerSock;
        struct ClienteInfo
        {
            public Socket Sock;
            public string nome;
        }
        List<ClienteInfo> clientes = new List<ClienteInfo>();
        private void frmServidor_Load(object sender, EventArgs e)
        {
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Any, 5656); // Escolha o número da porta
            ServerSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp);
            ServerSock.Bind(ipEnd);
            ServerSock.Listen(100);
            //clientSock é o socket do cliente receber a mensagem
            ServerSock.BeginAccept(new AsyncCallback(OnAccept), null);
            this.Width = 852;
            ListaFicheiros();
        }

        private void OnAccept(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = ServerSock.EndAccept(ar);

                //Inicia para receber mais clientes
                ServerSock.BeginAccept(new AsyncCallback(OnAccept), null);

                //Assim que estabelece a ligação começa a receber dados
                clientSocket.BeginReceive(clientData, 0, clientData.Length, SocketFlags.None, new AsyncCallback(OnReceive), clientSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = (Socket)ar.AsyncState;
                clientSocket.EndReceive(ar);

                string utilizadores = "";
                string strRecebe = Encoding.UTF8.GetString(clientData).TrimEnd('\0');
                int comando = int.Parse(strRecebe.Substring(0, 2));
                switch (comando)
                {
                    case 1:                     // Login
                        ClienteInfo cliente = new ClienteInfo();
                        cliente.nome = strRecebe.Substring(2, strRecebe.Length - 2);
                        cliente.Sock = clientSocket;
                        clientes.Add(cliente);
                        txtLog.Text += ("Entrou: " + cliente.nome) + "\n";
                        lstUsers.Items.Clear();
                        foreach (ClienteInfo cli in clientes)
                        {
                            lstUsers.Items.Add(cli.nome);
                        }
                        break;
                    case 2:
                        string nome = "";
                        foreach (ClienteInfo name in clientes)
                        {
                            if (name.Sock == clientSocket)
                            {
                                nome = name.nome;
                                break;
                            }
                        }
                        foreach (ClienteInfo cli in clientes)
                        {
                            if (cli.Sock == clientSocket)
                            {
                                txtLog.Text += cli.nome + ": " + strRecebe.Substring(2, strRecebe.Length - 2) + "\n";
                            }
                            else
                            {
                                cli.Sock.Send(Encoding.UTF8.GetBytes("02" + nome + ": " + strRecebe.Substring(2, strRecebe.Length - 2)));
                            }
                        }
                        break;
                    case 3:
                        foreach (ClienteInfo cli in clientes)
                        {
                            utilizadores += string.Concat(cli.nome + "\n");
                        }
                        foreach (ClienteInfo cli in clientes)
                        {
                            cli.Sock.Send(Encoding.UTF8.GetBytes("03" + utilizadores));
                        }
                        break;
                    case 4:
                        string[] priv = strRecebe.Substring(2, strRecebe.Length - 2).Split('\n');
                        foreach (ClienteInfo cli in clientes)
                        {
                            if (cli.nome == priv[1])
                            {
                                cli.Sock.Send(System.Text.Encoding.UTF8.GetBytes("04" + "O " + priv[0] + " enviou-lhe uma mensagem privada: " + priv[2]));
                                txtLog.AppendText("Mensagem Privada de " + priv[0] + " para " + priv[1] + ": " + priv[2] + "\n");
                            }
                        }
                        break;
                    case 5:
                        /*
                         string nomeFich = strRecebe.Substring(2, strRecebe.Length - 2);
                         byte[] dadosFich =new byte[1024*1000000];
                         int receivebytes = clientSocket.Receive(dadosFich);
                         BinaryWriter bwrite = new BinaryWriter(File.Open(nomeFich, FileMode.Create));
                         bwrite.Write(dadosFich,0,receivebytes);
                         bwrite.Close();  Com Limite */
                        string[] fich = strRecebe.Substring(2, strRecebe.Length - 2).Split('\n');
                        txtLog.AppendText("A receber o ficheiro: " + fich[0] + " com " + fich[1] + " bytes.\n");

                        string caminho = Application.StartupPath + @"\Ficheiros Recebidos\";
                        FileStream stream = File.Create(caminho + fich[0]);
                        int bytesQueFaltamReceber = int.Parse(fich[1]);
                        byte[] fichBuffer = new byte[2048];
                        while (bytesQueFaltamReceber > 0)
                        {
                            int bytesRead = clientSocket.Receive(fichBuffer);
                            // Caso os bytes recebidos sejam menores que 2048
                            int bytesACopiar = Math.Min(bytesRead, bytesQueFaltamReceber);
                            stream.Write(fichBuffer, 0, bytesRead);
                            bytesQueFaltamReceber -= bytesRead;
                        }
                        stream.Close();
                        ListaFicheiros();
                        break;
                    case 6:
                        string lista = "";
                        foreach(ListViewItem ficheiro in lstFicheiros.Items)
                        {
                            lista+=ficheiro.Text + "\n";
                        }
                        clientSocket.Send(Encoding.UTF8.GetBytes("06"+lista));
                        break;
                    case 99:
                        int npos = 0;
                        string user = "";
                        foreach (ClienteInfo cli in clientes)
                        {
                            if (cli.Sock == clientSocket)
                            {
                                user = cli.nome;
                                clientes.RemoveAt(npos);
                                break;
                            }
                            ++npos;
                        }
                        clientSocket.Close();
                        clientSocket = null;
                        txtLog.AppendText(user + " saiu do chat..." + "\n");
                        lstUsers.Items.Clear();
                        utilizadores = "";
                        foreach (ClienteInfo cli in clientes)
                        {
                            lstUsers.Items.Add(cli.nome);
                            utilizadores += string.Concat(cli.nome + "\n");
                        }
                        foreach (ClienteInfo cli in clientes)
                        {
                            cli.Sock.Send(Encoding.UTF8.GetBytes("03" + utilizadores));
                        }
                        break;
                }
                Array.Clear(clientData, 0, clientData.Length);
                if (clientSocket != null)
                {
                    clientSocket.BeginReceive(clientData, 0, clientData.Length, SocketFlags.None, new AsyncCallback(OnReceive), clientSocket);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel estabelecer a ligação." + ex.Message);
            }
        }

        private void avisarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void banirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Deseja banir " + lstUsers.Text, "BANIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string msg = "98" + "FOSTE BANIDO!";
                    byte[] byData;
                    foreach (ClienteInfo cli in clientes)
                    {
                        if (cli.nome == lstUsers.Text)
                        {
                            byData = Encoding.UTF8.GetBytes(msg);
                            cli.Sock.Send(byData);
                        }
                    }
                }
            }
        }

        private void btnFicheiros_Click(object sender, EventArgs e)
        {
            if (btnFicheiros.Text == ">")
            {
                btnFicheiros.Text = "<";
                this.Width = 1220;
            }
            else
            {
                btnFicheiros.Text = ">";
                this.Width = 838;
            }
        }

        void ListaFicheiros()
        {
            string caminho = Application.StartupPath + @"\Ficheiros Recebidos\";

            string[] ficheiros = Directory.GetFiles(caminho);
            lstFicheiros.Clear();
            foreach (string ficheiro in ficheiros)
            {
                ListViewItem item = new ListViewItem(Path.GetFileName(ficheiro));
                switch (Path.GetExtension(ficheiro))
                {
                    case ".txt":
                        item.ImageIndex = 0;
                        break;
                    case ".pdf":
                        item.ImageIndex = 1;
                        break;
                    case ".exe":
                        item.ImageIndex = 2;
                        break;
                    default:
                        break;
                }
                lstFicheiros.Items.Add(item);
            }
        }

        private void iconesGrandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstFicheiros.View = View.LargeIcon;
        }

        private void iconesPequenosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstFicheiros.View = View.SmallIcon;
        }

        private void detalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstFicheiros.View = View.Details;
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstFicheiros.View = View.List;
        }

        private void telhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstFicheiros.View = View.Tile;
        }
    }
}
