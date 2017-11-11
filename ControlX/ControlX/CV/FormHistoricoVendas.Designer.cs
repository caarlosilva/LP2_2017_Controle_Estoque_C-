namespace ControlX
{
    partial class FormHistoricoVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricoVendas));
            this.lbFim = new System.Windows.Forms.Label();
            this.lbInicio = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.pnData = new System.Windows.Forms.Panel();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.txPesquisar = new System.Windows.Forms.TextBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.pnId = new System.Windows.Forms.Panel();
            this.pnPesquisa = new System.Windows.Forms.Panel();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.btView = new System.Windows.Forms.Button();
            this.gbEstoque = new System.Windows.Forms.GroupBox();
            this.dgvHistVendas = new System.Windows.Forms.DataGridView();
            this.btMenu = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnData.SuspendLayout();
            this.pnId.SuspendLayout();
            this.pnPesquisa.SuspendLayout();
            this.pnButtons.SuspendLayout();
            this.gbEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistVendas)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFim
            // 
            this.lbFim.AutoSize = true;
            this.lbFim.Location = new System.Drawing.Point(13, 32);
            this.lbFim.Name = "lbFim";
            this.lbFim.Size = new System.Drawing.Size(26, 13);
            this.lbFim.TabIndex = 14;
            this.lbFim.Text = "Até:";
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Location = new System.Drawing.Point(13, 6);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(24, 13);
            this.lbInicio.TabIndex = 13;
            this.lbInicio.Text = "De:";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(45, 3);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(108, 20);
            this.dtInicio.TabIndex = 11;
            this.dtInicio.Value = new System.DateTime(2017, 11, 9, 19, 40, 47, 0);
            // 
            // pnData
            // 
            this.pnData.Controls.Add(this.lbFim);
            this.pnData.Controls.Add(this.lbInicio);
            this.pnData.Controls.Add(this.dtFim);
            this.pnData.Controls.Add(this.dtInicio);
            this.pnData.Location = new System.Drawing.Point(408, 1);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(188, 50);
            this.pnData.TabIndex = 4;
            this.pnData.Visible = false;
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(45, 28);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(108, 20);
            this.dtFim.TabIndex = 12;
            this.dtFim.Value = new System.DateTime(2017, 11, 9, 19, 40, 43, 0);
            // 
            // txPesquisar
            // 
            this.txPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txPesquisar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txPesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPesquisar.Location = new System.Drawing.Point(51, 14);
            this.txPesquisar.Name = "txPesquisar";
            this.txPesquisar.Size = new System.Drawing.Size(94, 21);
            this.txPesquisar.TabIndex = 1;
            // 
            // lbFiltro
            // 
            this.lbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(21, 17);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(24, 13);
            this.lbFiltro.TabIndex = 2;
            this.lbFiltro.Text = "Id:";
            // 
            // pnId
            // 
            this.pnId.Controls.Add(this.txPesquisar);
            this.pnId.Controls.Add(this.lbFiltro);
            this.pnId.Location = new System.Drawing.Point(235, 1);
            this.pnId.Name = "pnId";
            this.pnId.Size = new System.Drawing.Size(167, 52);
            this.pnId.TabIndex = 4;
            this.pnId.Visible = false;
            // 
            // pnPesquisa
            // 
            this.pnPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPesquisa.Controls.Add(this.pnId);
            this.pnPesquisa.Controls.Add(this.pnData);
            this.pnPesquisa.Controls.Add(this.rbNome);
            this.pnPesquisa.Controls.Add(this.rbId);
            this.pnPesquisa.Location = new System.Drawing.Point(12, 7);
            this.pnPesquisa.Name = "pnPesquisa";
            this.pnPesquisa.Size = new System.Drawing.Size(666, 52);
            this.pnPesquisa.TabIndex = 14;
            // 
            // rbNome
            // 
            this.rbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.Location = new System.Drawing.Point(602, 11);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(52, 17);
            this.rbNome.TabIndex = 10;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Data";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbId
            // 
            this.rbId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbId.AutoSize = true;
            this.rbId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbId.Location = new System.Drawing.Point(602, 29);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(37, 17);
            this.rbId.TabIndex = 1;
            this.rbId.Text = "Id";
            this.rbId.UseVisualStyleBackColor = true;
            // 
            // pnButtons
            // 
            this.pnButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnButtons.Controls.Add(this.btView);
            this.pnButtons.Location = new System.Drawing.Point(596, 393);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(82, 29);
            this.pnButtons.TabIndex = 16;
            // 
            // btView
            // 
            this.btView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btView.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btView.Location = new System.Drawing.Point(4, 3);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(75, 23);
            this.btView.TabIndex = 2;
            this.btView.Text = "Visualizar";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // gbEstoque
            // 
            this.gbEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEstoque.Controls.Add(this.dgvHistVendas);
            this.gbEstoque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstoque.Location = new System.Drawing.Point(12, 65);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Size = new System.Drawing.Size(666, 322);
            this.gbEstoque.TabIndex = 15;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Vendas";
            // 
            // dgvHistVendas
            // 
            this.dgvHistVendas.AllowUserToAddRows = false;
            this.dgvHistVendas.AllowUserToDeleteRows = false;
            this.dgvHistVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colUser,
            this.colTotal,
            this.colData});
            this.dgvHistVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistVendas.Location = new System.Drawing.Point(3, 17);
            this.dgvHistVendas.Name = "dgvHistVendas";
            this.dgvHistVendas.ReadOnly = true;
            this.dgvHistVendas.RowHeadersVisible = false;
            this.dgvHistVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistVendas.Size = new System.Drawing.Size(660, 302);
            this.dgvHistVendas.TabIndex = 3;
            // 
            // btMenu
            // 
            this.btMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btMenu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.Location = new System.Drawing.Point(6, 5);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(70, 23);
            this.btMenu.TabIndex = 4;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMenu.Controls.Add(this.btMenu);
            this.pnMenu.Location = new System.Drawing.Point(12, 393);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(83, 29);
            this.pnMenu.TabIndex = 17;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.FillWeight = 10F;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.ToolTipText = "Numero de identificação gerado no cadastro";
            // 
            // colUser
            // 
            this.colUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUser.FillWeight = 70F;
            this.colUser.HeaderText = "Usuario";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.colTotal.FillWeight = 25F;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colData
            // 
            this.colData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colData.FillWeight = 30F;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // FormHistoricoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 429);
            this.Controls.Add(this.pnPesquisa);
            this.Controls.Add(this.pnButtons);
            this.Controls.Add(this.gbEstoque);
            this.Controls.Add(this.pnMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHistoricoVendas";
            this.Text = "ControlX - Histórico de Vendas";
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            this.pnId.ResumeLayout(false);
            this.pnId.PerformLayout();
            this.pnPesquisa.ResumeLayout(false);
            this.pnPesquisa.PerformLayout();
            this.pnButtons.ResumeLayout(false);
            this.gbEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistVendas)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFim;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.TextBox txPesquisar;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Panel pnId;
        public System.Windows.Forms.Panel pnPesquisa;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbId;
        public System.Windows.Forms.Panel pnButtons;
        public System.Windows.Forms.Button btView;
        private System.Windows.Forms.GroupBox gbEstoque;
        private System.Windows.Forms.DataGridView dgvHistVendas;
        public System.Windows.Forms.Button btMenu;
        public System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
    }
}