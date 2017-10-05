namespace ControlX
{
    partial class formEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEstoque));
            this.lbFiltro = new System.Windows.Forms.Label();
            this.txPesquisar = new System.Windows.Forms.TextBox();
            this.pnPesquisa = new System.Windows.Forms.Panel();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEstoque = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.btView = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.gbEstoque.SuspendLayout();
            this.pnButtons.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFiltro
            // 
            this.lbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(9, 9);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(40, 13);
            this.lbFiltro.TabIndex = 0;
            this.lbFiltro.Text = "Filtro:";
            // 
            // txPesquisar
            // 
            this.txPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txPesquisar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txPesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPesquisar.Location = new System.Drawing.Point(47, 6);
            this.txPesquisar.Name = "txPesquisar";
            this.txPesquisar.Size = new System.Drawing.Size(535, 21);
            this.txPesquisar.TabIndex = 0;
            this.txPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPesquisar_KeyPress);
            this.txPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txPesquisar_KeyUp);
            // 
            // pnPesquisa
            // 
            this.pnPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPesquisa.Controls.Add(this.rbNome);
            this.pnPesquisa.Controls.Add(this.rbId);
            this.pnPesquisa.Controls.Add(this.txPesquisar);
            this.pnPesquisa.Controls.Add(this.lbFiltro);
            this.pnPesquisa.Location = new System.Drawing.Point(12, 2);
            this.pnPesquisa.Name = "pnPesquisa";
            this.pnPesquisa.Size = new System.Drawing.Size(666, 40);
            this.pnPesquisa.TabIndex = 2;
            // 
            // rbNome
            // 
            this.rbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.Location = new System.Drawing.Point(602, 3);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(58, 17);
            this.rbNome.TabIndex = 10;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbId
            // 
            this.rbId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbId.AutoSize = true;
            this.rbId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbId.Location = new System.Drawing.Point(602, 20);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(37, 17);
            this.rbId.TabIndex = 1;
            this.rbId.Text = "Id";
            this.rbId.UseVisualStyleBackColor = true;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colPreco,
            this.colQtd});
            this.dgvEstoque.Location = new System.Drawing.Point(6, 19);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.Size = new System.Drawing.Size(654, 309);
            this.dgvEstoque.TabIndex = 3;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.FillWeight = 15F;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.ToolTipText = "Numero de identificação gerado no cadastro";
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.FillWeight = 120F;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colPreco
            // 
            this.colPreco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.colPreco.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPreco.FillWeight = 50F;
            this.colPreco.HeaderText = "Preço";
            this.colPreco.Name = "colPreco";
            this.colPreco.ReadOnly = true;
            // 
            // colQtd
            // 
            this.colQtd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.NullValue = null;
            this.colQtd.DefaultCellStyle = dataGridViewCellStyle2;
            this.colQtd.FillWeight = 30F;
            this.colQtd.HeaderText = "Quantidade";
            this.colQtd.Name = "colQtd";
            this.colQtd.ReadOnly = true;
            // 
            // gbEstoque
            // 
            this.gbEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEstoque.Controls.Add(this.dgvEstoque);
            this.gbEstoque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstoque.Location = new System.Drawing.Point(12, 48);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Size = new System.Drawing.Size(666, 334);
            this.gbEstoque.TabIndex = 4;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Estoque";
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(248, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btDel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(5, 3);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 3;
            this.btDel.Text = "Remover";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btEdit
            // 
            this.btEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btEdit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(167, 3);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Editar";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // pnButtons
            // 
            this.pnButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnButtons.Controls.Add(this.btView);
            this.pnButtons.Controls.Add(this.btAdd);
            this.pnButtons.Controls.Add(this.btEdit);
            this.pnButtons.Controls.Add(this.btDel);
            this.pnButtons.Location = new System.Drawing.Point(352, 388);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(326, 29);
            this.pnButtons.TabIndex = 8;
            // 
            // btView
            // 
            this.btView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btView.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btView.Location = new System.Drawing.Point(86, 3);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(75, 23);
            this.btView.TabIndex = 2;
            this.btView.Text = "Visualizar";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // btMenu
            // 
            this.btMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btMenu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.Location = new System.Drawing.Point(6, 3);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(70, 23);
            this.btMenu.TabIndex = 4;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenuPrincipal_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMenu.Controls.Add(this.btMenu);
            this.pnMenu.Location = new System.Drawing.Point(12, 388);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(83, 29);
            this.pnMenu.TabIndex = 9;
            // 
            // formEstoque
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 429);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnButtons);
            this.Controls.Add(this.gbEstoque);
            this.Controls.Add(this.pnPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formEstoque";
            this.Text = "Estoque";
            this.pnPesquisa.ResumeLayout(false);
            this.pnPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.gbEstoque.ResumeLayout(false);
            this.pnButtons.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.TextBox txPesquisar;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.GroupBox gbEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.RadioButton rbId;
        private System.Windows.Forms.RadioButton rbNome;
        public System.Windows.Forms.Button btDel;
        public System.Windows.Forms.Button btEdit;
        public System.Windows.Forms.Button btView;
        public System.Windows.Forms.Button btAdd;
        public System.Windows.Forms.Button btMenu;
        public System.Windows.Forms.Panel pnPesquisa;
        public System.Windows.Forms.Panel pnButtons;
        public System.Windows.Forms.Panel pnMenu;
    }
}

