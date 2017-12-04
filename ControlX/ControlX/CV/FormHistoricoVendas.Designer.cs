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
            this.gbEstoque = new System.Windows.Forms.GroupBox();
            this.dgvHistVendas = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalhesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnPesquisar = new System.Windows.Forms.Panel();
            this.txPesquisar = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.pnFiltros = new System.Windows.Forms.Panel();
            this.rbDataVenda = new System.Windows.Forms.RadioButton();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.pnData = new System.Windows.Forms.Panel();
            this.lbFim = new System.Windows.Forms.Label();
            this.lbInicio = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.gbEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistVendas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnPesquisar.SuspendLayout();
            this.pnFiltros.SuspendLayout();
            this.pnData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEstoque
            // 
            this.gbEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEstoque.Controls.Add(this.dgvHistVendas);
            this.gbEstoque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstoque.Location = new System.Drawing.Point(0, 89);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Size = new System.Drawing.Size(801, 381);
            this.gbEstoque.TabIndex = 15;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Vendas";
            // 
            // dgvHistVendas
            // 
            this.dgvHistVendas.AllowUserToAddRows = false;
            this.dgvHistVendas.AllowUserToDeleteRows = false;
            this.dgvHistVendas.AllowUserToResizeRows = false;
            this.dgvHistVendas.BackgroundColor = System.Drawing.Color.White;
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
            this.dgvHistVendas.Size = new System.Drawing.Size(795, 361);
            this.dgvHistVendas.TabIndex = 3;
            this.dgvHistVendas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHistVendas_CellMouseDoubleClick);
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
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.detalhesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(801, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Image = global::ControlX.Properties.Resources.left_arrow;
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // detalhesToolStripMenuItem
            // 
            this.detalhesToolStripMenuItem.Image = global::ControlX.Properties.Resources.details_icon;
            this.detalhesToolStripMenuItem.Name = "detalhesToolStripMenuItem";
            this.detalhesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.detalhesToolStripMenuItem.Text = "Detalhes";
            this.detalhesToolStripMenuItem.Click += new System.EventHandler(this.btView_Click);
            // 
            // pnPesquisar
            // 
            this.pnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPesquisar.Controls.Add(this.txPesquisar);
            this.pnPesquisar.Controls.Add(this.lbId);
            this.pnPesquisar.Location = new System.Drawing.Point(0, 31);
            this.pnPesquisar.Name = "pnPesquisar";
            this.pnPesquisar.Size = new System.Drawing.Size(476, 52);
            this.pnPesquisar.TabIndex = 20;
            // 
            // txPesquisar
            // 
            this.txPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txPesquisar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txPesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPesquisar.Location = new System.Drawing.Point(40, 14);
            this.txPesquisar.Name = "txPesquisar";
            this.txPesquisar.Size = new System.Drawing.Size(419, 21);
            this.txPesquisar.TabIndex = 1;
            this.txPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPesquisar_KeyPress);
            this.txPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txPesquisar_KeyUp);
            // 
            // lbId
            // 
            this.lbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(8, 17);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(24, 13);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "Id:";
            // 
            // pnFiltros
            // 
            this.pnFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFiltros.Controls.Add(this.rbDataVenda);
            this.pnFiltros.Controls.Add(this.rbId);
            this.pnFiltros.Location = new System.Drawing.Point(652, 31);
            this.pnFiltros.Name = "pnFiltros";
            this.pnFiltros.Size = new System.Drawing.Size(137, 52);
            this.pnFiltros.TabIndex = 21;
            // 
            // rbDataVenda
            // 
            this.rbDataVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDataVenda.AutoSize = true;
            this.rbDataVenda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDataVenda.Location = new System.Drawing.Point(16, 31);
            this.rbDataVenda.Name = "rbDataVenda";
            this.rbDataVenda.Size = new System.Drawing.Size(92, 17);
            this.rbDataVenda.TabIndex = 10;
            this.rbDataVenda.Text = "Data Venda";
            this.rbDataVenda.UseVisualStyleBackColor = true;
            // 
            // rbId
            // 
            this.rbId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbId.AutoSize = true;
            this.rbId.Checked = true;
            this.rbId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbId.Location = new System.Drawing.Point(16, 6);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(37, 17);
            this.rbId.TabIndex = 1;
            this.rbId.TabStop = true;
            this.rbId.Text = "Id";
            this.rbId.UseVisualStyleBackColor = true;
            this.rbId.CheckedChanged += new System.EventHandler(this.rbId_CheckedChanged);
            // 
            // pnData
            // 
            this.pnData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnData.Controls.Add(this.lbFim);
            this.pnData.Controls.Add(this.lbInicio);
            this.pnData.Controls.Add(this.dtFim);
            this.pnData.Controls.Add(this.dtInicio);
            this.pnData.Location = new System.Drawing.Point(482, 31);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(164, 52);
            this.pnData.TabIndex = 5;
            // 
            // lbFim
            // 
            this.lbFim.AutoSize = true;
            this.lbFim.Location = new System.Drawing.Point(15, 31);
            this.lbFim.Name = "lbFim";
            this.lbFim.Size = new System.Drawing.Size(31, 13);
            this.lbFim.TabIndex = 14;
            this.lbFim.Text = "Até:";
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Location = new System.Drawing.Point(15, 6);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(28, 13);
            this.lbInicio.TabIndex = 13;
            this.lbInicio.Text = "De:";
            // 
            // dtFim
            // 
            this.dtFim.CustomFormat = "dd/MM/yyyy";
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFim.Location = new System.Drawing.Point(52, 27);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(99, 21);
            this.dtFim.TabIndex = 12;
            this.dtFim.Value = new System.DateTime(2017, 12, 4, 0, 0, 0, 0);
            this.dtFim.ValueChanged += new System.EventHandler(this.dtInicio_ValueChanged);
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/MM/yyyy";
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(52, 3);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(99, 21);
            this.dtInicio.TabIndex = 11;
            this.dtInicio.Value = new System.DateTime(2017, 12, 4, 0, 0, 0, 0);
            this.dtInicio.ValueChanged += new System.EventHandler(this.dtInicio_ValueChanged);
            // 
            // FormHistoricoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 467);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.pnPesquisar);
            this.Controls.Add(this.pnFiltros);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbEstoque);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHistoricoVendas";
            this.Text = "ControlX - Histórico de Vendas";
            this.gbEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistVendas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnPesquisar.ResumeLayout(false);
            this.pnPesquisar.PerformLayout();
            this.pnFiltros.ResumeLayout(false);
            this.pnFiltros.PerformLayout();
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbEstoque;
        private System.Windows.Forms.DataGridView dgvHistVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalhesToolStripMenuItem;
        private System.Windows.Forms.Panel pnPesquisar;
        private System.Windows.Forms.TextBox txPesquisar;
        private System.Windows.Forms.Label lbId;
        public System.Windows.Forms.Panel pnFiltros;
        private System.Windows.Forms.RadioButton rbDataVenda;
        private System.Windows.Forms.RadioButton rbId;
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.Label lbFim;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
    }
}