namespace Servidor
{
    partial class frmServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServidor));
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.mnuAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.avisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.banirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFicheiros = new System.Windows.Forms.Button();
            this.lstFicheiros = new System.Windows.Forms.ListView();
            this.imgFicheiros = new System.Windows.Forms.ImageList(this.components);
            this.mnuFicheiro = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iconesGrandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalhesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconesPequenosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.enviarParaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin.SuspendLayout();
            this.mnuFicheiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(12, 12);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(628, 436);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "";
            // 
            // lstUsers
            // 
            this.lstUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstUsers.ContextMenuStrip = this.mnuAdmin;
            this.lstUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 24;
            this.lstUsers.Location = new System.Drawing.Point(651, 12);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(150, 436);
            this.lstUsers.Sorted = true;
            this.lstUsers.TabIndex = 2;
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avisarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.banirToolStripMenuItem});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(107, 54);
            // 
            // avisarToolStripMenuItem
            // 
            this.avisarToolStripMenuItem.Name = "avisarToolStripMenuItem";
            this.avisarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.avisarToolStripMenuItem.Text = "&Avisar";
            this.avisarToolStripMenuItem.Click += new System.EventHandler(this.avisarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 6);
            // 
            // banirToolStripMenuItem
            // 
            this.banirToolStripMenuItem.Name = "banirToolStripMenuItem";
            this.banirToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.banirToolStripMenuItem.Text = "&Banir";
            this.banirToolStripMenuItem.Click += new System.EventHandler(this.banirToolStripMenuItem_Click);
            // 
            // btnFicheiros
            // 
            this.btnFicheiros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFicheiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFicheiros.Location = new System.Drawing.Point(807, 12);
            this.btnFicheiros.Name = "btnFicheiros";
            this.btnFicheiros.Size = new System.Drawing.Size(23, 436);
            this.btnFicheiros.TabIndex = 3;
            this.btnFicheiros.Text = ">";
            this.btnFicheiros.UseVisualStyleBackColor = true;
            this.btnFicheiros.Click += new System.EventHandler(this.btnFicheiros_Click);
            // 
            // lstFicheiros
            // 
            this.lstFicheiros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstFicheiros.ContextMenuStrip = this.mnuFicheiro;
            this.lstFicheiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFicheiros.HideSelection = false;
            this.lstFicheiros.LargeImageList = this.imgFicheiros;
            this.lstFicheiros.Location = new System.Drawing.Point(837, 13);
            this.lstFicheiros.Name = "lstFicheiros";
            this.lstFicheiros.Size = new System.Drawing.Size(355, 435);
            this.lstFicheiros.SmallImageList = this.imgFicheiros;
            this.lstFicheiros.TabIndex = 4;
            this.lstFicheiros.UseCompatibleStateImageBehavior = false;
            // 
            // imgFicheiros
            // 
            this.imgFicheiros.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFicheiros.ImageStream")));
            this.imgFicheiros.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFicheiros.Images.SetKeyName(0, "txt.png");
            this.imgFicheiros.Images.SetKeyName(1, "pdf.png");
            this.imgFicheiros.Images.SetKeyName(2, "exe.png");
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
            this.mnuFicheiro.Size = new System.Drawing.Size(171, 142);
            // 
            // iconesGrandesToolStripMenuItem
            // 
            this.iconesGrandesToolStripMenuItem.Name = "iconesGrandesToolStripMenuItem";
            this.iconesGrandesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.iconesGrandesToolStripMenuItem.Text = "Icones Grandes";
            this.iconesGrandesToolStripMenuItem.Click += new System.EventHandler(this.iconesGrandesToolStripMenuItem_Click);
            // 
            // detalhesToolStripMenuItem
            // 
            this.detalhesToolStripMenuItem.Name = "detalhesToolStripMenuItem";
            this.detalhesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.detalhesToolStripMenuItem.Text = "Detalhes";
            this.detalhesToolStripMenuItem.Click += new System.EventHandler(this.detalhesToolStripMenuItem_Click);
            // 
            // iconesPequenosToolStripMenuItem
            // 
            this.iconesPequenosToolStripMenuItem.Name = "iconesPequenosToolStripMenuItem";
            this.iconesPequenosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.iconesPequenosToolStripMenuItem.Text = "Icones Pequenos";
            this.iconesPequenosToolStripMenuItem.Click += new System.EventHandler(this.iconesPequenosToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listaToolStripMenuItem.Text = "Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // telhaToolStripMenuItem
            // 
            this.telhaToolStripMenuItem.Name = "telhaToolStripMenuItem";
            this.telhaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.telhaToolStripMenuItem.Text = "Tile";
            this.telhaToolStripMenuItem.Click += new System.EventHandler(this.telhaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 6);
            // 
            // enviarParaClienteToolStripMenuItem
            // 
            this.enviarParaClienteToolStripMenuItem.Name = "enviarParaClienteToolStripMenuItem";
            this.enviarParaClienteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.enviarParaClienteToolStripMenuItem.Text = "Enviar para cliente";
            // 
            // frmServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 456);
            this.Controls.Add(this.lstFicheiros);
            this.Controls.Add(this.btnFicheiros);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.txtLog);
            this.Name = "frmServidor";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.frmServidor_Load);
            this.mnuAdmin.ResumeLayout(false);
            this.mnuFicheiro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.ContextMenuStrip mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem avisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem banirToolStripMenuItem;
        private System.Windows.Forms.Button btnFicheiros;
        private System.Windows.Forms.ListView lstFicheiros;
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

