namespace Cliente
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnEnvia = new System.Windows.Forms.Button();
            this.btnLiga = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCima = new System.Windows.Forms.Label();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.mnuCliente = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mensagemPrivadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.lstFicheiros = new System.Windows.Forms.ListView();
            this.btnFicheiros = new System.Windows.Forms.Button();
            this.mnuFicheiro = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iconesGrandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconesPequenosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalhesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.enviarParaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgFicheiros = new System.Windows.Forms.ImageList(this.components);
            this.mnuCliente.SuspendLayout();
            this.mnuFicheiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(12, 50);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(592, 364);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(13, 430);
            this.txtMsg.MaxLength = 1000;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(592, 29);
            this.txtMsg.TabIndex = 1;
            // 
            // btnEnvia
            // 
            this.btnEnvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvia.Location = new System.Drawing.Point(611, 429);
            this.btnEnvia.Name = "btnEnvia";
            this.btnEnvia.Size = new System.Drawing.Size(139, 30);
            this.btnEnvia.TabIndex = 2;
            this.btnEnvia.Text = "&Envia";
            this.btnEnvia.UseVisualStyleBackColor = true;
            this.btnEnvia.Click += new System.EventHandler(this.btnEnvia_Click);
            // 
            // btnLiga
            // 
            this.btnLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiga.Location = new System.Drawing.Point(611, 9);
            this.btnLiga.Name = "btnLiga";
            this.btnLiga.Size = new System.Drawing.Size(177, 30);
            this.btnLiga.TabIndex = 4;
            this.btnLiga.Text = "&Liga";
            this.btnLiga.UseVisualStyleBackColor = true;
            this.btnLiga.Click += new System.EventHandler(this.btnLiga_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(13, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(592, 29);
            this.txtNome.TabIndex = 0;
            // 
            // lblCima
            // 
            this.lblCima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCima.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCima.ForeColor = System.Drawing.Color.Blue;
            this.lblCima.Location = new System.Drawing.Point(13, 9);
            this.lblCima.Name = "lblCima";
            this.lblCima.Size = new System.Drawing.Size(1172, 35);
            this.lblCima.TabIndex = 5;
            this.lblCima.Text = "Benvindo ao WinChat";
            this.lblCima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCima.Visible = false;
            // 
            // lstUsers
            // 
            this.lstUsers.ContextMenuStrip = this.mnuCliente;
            this.lstUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 24;
            this.lstUsers.Location = new System.Drawing.Point(611, 50);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(177, 364);
            this.lstUsers.TabIndex = 7;
            // 
            // mnuCliente
            // 
            this.mnuCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mensagemPrivadaToolStripMenuItem});
            this.mnuCliente.Name = "mnuCliente";
            this.mnuCliente.Size = new System.Drawing.Size(176, 26);
            // 
            // mensagemPrivadaToolStripMenuItem
            // 
            this.mensagemPrivadaToolStripMenuItem.Name = "mensagemPrivadaToolStripMenuItem";
            this.mensagemPrivadaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.mensagemPrivadaToolStripMenuItem.Text = "Mensagem &Privada";
            this.mensagemPrivadaToolStripMenuItem.Click += new System.EventHandler(this.mensagemPrivadaToolStripMenuItem_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFile.Location = new System.Drawing.Point(756, 431);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(31, 30);
            this.btnSendFile.TabIndex = 9;
            this.btnSendFile.Text = "+";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // lstFicheiros
            // 
            this.lstFicheiros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstFicheiros.ContextMenuStrip = this.mnuFicheiro;
            this.lstFicheiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFicheiros.HideSelection = false;
            this.lstFicheiros.LargeImageList = this.imgFicheiros;
            this.lstFicheiros.Location = new System.Drawing.Point(824, 10);
            this.lstFicheiros.Name = "lstFicheiros";
            this.lstFicheiros.Size = new System.Drawing.Size(368, 449);
            this.lstFicheiros.SmallImageList = this.imgFicheiros;
            this.lstFicheiros.TabIndex = 11;
            this.lstFicheiros.UseCompatibleStateImageBehavior = false;
            // 
            // btnFicheiros
            // 
            this.btnFicheiros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFicheiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFicheiros.Location = new System.Drawing.Point(794, 9);
            this.btnFicheiros.Name = "btnFicheiros";
            this.btnFicheiros.Size = new System.Drawing.Size(23, 450);
            this.btnFicheiros.TabIndex = 10;
            this.btnFicheiros.Text = ">";
            this.btnFicheiros.UseVisualStyleBackColor = true;
            this.btnFicheiros.Click += new System.EventHandler(this.btnFicheiros_Click);
            // 
            // mnuFicheiro
            // 
            this.mnuFicheiro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconesGrandesToolStripMenuItem,
            this.iconesPequenosToolStripMenuItem,
            this.detalhesToolStripMenuItem,
            this.listaToolStripMenuItem,
            this.telhaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.enviarParaClienteToolStripMenuItem});
            this.mnuFicheiro.Name = "mnuFicheiro";
            this.mnuFicheiro.Size = new System.Drawing.Size(191, 142);
            // 
            // iconesGrandesToolStripMenuItem
            // 
            this.iconesGrandesToolStripMenuItem.Name = "iconesGrandesToolStripMenuItem";
            this.iconesGrandesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.iconesGrandesToolStripMenuItem.Text = "Icones Grandes";
            // 
            // iconesPequenosToolStripMenuItem
            // 
            this.iconesPequenosToolStripMenuItem.Name = "iconesPequenosToolStripMenuItem";
            this.iconesPequenosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.iconesPequenosToolStripMenuItem.Text = "Icones Pequenos";
            // 
            // detalhesToolStripMenuItem
            // 
            this.detalhesToolStripMenuItem.Name = "detalhesToolStripMenuItem";
            this.detalhesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.detalhesToolStripMenuItem.Text = "Detalhes";
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listaToolStripMenuItem.Text = "Lista";
            // 
            // telhaToolStripMenuItem
            // 
            this.telhaToolStripMenuItem.Name = "telhaToolStripMenuItem";
            this.telhaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.telhaToolStripMenuItem.Text = "Tile";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 6);
            // 
            // enviarParaClienteToolStripMenuItem
            // 
            this.enviarParaClienteToolStripMenuItem.Name = "enviarParaClienteToolStripMenuItem";
            this.enviarParaClienteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.enviarParaClienteToolStripMenuItem.Text = "Download do Ficheiro";
            // 
            // imgFicheiros
            // 
            this.imgFicheiros.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFicheiros.ImageStream")));
            this.imgFicheiros.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFicheiros.Images.SetKeyName(0, "txt.png");
            this.imgFicheiros.Images.SetKeyName(1, "pdf.png");
            this.imgFicheiros.Images.SetKeyName(2, "exe.png");
            // 
            // frmCliente
            // 
            this.AcceptButton = this.btnLiga;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 466);
            this.Controls.Add(this.lstFicheiros);
            this.Controls.Add(this.btnFicheiros);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnEnvia);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnLiga);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCima);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCliente_FormClosing);
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.mnuCliente.ResumeLayout(false);
            this.mnuFicheiro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnEnvia;
        private System.Windows.Forms.Button btnLiga;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCima;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.ContextMenuStrip mnuCliente;
        private System.Windows.Forms.ToolStripMenuItem mensagemPrivadaToolStripMenuItem;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.ListView lstFicheiros;
        private System.Windows.Forms.Button btnFicheiros;
        private System.Windows.Forms.ImageList imgFicheiros;
        private System.Windows.Forms.ContextMenuStrip mnuFicheiro;
        private System.Windows.Forms.ToolStripMenuItem iconesGrandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iconesPequenosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalhesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem enviarParaClienteToolStripMenuItem;
    }
}

