namespace ControlX
{
    partial class formCadastroProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastroProd));
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.pnCadastro = new System.Windows.Forms.Panel();
            this.lbEstoqueMin = new System.Windows.Forms.Label();
            this.txEstoqueMin = new System.Windows.Forms.TextBox();
            this.cbTipoUn = new System.Windows.Forms.ComboBox();
            this.lbTipoVenda = new System.Windows.Forms.Label();
            this.btImagem = new System.Windows.Forms.Button();
            this.pbImagemProd = new System.Windows.Forms.PictureBox();
            this.txPreco = new System.Windows.Forms.MaskedTextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.lbQntd = new System.Windows.Forms.Label();
            this.txQntd = new System.Windows.Forms.TextBox();
            this.lbIdProduto = new System.Windows.Forms.Label();
            this.pnBtCad = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.pnCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProd)).BeginInit();
            this.pnBtCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(332, 3);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(89, 23);
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(109, 23);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(5, 61);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(44, 13);
            this.lbPreco.TabIndex = 2;
            this.lbPreco.Text = "Preço:";
            // 
            // txNome
            // 
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(152, 19);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(280, 21);
            this.txNome.TabIndex = 0;
            this.txNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNome_KeyPress);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(5, 23);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 13);
            this.lbId.TabIndex = 5;
            this.lbId.Text = "ID:";
            // 
            // pnCadastro
            // 
            this.pnCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCadastro.Controls.Add(this.lbEstoqueMin);
            this.pnCadastro.Controls.Add(this.txEstoqueMin);
            this.pnCadastro.Controls.Add(this.cbTipoUn);
            this.pnCadastro.Controls.Add(this.lbTipoVenda);
            this.pnCadastro.Controls.Add(this.btImagem);
            this.pnCadastro.Controls.Add(this.pbImagemProd);
            this.pnCadastro.Controls.Add(this.txPreco);
            this.pnCadastro.Controls.Add(this.lbCategoria);
            this.pnCadastro.Controls.Add(this.cbCategoria);
            this.pnCadastro.Controls.Add(this.label1);
            this.pnCadastro.Controls.Add(this.cbFornecedor);
            this.pnCadastro.Controls.Add(this.lbQntd);
            this.pnCadastro.Controls.Add(this.txQntd);
            this.pnCadastro.Controls.Add(this.lbIdProduto);
            this.pnCadastro.Controls.Add(this.pnBtCad);
            this.pnCadastro.Controls.Add(this.txNome);
            this.pnCadastro.Controls.Add(this.lbNome);
            this.pnCadastro.Controls.Add(this.lbId);
            this.pnCadastro.Controls.Add(this.lbPreco);
            this.pnCadastro.Location = new System.Drawing.Point(5, 6);
            this.pnCadastro.Name = "pnCadastro";
            this.pnCadastro.Size = new System.Drawing.Size(444, 234);
            this.pnCadastro.TabIndex = 7;
            // 
            // lbEstoqueMin
            // 
            this.lbEstoqueMin.AutoSize = true;
            this.lbEstoqueMin.Location = new System.Drawing.Point(173, 91);
            this.lbEstoqueMin.Name = "lbEstoqueMin";
            this.lbEstoqueMin.Size = new System.Drawing.Size(52, 26);
            this.lbEstoqueMin.TabIndex = 21;
            this.lbEstoqueMin.Text = "Estoque\r\nMinimo:";
            // 
            // txEstoqueMin
            // 
            this.txEstoqueMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txEstoqueMin.Location = new System.Drawing.Point(234, 95);
            this.txEstoqueMin.Name = "txEstoqueMin";
            this.txEstoqueMin.Size = new System.Drawing.Size(55, 21);
            this.txEstoqueMin.TabIndex = 4;
            this.txEstoqueMin.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            this.txEstoqueMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txEstoqueMin_KeyPress);
            // 
            // cbTipoUn
            // 
            this.cbTipoUn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbTipoUn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoUn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTipoUn.FormattingEnabled = true;
            this.cbTipoUn.Items.AddRange(new object[] {
            "UN",
            "KG",
            "CM",
            "M",
            "L",
            "M²",
            "M³"});
            this.cbTipoUn.Location = new System.Drawing.Point(234, 57);
            this.cbTipoUn.Name = "cbTipoUn";
            this.cbTipoUn.Size = new System.Drawing.Size(55, 21);
            this.cbTipoUn.TabIndex = 2;
            this.cbTipoUn.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // lbTipoVenda
            // 
            this.lbTipoVenda.AutoSize = true;
            this.lbTipoVenda.Location = new System.Drawing.Point(173, 61);
            this.lbTipoVenda.Name = "lbTipoVenda";
            this.lbTipoVenda.Size = new System.Drawing.Size(59, 13);
            this.lbTipoVenda.TabIndex = 19;
            this.lbTipoVenda.Text = "Tipo Un.:";
            // 
            // btImagem
            // 
            this.btImagem.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImagem.Location = new System.Drawing.Point(310, 176);
            this.btImagem.Name = "btImagem";
            this.btImagem.Size = new System.Drawing.Size(122, 18);
            this.btImagem.TabIndex = 7;
            this.btImagem.Text = "Escolher Imagem";
            this.btImagem.UseVisualStyleBackColor = true;
            this.btImagem.Click += new System.EventHandler(this.btImagem_Click);
            // 
            // pbImagemProd
            // 
            this.pbImagemProd.BackgroundImage = global::ControlX.Properties.Resources.product;
            this.pbImagemProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagemProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemProd.InitialImage = null;
            this.pbImagemProd.Location = new System.Drawing.Point(310, 46);
            this.pbImagemProd.Name = "pbImagemProd";
            this.pbImagemProd.Size = new System.Drawing.Size(121, 124);
            this.pbImagemProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProd.TabIndex = 17;
            this.pbImagemProd.TabStop = false;
            // 
            // txPreco
            // 
            this.txPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txPreco.Location = new System.Drawing.Point(61, 58);
            this.txPreco.Name = "txPreco";
            this.txPreco.PromptChar = ' ';
            this.txPreco.Size = new System.Drawing.Size(108, 21);
            this.txPreco.TabIndex = 1;
            this.txPreco.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            this.txPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPreco_KeyPress);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(5, 166);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(68, 13);
            this.lbCategoria.TabIndex = 15;
            this.lbCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(81, 163);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(208, 21);
            this.cbCategoria.TabIndex = 6;
            this.cbCategoria.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fornecedor:";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(81, 130);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(208, 21);
            this.cbFornecedor.TabIndex = 5;
            this.cbFornecedor.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // lbQntd
            // 
            this.lbQntd.AutoSize = true;
            this.lbQntd.Location = new System.Drawing.Point(5, 98);
            this.lbQntd.Name = "lbQntd";
            this.lbQntd.Size = new System.Drawing.Size(50, 13);
            this.lbQntd.TabIndex = 11;
            this.lbQntd.Text = "Quant.:";
            // 
            // txQntd
            // 
            this.txQntd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txQntd.Location = new System.Drawing.Point(61, 95);
            this.txQntd.Name = "txQntd";
            this.txQntd.Size = new System.Drawing.Size(108, 21);
            this.txQntd.TabIndex = 3;
            this.txQntd.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            this.txQntd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txQntd_KeyPress);
            // 
            // lbIdProduto
            // 
            this.lbIdProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIdProduto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdProduto.Location = new System.Drawing.Point(37, 19);
            this.lbIdProduto.Name = "lbIdProduto";
            this.lbIdProduto.Size = new System.Drawing.Size(66, 21);
            this.lbIdProduto.TabIndex = 9;
            this.lbIdProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBtCad
            // 
            this.pnBtCad.Controls.Add(this.btCancelar);
            this.pnBtCad.Controls.Add(this.btCadastrar);
            this.pnBtCad.Location = new System.Drawing.Point(8, 200);
            this.pnBtCad.Name = "pnBtCad";
            this.pnBtCad.Size = new System.Drawing.Size(424, 28);
            this.pnBtCad.TabIndex = 8;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(8, 1);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(87, 23);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // formCadastroProd
            // 
            this.AcceptButton = this.btCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(450, 243);
            this.Controls.Add(this.pnCadastro);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCadastroProd";
            this.Text = "ControlX - Cadastrar Produto";
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProd)).EndInit();
            this.pnBtCad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel pnCadastro;
        private System.Windows.Forms.Panel pnBtCad;
        private System.Windows.Forms.Label lbQntd;
        public System.Windows.Forms.TextBox txNome;
        public System.Windows.Forms.Button btCadastrar;
        public System.Windows.Forms.Label lbIdProduto;
        public System.Windows.Forms.Button btCancelar;
        public System.Windows.Forms.TextBox txQntd;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label lbCategoria;
        public System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lbTipoVenda;
        public System.Windows.Forms.MaskedTextBox txPreco;
        public System.Windows.Forms.ComboBox cbTipoUn;
        public System.Windows.Forms.Button btImagem;
        public System.Windows.Forms.PictureBox pbImagemProd;
        private System.Windows.Forms.Label lbEstoqueMin;
        public System.Windows.Forms.TextBox txEstoqueMin;
    }
}