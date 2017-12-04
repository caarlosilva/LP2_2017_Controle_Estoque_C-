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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricoComprasView));
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetalhes = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gbItens = new System.Windows.Forms.GroupBox();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.gbDetalhes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbItens.SuspendLayout();
            this.SuspendLayout();
            // 
            // txValor
            // 
            this.txValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txValor.Location = new System.Drawing.Point(364, 46);
            this.txValor.Name = "txValor";
            this.txValor.ReadOnly = true;
            this.txValor.Size = new System.Drawing.Size(98, 21);
            this.txValor.TabIndex = 11;
            this.txValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txValor.TextChanged += new System.EventHandler(this.txValor_TextChanged);
            // 
            // txStatus
            // 
            this.txStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txStatus.Location = new System.Drawing.Point(529, 46);
            this.txStatus.Name = "txStatus";
            this.txStatus.ReadOnly = true;
            this.txStatus.Size = new System.Drawing.Size(98, 21);
            this.txStatus.TabIndex = 10;
            this.txStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txId
            // 
            this.txId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txId.Location = new System.Drawing.Point(25, 46);
            this.txId.Name = "txId";
            this.txId.ReadOnly = true;
            this.txId.Size = new System.Drawing.Size(98, 21);
            this.txId.TabIndex = 8;
            this.txId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateEntrega
            // 
            this.dateEntrega.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateEntrega.Enabled = false;
            this.dateEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEntrega.Location = new System.Drawing.Point(404, 92);
            this.dateEntrega.Name = "dateEntrega";
            this.dateEntrega.Size = new System.Drawing.Size(98, 21);
            this.dateEntrega.TabIndex = 9;
            // 
            // dateCompra
            // 
            this.dateCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateCompra.Enabled = false;
            this.dateCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCompra.Location = new System.Drawing.Point(157, 92);
            this.dateCompra.Name = "dateCompra";
            this.dateCompra.Size = new System.Drawing.Size(98, 21);
            this.dateCompra.TabIndex = 2;
            // 
            // txUser
            // 
            this.txUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txUser.Location = new System.Drawing.Point(166, 46);
            this.txUser.Name = "txUser";
            this.txUser.ReadOnly = true;
            this.txUser.Size = new System.Drawing.Size(151, 21);
            this.txUser.TabIndex = 7;
            this.txUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbEntrega
            // 
            this.lbEntrega.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEntrega.AutoSize = true;
            this.lbEntrega.Location = new System.Drawing.Point(401, 76);
            this.lbEntrega.Name = "lbEntrega";
            this.lbEntrega.Size = new System.Drawing.Size(105, 13);
            this.lbEntrega.TabIndex = 5;
            this.lbEntrega.Text = "Data da entrega:";
            // 
            // lbDataCompra
            // 
            this.lbDataCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDataCompra.AutoSize = true;
            this.lbDataCompra.Location = new System.Drawing.Point(154, 76);
            this.lbDataCompra.Name = "lbDataCompra";
            this.lbDataCompra.Size = new System.Drawing.Size(104, 13);
            this.lbDataCompra.TabIndex = 4;
            this.lbDataCompra.Text = "Data da compra:";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(514, 30);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(126, 13);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Status/Entregue em:";
            // 
            // lbValor
            // 
            this.lbValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(393, 30);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(42, 13);
            this.lbValor.TabIndex = 2;
            this.lbValor.Text = "Valor:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(213, 30);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(55, 13);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Usuário:";
            // 
            // lbIdCompra
            // 
            this.lbIdCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbIdCompra.AutoSize = true;
            this.lbIdCompra.Location = new System.Drawing.Point(63, 30);
            this.lbIdCompra.Name = "lbIdCompra";
            this.lbIdCompra.Size = new System.Drawing.Size(24, 13);
            this.lbIdCompra.TabIndex = 0;
            this.lbIdCompra.Text = "Id:";
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
            this.dgvProdutos.Size = new System.Drawing.Size(667, 277);
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
            // gbDetalhes
            // 
            this.gbDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetalhes.Controls.Add(this.txValor);
            this.gbDetalhes.Controls.Add(this.lbIdCompra);
            this.gbDetalhes.Controls.Add(this.txStatus);
            this.gbDetalhes.Controls.Add(this.lbUsuario);
            this.gbDetalhes.Controls.Add(this.txId);
            this.gbDetalhes.Controls.Add(this.lbValor);
            this.gbDetalhes.Controls.Add(this.dateEntrega);
            this.gbDetalhes.Controls.Add(this.lbStatus);
            this.gbDetalhes.Controls.Add(this.dateCompra);
            this.gbDetalhes.Controls.Add(this.lbDataCompra);
            this.gbDetalhes.Controls.Add(this.txUser);
            this.gbDetalhes.Controls.Add(this.lbEntrega);
            this.gbDetalhes.Location = new System.Drawing.Point(3, 27);
            this.gbDetalhes.Name = "gbDetalhes";
            this.gbDetalhes.Size = new System.Drawing.Size(673, 134);
            this.gbDetalhes.TabIndex = 6;
            this.gbDetalhes.TabStop = false;
            this.gbDetalhes.Text = "Detalhes da Compra";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.notaFiscalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gbItens
            // 
            this.gbItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbItens.Controls.Add(this.dgvProdutos);
            this.gbItens.Location = new System.Drawing.Point(3, 167);
            this.gbItens.Name = "gbItens";
            this.gbItens.Size = new System.Drawing.Size(673, 297);
            this.gbItens.TabIndex = 8;
            this.gbItens.TabStop = false;
            this.gbItens.Text = "Itens da Compra";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Image = global::ControlX.Properties.Resources.left_arrow;
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // notaFiscalToolStripMenuItem
            // 
            this.notaFiscalToolStripMenuItem.Image = global::ControlX.Properties.Resources.nf;
            this.notaFiscalToolStripMenuItem.Name = "notaFiscalToolStripMenuItem";
            this.notaFiscalToolStripMenuItem.ShowShortcutKeys = false;
            this.notaFiscalToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.notaFiscalToolStripMenuItem.Text = "Nota Fiscal";
            this.notaFiscalToolStripMenuItem.Click += new System.EventHandler(this.notaFiscalToolStripMenuItem_Click);
            // 
            // FormHistoricoComprasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 462);
            this.Controls.Add(this.gbItens);
            this.Controls.Add(this.gbDetalhes);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHistoricoComprasView";
            this.Text = "ControlX - Historico de Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.gbDetalhes.ResumeLayout(false);
            this.gbDetalhes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbItens.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbEntrega;
        private System.Windows.Forms.Label lbDataCompra;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbIdCompra;
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
        private System.Windows.Forms.GroupBox gbDetalhes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbItens;
        private System.Windows.Forms.ToolStripMenuItem notaFiscalToolStripMenuItem;
    }
}