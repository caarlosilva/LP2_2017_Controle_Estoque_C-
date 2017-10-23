namespace ControlX
{
    partial class formFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFornecedores));
            this.btMenu = new System.Windows.Forms.Button();
            this.pnFiltro = new System.Windows.Forms.Panel();
            this.txPesquisar = new System.Windows.Forms.TextBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.pnBtns = new System.Windows.Forms.Panel();
            this.btDel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btView = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.gbFornecedores = new System.Windows.Forms.GroupBox();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidadeEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnFiltro.SuspendLayout();
            this.pnBtns.SuspendLayout();
            this.gbFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btMenu
            // 
            this.btMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btMenu.Location = new System.Drawing.Point(5, 3);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(70, 23);
            this.btMenu.TabIndex = 4;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // pnFiltro
            // 
            this.pnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFiltro.Controls.Add(this.txPesquisar);
            this.pnFiltro.Controls.Add(this.lbFiltro);
            this.pnFiltro.Location = new System.Drawing.Point(12, 12);
            this.pnFiltro.Name = "pnFiltro";
            this.pnFiltro.Size = new System.Drawing.Size(666, 30);
            this.pnFiltro.TabIndex = 1;
            this.pnFiltro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnFiltro_Paint);
            // 
            // txPesquisar
            // 
            this.txPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txPesquisar.Location = new System.Drawing.Point(47, 6);
            this.txPesquisar.Name = "txPesquisar";
            this.txPesquisar.Size = new System.Drawing.Size(613, 21);
            this.txPesquisar.TabIndex = 0;
            this.txPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txPesquisar_KeyUp);
            // 
            // lbFiltro
            // 
            this.lbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(9, 9);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(40, 13);
            this.lbFiltro.TabIndex = 0;
            this.lbFiltro.Text = "Filtro:";
            // 
            // pnBtns
            // 
            this.pnBtns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBtns.Controls.Add(this.btDel);
            this.pnBtns.Controls.Add(this.btEdit);
            this.pnBtns.Controls.Add(this.btView);
            this.pnBtns.Controls.Add(this.btAdd);
            this.pnBtns.Location = new System.Drawing.Point(338, 388);
            this.pnBtns.Name = "pnBtns";
            this.pnBtns.Size = new System.Drawing.Size(340, 29);
            this.pnBtns.TabIndex = 3;
            this.pnBtns.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBtns_Paint);
            // 
            // btDel
            // 
            this.btDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDel.Location = new System.Drawing.Point(18, 3);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 3;
            this.btDel.Text = "Remover";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btEdit
            // 
            this.btEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEdit.Location = new System.Drawing.Point(180, 3);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Editar";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btView
            // 
            this.btView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btView.Location = new System.Drawing.Point(99, 3);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(75, 23);
            this.btView.TabIndex = 2;
            this.btView.Text = "Visualizar";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(261, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // gbFornecedores
            // 
            this.gbFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFornecedores.Controls.Add(this.dgvFornecedor);
            this.gbFornecedores.Location = new System.Drawing.Point(12, 48);
            this.gbFornecedores.Name = "gbFornecedores";
            this.gbFornecedores.Size = new System.Drawing.Size(666, 334);
            this.gbFornecedores.TabIndex = 4;
            this.gbFornecedores.TabStop = false;
            this.gbFornecedores.Text = "Fornecedores";
            this.gbFornecedores.Enter += new System.EventHandler(this.gbFornecedores_Enter);
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colCNPJ,
            this.colCidadeEstado});
            this.dgvFornecedor.Location = new System.Drawing.Point(6, 19);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.RowHeadersVisible = false;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(654, 309);
            this.dgvFornecedor.TabIndex = 0;
            this.dgvFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellContentClick);
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMenu.Controls.Add(this.btMenu);
            this.pnMenu.Location = new System.Drawing.Point(12, 388);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(98, 29);
            this.pnMenu.TabIndex = 5;
            this.pnMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMenu_Paint);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID.FillWeight = 15F;
            this.colID.HeaderText = "Id";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.FillWeight = 90F;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colCNPJ
            // 
            this.colCNPJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "00\\.000\\.000/0000-00";
            dataGridViewCellStyle1.NullValue = null;
            this.colCNPJ.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCNPJ.FillWeight = 50F;
            this.colCNPJ.HeaderText = "CNPJ";
            this.colCNPJ.Name = "colCNPJ";
            this.colCNPJ.ReadOnly = true;
            // 
            // colCidadeEstado
            // 
            this.colCidadeEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCidadeEstado.FillWeight = 70F;
            this.colCidadeEstado.HeaderText = "Localização";
            this.colCidadeEstado.Name = "colCidadeEstado";
            this.colCidadeEstado.ReadOnly = true;
            // 
            // formFornecedores
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btMenu;
            this.ClientSize = new System.Drawing.Size(690, 429);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.gbFornecedores);
            this.Controls.Add(this.pnBtns);
            this.Controls.Add(this.pnFiltro);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formFornecedores";
            this.Text = "ControlX - Fornecedores";
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            this.pnBtns.ResumeLayout(false);
            this.gbFornecedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Panel pnFiltro;
        private System.Windows.Forms.Panel pnBtns;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.TextBox txPesquisar;
        private System.Windows.Forms.GroupBox gbFornecedores;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.Panel pnMenu;
        protected internal System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidadeEstado;
    }
}