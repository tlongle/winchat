using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Cliente
{
    public partial class frmCliente : Form
    {
        Socket clientSock;
        byte[] serverData = new byte[1024];
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.Height = 87;
            this.Width = 838;
            txtNome.Focus();
        }
        private void btnEnvia_Click(object sender, EventArgs e)
        {
            byte[] byData;
            string strEnvia = "02" + txtMsg.Text;
            byData = System.Text.Encoding.UTF8.GetBytes(strEnvia);
            clientSock.Send(byData);
            // txtLog.AppendText("Eu: " + txtMsg.Text + "\n");
            AdicionaTexto(txtLog, txtMsg.Text + "\n", Color.Green, HorizontalAlignment.Right);
            txtMsg.Text = null;
            txtMsg.Focus();
        }

        private void btnLiga_Click(object sender, EventArgs e)
        {
            if (txtNome.Text !="")
            {
                IPAddress[] ipAddress = Dns.GetHostAddresses("127.0.0.1");
                IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], 5656);
                clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                ProtocolType.Tcp);
                clientSock.BeginConnect(ipEnd, null, null);
                this.Height = 507;
                byte[] byData;
                string strEnvia = "01" + txtNome.Text;
                byData = System.Text.Encoding.UTF8.GetBytes(strEnvia);
                clientSock.Send(byData);
                clientSock.Send(Encoding.UTF8.GetBytes("03"));
                clientSock.BeginReceive(serverData, 0, serverData.Length, SocketFlags.None, new AsyncCallback(OnReceive), clientSock);
                txtNome.Visible = false;
                btnLiga.Visible = false;
                lblCima.Visible = true;
                lblCima.Text += " " + txtNome.Text;
                this.AcceptButton = btnEnvia;
            }
        }
        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = (Socket)ar.AsyncState;
                clientSocket.EndReceive(ar);

                string strRecebe = Encoding.UTF8.GetString(serverData).TrimEnd('\0');
                int comando = int.Parse(strRecebe.Substring(0, 2));
                switch (comando)
                {
                    case 1:
                        break;
                    case 2:
                        AdicionaTexto(txtLog, strRecebe.Substring(2, strRecebe.Length - 2) + "\n", Color.Blue, HorizontalAlignment.Left);
                        break;
                    case 3:
                        string[] users = strRecebe.Substring(2, strRecebe.Length - 2).Split('\n');
                        lstUsers.Items.Clear();
                        foreach (string user in users)
                        {
                            lstUsers.Items.Add(user);
                        }
                        break;
                    case 4:
                        AdicionaTexto(txtLog, strRecebe.Substring(2, strRecebe.Length - 2) + "\n", Color.DarkRed, HorizontalAlignment.Left);
                        break;
                    case 6:
                        ListaFicheiros(strRecebe.Substring(2, strRecebe.Length - 2));
                        break;
                    case 98:
                        MessageBox.Show(strRecebe.Substring(2, strRecebe.Length - 2));
                        this.Close();
                        break;
                }
                Array.Clear(serverData, 0, serverData.Length);
                if (clientSocket != null)
                {
                    clientSock.BeginReceive(serverData, 0, serverData.Length, SocketFlags.None, new AsyncCallback(OnReceive), clientSock);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel estabelecer a ligação." + ex.Message);
            }
        }

        private void frmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clientSock != null)
            {
                clientSock.Send(System.Text.Encoding.UTF8.GetBytes("99"));
                clientSock.Close();
                clientSock = null;
            }
        }

        void AdicionaTexto(RichTextBox box, string texto, Color cor, HorizontalAlignment alinha)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = cor;
            box.SelectionAlignment = alinha;
            box.AppendText(texto);
            box.SelectionColor = box.ForeColor;
        }

        private void mensagemPrivadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstUsers.Text != txtNome.Text && txtMsg.Text != "")
            {
                clientSock.Send(Encoding.UTF8.GetBytes("04" + txtNome.Text + "\n" + lstUsers.Text + "\n" + txtMsg.Text));
                AdicionaTexto(txtLog, "Enviou uma mensagem privada para " + lstUsers.Text + " :" + txtMsg.Text + "\n", Color.DarkRed, HorizontalAlignment.Right);
                txtMsg.Text = null;
                txtMsg.Focus();
            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecione o Ficheiro a enviar para o Servidor.";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo lenFich = new FileInfo(ofd.FileName);
                if (lenFich.Length > 2000000000)
                {
                    MessageBox.Show("Não pode enviar ficheiros maiores que 2G.");
                }
                else
                {
                    clientSock.Send(Encoding.UTF8.GetBytes("05" + ofd.SafeFileName + "\n" + lenFich.Length.ToString()));
                    clientSock.SendFile(ofd.FileName);
                }
            }
        }

        private void btnFicheiros_Click(object sender, EventArgs e)
        {
            if (btnFicheiros.Text == ">")
            {
                clientSock.Send(Encoding.UTF8.GetBytes("06"));
                btnFicheiros.Text = "<";
                this.Width = 1220;
            }
            else
            {
                btnFicheiros.Text = ">";
                this.Width = 838;
            }
        }

        void ListaFicheiros(string listaServer)
        {
            string[] lista = listaServer.Split('\n');
            lstFicheiros.Clear();
            foreach (string ficheiro in lista)
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
    }
}