﻿namespace ControlX
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btUsuario = new System.Windows.Forms.Button();
            this.btComprar = new System.Windows.Forms.Button();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.pnConectado = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.btVenderCaixa = new System.Windows.Forms.Button();
            this.pnCaixa = new System.Windows.Forms.Panel();
            this.pnAlmoxarife = new System.Windows.Forms.Panel();
            this.btComprarAlmox = new System.Windows.Forms.Button();
            this.btEstoqueAlmox = new System.Windows.Forms.Button();
            this.btFornecedorAlmox = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.menuHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.porFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPeriodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueMinimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMenu.SuspendLayout();
            this.pnConectado.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.pnCaixa.SuspendLayout();
            this.pnAlmoxarife.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btVender
            // 
            this.btVender.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVender.Location = new System.Drawing.Point(7, 34);
            this.btVender.Name = "btVender";
            this.btVender.Size = new System.Drawing.Size(126, 25);
            this.btVender.TabIndex = 0;
            this.btVender.Text = "Venda";
            this.btVender.UseVisualStyleBackColor = true;
            this.btVender.Click += new System.EventHandler(this.btVender_Click);
            // 
            // btFornecedor
            // 
            this.btFornecedor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFornecedor.Location = new System.Drawing.Point(138, 34);
            this.btFornecedor.Name = "btFornecedor";
            this.btFornecedor.Size = new System.Drawing.Size(126, 25);
            this.btFornecedor.TabIndex = 2;
            this.btFornecedor.Text = "Fornecedores";
            this.btFornecedor.UseVisualStyleBackColor = true;
            this.btFornecedor.Click += new System.EventHandler(this.btCadastroFunc_Click);
            // 
            // btEstoque
            // 
            this.btEstoque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEstoque.Location = new System.Drawing.Point(138, 3);
            this.btEstoque.Name = "btEstoque";
            this.btEstoque.Size = new System.Drawing.Size(126, 25);
            this.btEstoque.TabIndex = 1;
            this.btEstoque.Text = "Estoque";
            this.btEstoque.UseVisualStyleBackColor = true;
            this.btEstoque.Click += new System.EventHandler(this.btControleEstoq_Click);
            // 
            // btDesconectar
            // 
            this.btDesconectar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesconectar.Location = new System.Drawing.Point(407, 3);
            this.btDesconectar.Name = "btDesconectar";
            this.btDesconectar.Size = new System.Drawing.Size(101, 25);
            this.btDesconectar.TabIndex = 0;
            this.btDesconectar.Text = "Desconectar";
            this.btDesconectar.UseVisualStyleBackColor = true;
            this.btDesconectar.Click += new System.EventHandler(this.btSair_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.btUsuario);
            this.pnMenu.Controls.Add(this.btComprar);
            this.pnMenu.Controls.Add(this.btVender);
            this.pnMenu.Controls.Add(this.btEstoque);
            this.pnMenu.Controls.Add(this.btFornecedor);
            this.pnMenu.Location = new System.Drawing.Point(251, 108);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(272, 92);
            this.pnMenu.TabIndex = 4;
            // 
            // btUsuario
            // 
            this.btUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsuario.Location = new System.Drawing.Point(76, 64);
            this.btUsuario.Name = "btUsuario";
            this.btUsuario.Size = new System.Drawing.Size(126, 25);
            this.btUsuario.TabIndex = 4;
            this.btUsuario.Text = "Usuários";
            this.btUsuario.UseVisualStyleBackColor = true;
            this.btUsuario.Click += new System.EventHandler(this.btUsuario_Click);
            // 
            // btComprar
            // 
            this.btComprar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComprar.Location = new System.Drawing.Point(7, 3);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(126, 25);
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
            this.msMenu.AutoSize = false;
            this.msMenu.BackColor = System.Drawing.Color.Transparent;
            this.msMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHistorico,
            this.menuRelatorio,
            this.menuAjuda,
            this.menuSobre});
            this.msMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msMenu.Size = new System.Drawing.Size(535, 28);
            this.msMenu.TabIndex = 8;
            this.msMenu.Text = "Menu";
            // 
            // btVenderCaixa
            // 
            this.btVenderCaixa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVenderCaixa.Location = new System.Drawing.Point(93, 16);
            this.btVenderCaixa.Name = "btVenderCaixa";
            this.btVenderCaixa.Size = new System.Drawing.Size(163, 65);
            this.btVenderCaixa.TabIndex = 9;
            this.btVenderCaixa.Text = "Vender";
            this.btVenderCaixa.UseVisualStyleBackColor = true;
            this.btVenderCaixa.Click += new System.EventHandler(this.btVenderCaixa_Click);
            // 
            // pnCaixa
            // 
            this.pnCaixa.Controls.Add(this.btVenderCaixa);
            this.pnCaixa.Location = new System.Drawing.Point(202, 92);
            this.pnCaixa.Name = "pnCaixa";
            this.pnCaixa.Size = new System.Drawing.Size(300, 108);
            this.pnCaixa.TabIndex = 10;
            this.pnCaixa.Visible = false;
            // 
            // pnAlmoxarife
            // 
            this.pnAlmoxarife.Controls.Add(this.btComprarAlmox);
            this.pnAlmoxarife.Controls.Add(this.btEstoqueAlmox);
            this.pnAlmoxarife.Controls.Add(this.btFornecedorAlmox);
            this.pnAlmoxarife.Location = new System.Drawing.Point(176, 92);
            this.pnAlmoxarife.Name = "pnAlmoxarife";
            this.pnAlmoxarife.Size = new System.Drawing.Size(359, 108);
            this.pnAlmoxarife.TabIndex = 11;
            this.pnAlmoxarife.Visible = false;
            // 
            // btComprarAlmox
            // 
            this.btComprarAlmox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComprarAlmox.Location = new System.Drawing.Point(48, 26);
            this.btComprarAlmox.Name = "btComprarAlmox";
            this.btComprarAlmox.Size = new System.Drawing.Size(126, 25);
            this.btComprarAlmox.TabIndex = 6;
            this.btComprarAlmox.Text = "Comprar";
            this.btComprarAlmox.UseVisualStyleBackColor = true;
            this.btComprarAlmox.Click += new System.EventHandler(this.btComprarAlmox_Click);
            // 
            // btEstoqueAlmox
            // 
            this.btEstoqueAlmox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEstoqueAlmox.Location = new System.Drawing.Point(185, 26);
            this.btEstoqueAlmox.Name = "btEstoqueAlmox";
            this.btEstoqueAlmox.Size = new System.Drawing.Size(120, 25);
            this.btEstoqueAlmox.TabIndex = 4;
            this.btEstoqueAlmox.Text = "Estoque";
            this.btEstoqueAlmox.UseVisualStyleBackColor = true;
            this.btEstoqueAlmox.Click += new System.EventHandler(this.btEstoqueAlmox_Click);
            // 
            // btFornecedorAlmox
            // 
            this.btFornecedorAlmox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFornecedorAlmox.Location = new System.Drawing.Point(119, 63);
            this.btFornecedorAlmox.Name = "btFornecedorAlmox";
            this.btFornecedorAlmox.Size = new System.Drawing.Size(120, 25);
            this.btFornecedorAlmox.TabIndex = 5;
            this.btFornecedorAlmox.Text = "Fornecedores";
            this.btFornecedorAlmox.UseVisualStyleBackColor = true;
            this.btFornecedorAlmox.Click += new System.EventHandler(this.btFornecedorAlmox_Click);
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
            this.picLogo.Tag = "";
            // 
            // menuHistorico
            // 
            this.menuHistorico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHistCompras,
            this.menuHistVendas});
            this.menuHistorico.Image = global::ControlX.Properties.Resources.historico_icon;
            this.menuHistorico.Name = "menuHistorico";
            this.menuHistorico.Size = new System.Drawing.Size(83, 20);
            this.menuHistorico.Text = "Historico";
            // 
            // menuHistCompras
            // 
            this.menuHistCompras.Image = global::ControlX.Properties.Resources.cart_plus;
            this.menuHistCompras.Name = "menuHistCompras";
            this.menuHistCompras.Size = new System.Drawing.Size(122, 22);
            this.menuHistCompras.Text = "Compras";
            this.menuHistCompras.Click += new System.EventHandler(this.menuHistCompras_Click);
            // 
            // menuHistVendas
            // 
            this.menuHistVendas.Image = global::ControlX.Properties.Resources.cart_minus;
            this.menuHistVendas.Name = "menuHistVendas";
            this.menuHistVendas.Size = new System.Drawing.Size(122, 22);
            this.menuHistVendas.Text = "Vendas";
            this.menuHistVendas.Click += new System.EventHandler(this.menuHistVendas_Click);
            // 
            // menuRelatorio
            // 
            this.menuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRelCompras,
            this.menuRelVendas,
            this.menuRelEstoque});
            this.menuRelatorio.Image = global::ControlX.Properties.Resources.relatorio_icon;
            this.menuRelatorio.Name = "menuRelatorio";
            this.menuRelatorio.Size = new System.Drawing.Size(87, 20);
            this.menuRelatorio.Text = "Relatorios";
            // 
            // menuRelCompras
            // 
            this.menuRelCompras.Image = global::ControlX.Properties.Resources.cart_plus;
            this.menuRelCompras.Name = "menuRelCompras";
            this.menuRelCompras.Size = new System.Drawing.Size(122, 22);
            this.menuRelCompras.Text = "Compras";
            this.menuRelCompras.Click += new System.EventHandler(this.menuRelCompras_Click);
            // 
            // menuRelVendas
            // 
            this.menuRelVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porFuncionárioToolStripMenuItem,
            this.porPeriodoToolStripMenuItem});
            this.menuRelVendas.Image = global::ControlX.Properties.Resources.cart_minus;
            this.menuRelVendas.Name = "menuRelVendas";
            this.menuRelVendas.Size = new System.Drawing.Size(122, 22);
            this.menuRelVendas.Text = "Vendas";
            // 
            // porFuncionárioToolStripMenuItem
            // 
            this.porFuncionárioToolStripMenuItem.Image = global::ControlX.Properties.Resources.user;
            this.porFuncionárioToolStripMenuItem.Name = "porFuncionárioToolStripMenuItem";
            this.porFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.porFuncionárioToolStripMenuItem.Text = "Por funcionário";
            this.porFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.porFuncionárioToolStripMenuItem_Click);
            // 
            // porPeriodoToolStripMenuItem
            // 
            this.porPeriodoToolStripMenuItem.Image = global::ControlX.Properties.Resources.icon_date;
            this.porPeriodoToolStripMenuItem.Name = "porPeriodoToolStripMenuItem";
            this.porPeriodoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.porPeriodoToolStripMenuItem.Text = "Por periodo";
            this.porPeriodoToolStripMenuItem.Click += new System.EventHandler(this.porPeriodoToolStripMenuItem_Click);
            // 
            // menuRelEstoque
            // 
            this.menuRelEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueMinimoToolStripMenuItem,
            this.inventárioToolStripMenuItem});
            this.menuRelEstoque.Image = global::ControlX.Properties.Resources.AERS;
            this.menuRelEstoque.Name = "menuRelEstoque";
            this.menuRelEstoque.Size = new System.Drawing.Size(122, 22);
            this.menuRelEstoque.Text = "Estoque";
            // 
            // estoqueMinimoToolStripMenuItem
            // 
            this.estoqueMinimoToolStripMenuItem.Image = global::ControlX.Properties.Resources.AERRS;
            this.estoqueMinimoToolStripMenuItem.Name = "estoqueMinimoToolStripMenuItem";
            this.estoqueMinimoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.estoqueMinimoToolStripMenuItem.Text = "Estóque abaixo do mínimo";
            this.estoqueMinimoToolStripMenuItem.Click += new System.EventHandler(this.estoqueMinimoToolStripMenuItem_Click);
            // 
            // inventárioToolStripMenuItem
            // 
            this.inventárioToolStripMenuItem.Image = global::ControlX.Properties.Resources.AERS;
            this.inventárioToolStripMenuItem.Name = "inventárioToolStripMenuItem";
            this.inventárioToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.inventárioToolStripMenuItem.Text = "Inventário";
            this.inventárioToolStripMenuItem.Click += new System.EventHandler(this.inventárioToolStripMenuItem_Click);
            // 
            // menuAjuda
            // 
            this.menuAjuda.Image = global::ControlX.Properties.Resources.help_icon;
            this.menuAjuda.Name = "menuAjuda";
            this.menuAjuda.Size = new System.Drawing.Size(66, 20);
            this.menuAjuda.Text = "Ajuda";
            this.menuAjuda.Click += new System.EventHandler(this.menuAjuda_Click);
            // 
            // menuSobre
            // 
            this.menuSobre.Image = global::ControlX.Properties.Resources.about_icon;
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(65, 20);
            this.menuSobre.Text = "Sobre";
            this.menuSobre.Click += new System.EventHandler(this.menuSobre_Click);
            // 
            // formMenu
            // 
            this.AcceptButton = this.btVender;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 204);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pnConectado);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.pnCaixa);
            this.Controls.Add(this.pnAlmoxarife);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlX - Menu";
            this.pnMenu.ResumeLayout(false);
            this.pnConectado.ResumeLayout(false);
            this.pnConectado.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.pnCaixa.ResumeLayout(false);
            this.pnAlmoxarife.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btFornecedor;
        private System.Windows.Forms.Button btEstoque;
        private System.Windows.Forms.Button btDesconectar;
        private System.Windows.Forms.Panel pnConectado;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btComprar;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem menuAjuda;
        private System.Windows.Forms.ToolStripMenuItem menuSobre;
        public System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.ToolStripMenuItem menuRelCompras;
        private System.Windows.Forms.ToolStripMenuItem menuRelVendas;
        private System.Windows.Forms.ToolStripMenuItem menuRelEstoque;
        public System.Windows.Forms.Button btUsuario;
        public System.Windows.Forms.ToolStripMenuItem menuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem estoqueMinimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPeriodoToolStripMenuItem;
        private System.Windows.Forms.Button btVenderCaixa;
        public System.Windows.Forms.Panel pnCaixa;
        public System.Windows.Forms.Panel pnMenu;
        public System.Windows.Forms.ToolStripMenuItem menuHistCompras;
        public System.Windows.Forms.ToolStripMenuItem menuHistorico;
        public System.Windows.Forms.ToolStripMenuItem menuHistVendas;
        public System.Windows.Forms.Button btVender;
        public System.Windows.Forms.Panel pnAlmoxarife;
        private System.Windows.Forms.Button btComprarAlmox;
        private System.Windows.Forms.Button btEstoqueAlmox;
        private System.Windows.Forms.Button btFornecedorAlmox;
    }
}