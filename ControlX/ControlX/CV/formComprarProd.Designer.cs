namespace ControlX
{
    partial class formEditComprar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEditComprar));
            this.btComprar = new System.Windows.Forms.Button();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.pnCadastro = new System.Windows.Forms.Panel();
            this.txQntdCompra = new System.Windows.Forms.TextBox();
            this.lbQntdCompra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.lbQntd = new System.Windows.Forms.Label();
            this.txQntd = new System.Windows.Forms.TextBox();
            this.lbIdProduto = new System.Windows.Forms.Label();
            this.pnBtCad = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txPreco = new System.Windows.Forms.TextBox();
            this.pnCadastro.SuspendLayout();
            this.pnBtCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btComprar
            // 
            this.btComprar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComprar.Location = new System.Drawing.Point(108, 2);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(87, 23);
            this.btComprar.TabIndex = 0;
            this.btComprar.Text = "Comprar";
            this.btComprar.UseVisualStyleBackColor = true;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // txNome
            // 
            this.txNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(52, 19);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(324, 21);
            this.txNome.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(5, 22);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(408, 22);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 13);
            this.lbId.TabIndex = 5;
            this.lbId.Text = "ID:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(5, 62);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(44, 13);
            this.lbPreco.TabIndex = 2;
            this.lbPreco.Text = "Preço:";
            // 
            // pnCadastro
            // 
            this.pnCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCadastro.Controls.Add(this.txQntdCompra);
            this.pnCadastro.Controls.Add(this.lbQntdCompra);
            this.pnCadastro.Controls.Add(this.label1);
            this.pnCadastro.Controls.Add(this.cbFornecedor);
            this.pnCadastro.Controls.Add(this.lbQntd);
            this.pnCadastro.Controls.Add(this.txQntd);
            this.pnCadastro.Controls.Add(this.lbIdProduto);
            this.pnCadastro.Controls.Add(this.pnBtCad);
            this.pnCadastro.Controls.Add(this.txNome);
            this.pnCadastro.Controls.Add(this.txPreco);
            this.pnCadastro.Controls.Add(this.lbNome);
            this.pnCadastro.Controls.Add(this.lbId);
            this.pnCadastro.Controls.Add(this.lbPreco);
            this.pnCadastro.Location = new System.Drawing.Point(3, 10);
            this.pnCadastro.Name = "pnCadastro";
            this.pnCadastro.Size = new System.Drawing.Size(541, 121);
            this.pnCadastro.TabIndex = 8;
            // 
            // txQntdCompra
            // 
            this.txQntdCompra.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQntdCompra.Location = new System.Drawing.Point(162, 95);
            this.txQntdCompra.Name = "txQntdCompra";
            this.txQntdCompra.Size = new System.Drawing.Size(95, 21);
            this.txQntdCompra.TabIndex = 15;
            this.txQntdCompra.TextChanged += new System.EventHandler(this.txQntdCompra_TextChanged);
            this.txQntdCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txQntdCompra_KeyPress);
            // 
            // lbQntdCompra
            // 
            this.lbQntdCompra.AutoSize = true;
            this.lbQntdCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQntdCompra.Location = new System.Drawing.Point(48, 98);
            this.lbQntdCompra.Name = "lbQntdCompra";
            this.lbQntdCompra.Size = new System.Drawing.Size(108, 13);
            this.lbQntdCompra.TabIndex = 14;
            this.lbQntdCompra.Text = "Quant. comprada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fornecedor:";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(388, 59);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(146, 21);
            this.cbFornecedor.TabIndex = 12;
            // 
            // lbQntd
            // 
            this.lbQntd.AutoSize = true;
            this.lbQntd.Location = new System.Drawing.Point(159, 62);
            this.lbQntd.Name = "lbQntd";
            this.lbQntd.Size = new System.Drawing.Size(42, 13);
            this.lbQntd.TabIndex = 11;
            this.lbQntd.Text = "Quant.:";
            // 
            // txQntd
            // 
            this.txQntd.Location = new System.Drawing.Point(213, 59);
            this.txQntd.Name = "txQntd";
            this.txQntd.Size = new System.Drawing.Size(88, 20);
            this.txQntd.TabIndex = 2;
            // 
            // lbIdProduto
            // 
            this.lbIdProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbIdProduto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdProduto.Location = new System.Drawing.Point(435, 19);
            this.lbIdProduto.Name = "lbIdProduto";
            this.lbIdProduto.Size = new System.Drawing.Size(95, 21);
            this.lbIdProduto.TabIndex = 9;
            this.lbIdProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBtCad
            // 
            this.pnBtCad.Controls.Add(this.btCancelar);
            this.pnBtCad.Controls.Add(this.btComprar);
            this.pnBtCad.Location = new System.Drawing.Point(339, 93);
            this.pnBtCad.Name = "pnBtCad";
            this.pnBtCad.Size = new System.Drawing.Size(202, 28);
            this.pnBtCad.TabIndex = 8;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(8, 1);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(87, 23);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txPreco
            // 
            this.txPreco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPreco.Location = new System.Drawing.Point(52, 59);
            this.txPreco.Name = "txPreco";
            this.txPreco.Size = new System.Drawing.Size(94, 21);
            this.txPreco.TabIndex = 1;
            // 
            // formEditComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 140);
            this.Controls.Add(this.pnCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formEditComprar";
            this.Text = "Comprar Produto";
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            this.pnBtCad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btComprar;
        public System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Panel pnCadastro;
        public System.Windows.Forms.TextBox txQntdCompra;
        private System.Windows.Forms.Label lbQntdCompra;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label lbQntd;
        public System.Windows.Forms.TextBox txQntd;
        public System.Windows.Forms.Label lbIdProduto;
        private System.Windows.Forms.Panel pnBtCad;
        public System.Windows.Forms.Button btCancelar;
        public System.Windows.Forms.TextBox txPreco;
    }
}