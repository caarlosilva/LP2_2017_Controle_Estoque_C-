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
            this.btVoltar = new System.Windows.Forms.Button();
            this.txValor = new System.Windows.Forms.TextBox();
            this.txId = new System.Windows.Forms.TextBox();
            this.dateCompra = new System.Windows.Forms.DateTimePicker();
            this.txUser = new System.Windows.Forms.TextBox();
            this.lbDataVenda = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbProdutos = new System.Windows.Forms.Label();
            this.lbDadosVenda = new System.Windows.Forms.Label();
            this.lbIdCompra = new System.Windows.Forms.Label();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.pnCompras = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.pnCompras.SuspendLayout();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(236, 340);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(178, 23);
            this.btVoltar.TabIndex = 9;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(354, 25);
            this.txValor.Name = "txValor";
            this.txValor.ReadOnly = true;
            this.txValor.Size = new System.Drawing.Size(85, 20);
            this.txValor.TabIndex = 11;
            this.txValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(14, 25);
            this.txId.Name = "txId";
            this.txId.ReadOnly = true;
            this.txId.Size = new System.Drawing.Size(85, 20);
            this.txId.TabIndex = 8;
            this.txId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateCompra
            // 
            this.dateCompra.Enabled = false;
            this.dateCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCompra.Location = new System.Drawing.Point(524, 25);
            this.dateCompra.Name = "dateCompra";
            this.dateCompra.Size = new System.Drawing.Size(85, 20);
            this.dateCompra.TabIndex = 2;
            // 
            // txUser
            // 
            this.txUser.Location = new System.Drawing.Point(184, 25);
            this.txUser.Name = "txUser";
            this.txUser.ReadOnly = true;
            this.txUser.Size = new System.Drawing.Size(85, 20);
            this.txUser.TabIndex = 7;
            this.txUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbDataVenda
            // 
            this.lbDataVenda.AutoSize = true;
            this.lbDataVenda.Location = new System.Drawing.Point(523, 9);
            this.lbDataVenda.Name = "lbDataVenda";
            this.lbDataVenda.Size = new System.Drawing.Size(81, 13);
            this.lbDataVenda.TabIndex = 4;
            this.lbDataVenda.Text = "Data da venda:";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(379, 9);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(34, 13);
            this.lbValor.TabIndex = 2;
            this.lbValor.Text = "Valor:";
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
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(203, 9);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(46, 13);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbProdutos
            // 
            this.lbProdutos.AutoSize = true;
            this.lbProdutos.Location = new System.Drawing.Point(10, 95);
            this.lbProdutos.Name = "lbProdutos";
            this.lbProdutos.Size = new System.Drawing.Size(52, 13);
            this.lbProdutos.TabIndex = 7;
            this.lbProdutos.Text = "Produtos:";
            // 
            // lbDadosVenda
            // 
            this.lbDadosVenda.AutoSize = true;
            this.lbDadosVenda.Location = new System.Drawing.Point(10, 12);
            this.lbDadosVenda.Name = "lbDadosVenda";
            this.lbDadosVenda.Size = new System.Drawing.Size(89, 13);
            this.lbDadosVenda.TabIndex = 6;
            this.lbDadosVenda.Text = "Dados da venda:";
            // 
            // lbIdCompra
            // 
            this.lbIdCompra.AutoSize = true;
            this.lbIdCompra.Location = new System.Drawing.Point(47, 9);
            this.lbIdCompra.Name = "lbIdCompra";
            this.lbIdCompra.Size = new System.Drawing.Size(19, 13);
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
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.preco,
            this.qtd,
            this.unit,
            this.fornecedor});
            this.dgvProdutos.Location = new System.Drawing.Point(13, 112);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(627, 219);
            this.dgvProdutos.TabIndex = 8;
            // 
            // pnCompras
            // 
            this.pnCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCompras.Controls.Add(this.txValor);
            this.pnCompras.Controls.Add(this.txId);
            this.pnCompras.Controls.Add(this.dateCompra);
            this.pnCompras.Controls.Add(this.txUser);
            this.pnCompras.Controls.Add(this.lbDataVenda);
            this.pnCompras.Controls.Add(this.lbValor);
            this.pnCompras.Controls.Add(this.lbUsuario);
            this.pnCompras.Controls.Add(this.lbIdCompra);
            this.pnCompras.Location = new System.Drawing.Point(13, 28);
            this.pnCompras.Name = "pnCompras";
            this.pnCompras.Size = new System.Drawing.Size(627, 58);
            this.pnCompras.TabIndex = 5;
            // 
            // FormHistoricoVendasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 371);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.lbProdutos);
            this.Controls.Add(this.lbDadosVenda);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.pnCompras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHistoricoVendasView";
            this.Text = "ControlX - Histórico de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.pnCompras.ResumeLayout(false);
            this.pnCompras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltar;
        public System.Windows.Forms.TextBox txValor;
        public System.Windows.Forms.TextBox txId;
        public System.Windows.Forms.DateTimePicker dateCompra;
        public System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.Label lbDataVenda;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbProdutos;
        private System.Windows.Forms.Label lbDadosVenda;
        private System.Windows.Forms.Label lbIdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        public System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Panel pnCompras;
    }
}