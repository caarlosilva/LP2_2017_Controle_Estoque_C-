namespace ControlX
{
    partial class FormHistoricoVendasView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricoVendasView));
            this.txValor = new System.Windows.Forms.TextBox();
            this.txId = new System.Windows.Forms.TextBox();
            this.dateVenda = new System.Windows.Forms.DateTimePicker();
            this.txUser = new System.Windows.Forms.TextBox();
            this.lbDataVenda = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbIdCompra = new System.Windows.Forms.Label();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gpDetalhesVenda = new System.Windows.Forms.GroupBox();
            this.gbItensVenda = new System.Windows.Forms.GroupBox();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NFtoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gpDetalhesVenda.SuspendLayout();
            this.gbItensVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // txValor
            // 
            this.txValor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txValor.Location = new System.Drawing.Point(371, 33);
            this.txValor.Name = "txValor";
            this.txValor.ReadOnly = true;
            this.txValor.Size = new System.Drawing.Size(98, 21);
            this.txValor.TabIndex = 11;
            this.txValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txValor.TextChanged += new System.EventHandler(this.txValor_TextChanged);
            // 
            // txId
            // 
            this.txId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txId.Location = new System.Drawing.Point(32, 33);
            this.txId.Name = "txId";
            this.txId.ReadOnly = true;
            this.txId.Size = new System.Drawing.Size(98, 21);
            this.txId.TabIndex = 8;
            this.txId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateVenda
            // 
            this.dateVenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateVenda.Enabled = false;
            this.dateVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateVenda.Location = new System.Drawing.Point(536, 33);
            this.dateVenda.Name = "dateVenda";
            this.dateVenda.Size = new System.Drawing.Size(98, 21);
            this.dateVenda.TabIndex = 2;
            // 
            // txUser
            // 
            this.txUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txUser.Location = new System.Drawing.Point(199, 33);
            this.txUser.Name = "txUser";
            this.txUser.ReadOnly = true;
            this.txUser.Size = new System.Drawing.Size(98, 21);
            this.txUser.TabIndex = 7;
            this.txUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbDataVenda
            // 
            this.lbDataVenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDataVenda.AutoSize = true;
            this.lbDataVenda.Location = new System.Drawing.Point(535, 17);
            this.lbDataVenda.Name = "lbDataVenda";
            this.lbDataVenda.Size = new System.Drawing.Size(96, 13);
            this.lbDataVenda.TabIndex = 4;
            this.lbDataVenda.Text = "Data da venda:";
            // 
            // lbValor
            // 
            this.lbValor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(401, 17);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(42, 13);
            this.lbValor.TabIndex = 2;
            this.lbValor.Text = "Valor:";
            this.lbValor.Click += new System.EventHandler(this.lbValor_Click);
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit.FillWeight = 30F;
            this.unit.HeaderText = "Un";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // qtd
            // 
            this.qtd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qtd.FillWeight = 40F;
            this.qtd.HeaderText = "Qtd.";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.preco.FillWeight = 50F;
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.FillWeight = 130F;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.FillWeight = 50F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // lbUsuario
            // 
            this.lbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(211, 17);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(67, 13);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Vendedor:";
            // 
            // lbIdCompra
            // 
            this.lbIdCompra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbIdCompra.AutoSize = true;
            this.lbIdCompra.Location = new System.Drawing.Point(71, 17);
            this.lbIdCompra.Name = "lbIdCompra";
            this.lbIdCompra.Size = new System.Drawing.Size(24, 13);
            this.lbIdCompra.TabIndex = 0;
            this.lbIdCompra.Text = "Id:";
            // 
            // fornecedor
            // 
            this.fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.preco,
            this.qtd,
            this.unit,
            this.fornecedor});
            this.dgvProdutos.Location = new System.Drawing.Point(3, 17);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(667, 338);
            this.dgvProdutos.TabIndex = 8;
            this.dgvProdutos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProdutos_CellMouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.NFtoolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gpDetalhesVenda
            // 
            this.gpDetalhesVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpDetalhesVenda.Controls.Add(this.txValor);
            this.gpDetalhesVenda.Controls.Add(this.lbIdCompra);
            this.gpDetalhesVenda.Controls.Add(this.txId);
            this.gpDetalhesVenda.Controls.Add(this.lbUsuario);
            this.gpDetalhesVenda.Controls.Add(this.dateVenda);
            this.gpDetalhesVenda.Controls.Add(this.lbValor);
            this.gpDetalhesVenda.Controls.Add(this.txUser);
            this.gpDetalhesVenda.Controls.Add(this.lbDataVenda);
            this.gpDetalhesVenda.Location = new System.Drawing.Point(3, 27);
            this.gpDetalhesVenda.Name = "gpDetalhesVenda";
            this.gpDetalhesVenda.Size = new System.Drawing.Size(673, 70);
            this.gpDetalhesVenda.TabIndex = 11;
            this.gpDetalhesVenda.TabStop = false;
            this.gpDetalhesVenda.Text = "Detalhes da Venda";
            // 
            // gbItensVenda
            // 
            this.gbItensVenda.Controls.Add(this.dgvProdutos);
            this.gbItensVenda.Location = new System.Drawing.Point(3, 103);
            this.gbItensVenda.Name = "gbItensVenda";
            this.gbItensVenda.Size = new System.Drawing.Size(673, 358);
            this.gbItensVenda.TabIndex = 12;
            this.gbItensVenda.TabStop = false;
            this.gbItensVenda.Text = "Itens da Venda";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Image = global::ControlX.Properties.Resources.left_arrow;
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // NFtoolStripMenu
            // 
            this.NFtoolStripMenu.Image = global::ControlX.Properties.Resources.nf;
            this.NFtoolStripMenu.Name = "NFtoolStripMenu";
            this.NFtoolStripMenu.Size = new System.Drawing.Size(93, 20);
            this.NFtoolStripMenu.Text = "Nota Fiscal";
            this.NFtoolStripMenu.Click += new System.EventHandler(this.NFtoolStripMenu_Click);
            // 
            // FormHistoricoVendasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 462);
            this.Controls.Add(this.gbItensVenda);
            this.Controls.Add(this.gpDetalhesVenda);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHistoricoVendasView";
            this.Text = "ControlX - Histórico de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpDetalhesVenda.ResumeLayout(false);
            this.gpDetalhesVenda.PerformLayout();
            this.gbItensVenda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txValor;
        public System.Windows.Forms.TextBox txId;
        public System.Windows.Forms.DateTimePicker dateVenda;
        public System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.Label lbDataVenda;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbIdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        public System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpDetalhesVenda;
        private System.Windows.Forms.GroupBox gbItensVenda;
        private System.Windows.Forms.ToolStripMenuItem NFtoolStripMenu;
    }
}