namespace ControlX
{
    partial class formMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.btVender = new System.Windows.Forms.Button();
            this.btFornecedor = new System.Windows.Forms.Button();
            this.btEstoque = new System.Windows.Forms.Button();
            this.btDesconectar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btUsuario = new System.Windows.Forms.Button();
            this.btComprar = new System.Windows.Forms.Button();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.pnConectado = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.HistoricoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnConectado.SuspendLayout();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btVender
            // 
            this.btVender.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVender.Location = new System.Drawing.Point(3, 34);
            this.btVender.Name = "btVender";
            this.btVender.Size = new System.Drawing.Size(120, 25);
            this.btVender.TabIndex = 0;
            this.btVender.Text = "Vender";
            this.btVender.UseVisualStyleBackColor = true;
            this.btVender.Click += new System.EventHandler(this.btVender_Click);
            // 
            // btFornecedor
            // 
            this.btFornecedor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFornecedor.Location = new System.Drawing.Point(134, 34);
            this.btFornecedor.Name = "btFornecedor";
            this.btFornecedor.Size = new System.Drawing.Size(120, 25);
            this.btFornecedor.TabIndex = 2;
            this.btFornecedor.Text = "Fornecedores";
            this.btFornecedor.UseVisualStyleBackColor = true;
            this.btFornecedor.Click += new System.EventHandler(this.btCadastroFunc_Click);
            // 
            // btEstoque
            // 
            this.btEstoque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEstoque.Location = new System.Drawing.Point(134, 3);
            this.btEstoque.Name = "btEstoque";
            this.btEstoque.Size = new System.Drawing.Size(120, 25);
            this.btEstoque.TabIndex = 1;
            this.btEstoque.Text = "Estoque";
            this.btEstoque.UseVisualStyleBackColor = true;
            this.btEstoque.Click += new System.EventHandler(this.btControleEstoq_Click);
            // 
            // btDesconectar
            // 
            this.btDesconectar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesconectar.Location = new System.Drawing.Point(388, 3);
            this.btDesconectar.Name = "btDesconectar";
            this.btDesconectar.Size = new System.Drawing.Size(120, 25);
            this.btDesconectar.TabIndex = 0;
            this.btDesconectar.Text = "Desconectar";
            this.btDesconectar.UseVisualStyleBackColor = true;
            this.btDesconectar.Click += new System.EventHandler(this.btSair_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btUsuario);
            this.panel1.Controls.Add(this.btComprar);
            this.panel1.Controls.Add(this.btVender);
            this.panel1.Controls.Add(this.btEstoque);
            this.panel1.Controls.Add(this.btFornecedor);
            this.panel1.Location = new System.Drawing.Point(266, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 92);
            this.panel1.TabIndex = 4;
            // 
            // btUsuario
            // 
            this.btUsuario.Location = new System.Drawing.Point(72, 64);
            this.btUsuario.Name = "btUsuario";
            this.btUsuario.Size = new System.Drawing.Size(120, 25);
            this.btUsuario.TabIndex = 4;
            this.btUsuario.Text = "Usuários";
            this.btUsuario.UseVisualStyleBackColor = true;
            this.btUsuario.Click += new System.EventHandler(this.btUsuario_Click);
            // 
            // btComprar
            // 
            this.btComprar.Location = new System.Drawing.Point(3, 3);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(120, 25);
            this.btComprar.TabIndex = 3;
            this.btComprar.Text = "Comprar";
            this.btComprar.UseVisualStyleBackColor = true;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.Location = new System.Drawing.Point(3, 9);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(232, 14);
            this.lbMensagem.TabIndex = 5;
            this.lbMensagem.Text = "Você está conectado como \'Admin\' !";
            // 
            // pnConectado
            // 
            this.pnConectado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnConectado.Controls.Add(this.lbMensagem);
            this.pnConectado.Controls.Add(this.btDesconectar);
            this.pnConectado.Location = new System.Drawing.Point(10, 37);
            this.pnConectado.Name = "pnConectado";
            this.pnConectado.Size = new System.Drawing.Size(513, 35);
            this.pnConectado.TabIndex = 6;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(373, 75);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(129, 13);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "00/00/0000 00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistoricoTSMI,
            this.helpToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.msMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(535, 24);
            this.msMenu.TabIndex = 8;
            this.msMenu.Text = "menuStrip1";
            // 
            // HistoricoTSMI
            // 
            this.HistoricoTSMI.BackColor = System.Drawing.SystemColors.Control;
            this.HistoricoTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem,
            this.vendaToolStripMenuItem});
            this.HistoricoTSMI.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HistoricoTSMI.Name = "HistoricoTSMI";
            this.HistoricoTSMI.Size = new System.Drawing.Size(67, 20);
            this.HistoricoTSMI.Text = "Histórico";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.compraToolStripMenuItem.Text = "Compra";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.helpToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(10, 78);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(167, 122);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // formMenu
            // 
            this.AcceptButton = this.btVender;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 204);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pnConectado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlX - Menu";
            this.panel1.ResumeLayout(false);
            this.pnConectado.ResumeLayout(false);
            this.pnConectado.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVender;
        private System.Windows.Forms.Button btFornecedor;
        private System.Windows.Forms.Button btEstoque;
        private System.Windows.Forms.Button btDesconectar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnConectado;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btComprar;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem HistoricoTSMI;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Button btUsuario;
        public System.Windows.Forms.Label lbMensagem;
    }
}