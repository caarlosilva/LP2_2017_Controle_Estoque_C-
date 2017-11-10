namespace ControlX.CV
{
    partial class FormHistoricoComprasView
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
            this.pnCompras = new System.Windows.Forms.Panel();
            this.txValor = new System.Windows.Forms.TextBox();
            this.txStatus = new System.Windows.Forms.TextBox();
            this.txId = new System.Windows.Forms.TextBox();
            this.dateEntrega = new System.Windows.Forms.DateTimePicker();
            this.dateCompra = new System.Windows.Forms.DateTimePicker();
            this.txUser = new System.Windows.Forms.TextBox();
            this.lbEntrega = new System.Windows.Forms.Label();
            this.lbDataCompra = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbIdCompra = new System.Windows.Forms.Label();
            this.lbDadosCompras = new System.Windows.Forms.Label();
            this.lbProdutos = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btVoltar = new System.Windows.Forms.Button();
            this.pnCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCompras
            // 
            this.pnCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCompras.Controls.Add(this.txValor);
            this.pnCompras.Controls.Add(this.txStatus);
            this.pnCompras.Controls.Add(this.txId);
            this.pnCompras.Controls.Add(this.dateEntrega);
            this.pnCompras.Controls.Add(this.dateCompra);
            this.pnCompras.Controls.Add(this.txUser);
            this.pnCompras.Controls.Add(this.lbEntrega);
            this.pnCompras.Controls.Add(this.lbDataCompra);
            this.pnCompras.Controls.Add(this.lbStatus);
            this.pnCompras.Controls.Add(this.lbValor);
            this.pnCompras.Controls.Add(this.lbUsuario);
            this.pnCompras.Controls.Add(this.lbIdCompra);
            this.pnCompras.Location = new System.Drawing.Point(12, 30);
            this.pnCompras.Name = "pnCompras";
            this.pnCompras.Size = new System.Drawing.Size(627, 102);
            this.pnCompras.TabIndex = 0;
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(356, 25);
            this.txValor.Name = "txValor";
            this.txValor.ReadOnly = true;
            this.txValor.Size = new System.Drawing.Size(85, 20);
            this.txValor.TabIndex = 11;
            this.txValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txStatus
            // 
            this.txStatus.Location = new System.Drawing.Point(530, 25);
            this.txStatus.Name = "txStatus";
            this.txStatus.ReadOnly = true;
            this.txStatus.Size = new System.Drawing.Size(85, 20);
            this.txStatus.TabIndex = 10;
            this.txStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(10, 25);
            this.txId.Name = "txId";
            this.txId.ReadOnly = true;
            this.txId.Size = new System.Drawing.Size(85, 20);
            this.txId.TabIndex = 8;
            this.txId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateEntrega
            // 
            this.dateEntrega.Enabled = false;
            this.dateEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEntrega.Location = new System.Drawing.Point(406, 68);
            this.dateEntrega.Name = "dateEntrega";
            this.dateEntrega.Size = new System.Drawing.Size(85, 20);
            this.dateEntrega.TabIndex = 9;
            // 
            // dateCompra
            // 
            this.dateCompra.Enabled = false;
            this.dateCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCompra.Location = new System.Drawing.Point(204, 68);
            this.dateCompra.Name = "dateCompra";
            this.dateCompra.Size = new System.Drawing.Size(85, 20);
            this.dateCompra.TabIndex = 2;
            // 
            // txUser
            // 
            this.txUser.Location = new System.Drawing.Point(182, 25);
            this.txUser.Name = "txUser";
            this.txUser.ReadOnly = true;
            this.txUser.Size = new System.Drawing.Size(85, 20);
            this.txUser.TabIndex = 7;
            this.txUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbEntrega
            // 
            this.lbEntrega.AutoSize = true;
            this.lbEntrega.Location = new System.Drawing.Point(313, 71);
            this.lbEntrega.Name = "lbEntrega";
            this.lbEntrega.Size = new System.Drawing.Size(87, 13);
            this.lbEntrega.TabIndex = 5;
            this.lbEntrega.Text = "Data da entrega:";
            // 
            // lbDataCompra
            // 
            this.lbDataCompra.AutoSize = true;
            this.lbDataCompra.Location = new System.Drawing.Point(112, 71);
            this.lbDataCompra.Name = "lbDataCompra";
            this.lbDataCompra.Size = new System.Drawing.Size(86, 13);
            this.lbDataCompra.TabIndex = 4;
            this.lbDataCompra.Text = "Data da compra:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(552, 9);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Status:";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(381, 9);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(34, 13);
            this.lbValor.TabIndex = 2;
            this.lbValor.Text = "Valor:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(201, 9);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(46, 13);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbIdCompra
            // 
            this.lbIdCompra.AutoSize = true;
            this.lbIdCompra.Location = new System.Drawing.Point(43, 9);
            this.lbIdCompra.Name = "lbIdCompra";
            this.lbIdCompra.Size = new System.Drawing.Size(19, 13);
            this.lbIdCompra.TabIndex = 0;
            this.lbIdCompra.Text = "Id:";
            // 
            // lbDadosCompras
            // 
            this.lbDadosCompras.AutoSize = true;
            this.lbDadosCompras.Location = new System.Drawing.Point(9, 14);
            this.lbDadosCompras.Name = "lbDadosCompras";
            this.lbDadosCompras.Size = new System.Drawing.Size(94, 13);
            this.lbDadosCompras.TabIndex = 1;
            this.lbDadosCompras.Text = "Dados da compra:";
            // 
            // lbProdutos
            // 
            this.lbProdutos.AutoSize = true;
            this.lbProdutos.Location = new System.Drawing.Point(9, 149);
            this.lbProdutos.Name = "lbProdutos";
            this.lbProdutos.Size = new System.Drawing.Size(52, 13);
            this.lbProdutos.TabIndex = 2;
            this.lbProdutos.Text = "Produtos:";
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
            this.dgvProdutos.Location = new System.Drawing.Point(12, 166);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(627, 219);
            this.dgvProdutos.TabIndex = 3;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.FillWeight = 50F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.FillWeight = 130F;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.preco.FillWeight = 50F;
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // qtd
            // 
            this.qtd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qtd.FillWeight = 40F;
            this.qtd.HeaderText = "Qtd.";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit.FillWeight = 30F;
            this.unit.HeaderText = "Un";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // fornecedor
            // 
            this.fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(235, 394);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(178, 23);
            this.btVoltar.TabIndex = 4;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // FormHistoricoComprasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 426);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lbProdutos);
            this.Controls.Add(this.lbDadosCompras);
            this.Controls.Add(this.pnCompras);
            this.Name = "FormHistoricoComprasView";
            this.Text = "ControlX - Historico de Compras";
            this.pnCompras.ResumeLayout(false);
            this.pnCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnCompras;
        private System.Windows.Forms.Label lbEntrega;
        private System.Windows.Forms.Label lbDataCompra;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbIdCompra;
        private System.Windows.Forms.Label lbDadosCompras;
        private System.Windows.Forms.Label lbProdutos;
        private System.Windows.Forms.Button btVoltar;
        public System.Windows.Forms.TextBox txValor;
        public System.Windows.Forms.TextBox txStatus;
        public System.Windows.Forms.TextBox txId;
        public System.Windows.Forms.DateTimePicker dateEntrega;
        public System.Windows.Forms.DateTimePicker dateCompra;
        public System.Windows.Forms.TextBox txUser;
        public System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
    }
}