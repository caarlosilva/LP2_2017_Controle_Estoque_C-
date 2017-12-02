namespace ControlX
{
    partial class formHistoricoCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHistoricoCompras));
            this.gbEstoque = new System.Windows.Forms.GroupBox();
            this.dgvHistCompras = new System.Windows.Forms.DataGridView();
            this.rbDataEntrega = new System.Windows.Forms.RadioButton();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.pnFiltros = new System.Windows.Forms.Panel();
            this.pnId = new System.Windows.Forms.Panel();
            this.txPesquisar = new System.Windows.Forms.TextBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.pnData = new System.Windows.Forms.Panel();
            this.lbFim = new System.Windows.Forms.Label();
            this.lbInicio = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalhesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistCompras)).BeginInit();
            this.pnFiltros.SuspendLayout();
            this.pnId.SuspendLayout();
            this.pnData.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEstoque
            // 
            this.gbEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEstoque.Controls.Add(this.dgvHistCompras);
            this.gbEstoque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstoque.Location = new System.Drawing.Point(0, 86);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Size = new System.Drawing.Size(801, 380);
            this.gbEstoque.TabIndex = 11;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Compras";
            // 
            // dgvHistCompras
            // 
            this.dgvHistCompras.AllowUserToAddRows = false;
            this.dgvHistCompras.AllowUserToDeleteRows = false;
            this.dgvHistCompras.AllowUserToResizeRows = false;
            this.dgvHistCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colUser,
            this.colDataCompra,
            this.colDataEntrega,
            this.colTotal,
            this.colStatus,
            this.DataFinal});
            this.dgvHistCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistCompras.Location = new System.Drawing.Point(3, 17);
            this.dgvHistCompras.Name = "dgvHistCompras";
            this.dgvHistCompras.ReadOnly = true;
            this.dgvHistCompras.RowHeadersVisible = false;
            this.dgvHistCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistCompras.Size = new System.Drawing.Size(795, 360);
            this.dgvHistCompras.TabIndex = 3;
            this.dgvHistCompras.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHistCompras_CellMouseDoubleClick);
            // 
            // rbDataEntrega
            // 
            this.rbDataEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDataEntrega.AutoSize = true;
            this.rbDataEntrega.Checked = true;
            this.rbDataEntrega.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDataEntrega.Location = new System.Drawing.Point(15, 6);
            this.rbDataEntrega.Name = "rbDataEntrega";
            this.rbDataEntrega.Size = new System.Drawing.Size(100, 17);
            this.rbDataEntrega.TabIndex = 10;
            this.rbDataEntrega.TabStop = true;
            this.rbDataEntrega.Text = "Data Entrega";
            this.rbDataEntrega.UseVisualStyleBackColor = true;
            this.rbDataEntrega.CheckedChanged += new System.EventHandler(this.rbDataEntrega_CheckedChanged);
            // 
            // rbId
            // 
            this.rbId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbId.AutoSize = true;
            this.rbId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbId.Location = new System.Drawing.Point(15, 29);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(37, 17);
            this.rbId.TabIndex = 1;
            this.rbId.Text = "Id";
            this.rbId.UseVisualStyleBackColor = true;
            // 
            // pnFiltros
            // 
            this.pnFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFiltros.Controls.Add(this.rbDataEntrega);
            this.pnFiltros.Controls.Add(this.rbId);
            this.pnFiltros.Location = new System.Drawing.Point(647, 31);
            this.pnFiltros.Name = "pnFiltros";
            this.pnFiltros.Size = new System.Drawing.Size(140, 52);
            this.pnFiltros.TabIndex = 10;
            // 
            // pnId
            // 
            this.pnId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnId.Controls.Add(this.txPesquisar);
            this.pnId.Controls.Add(this.lbFiltro);
            this.pnId.Location = new System.Drawing.Point(3, 31);
            this.pnId.Name = "pnId";
            this.pnId.Size = new System.Drawing.Size(446, 52);
            this.pnId.TabIndex = 4;
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
            this.txPesquisar.Size = new System.Drawing.Size(389, 21);
            this.txPesquisar.TabIndex = 1;
            this.txPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPesquisar_KeyPress);
            // 
            // lbFiltro
            // 
            this.lbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(8, 17);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(24, 13);
            this.lbFiltro.TabIndex = 2;
            this.lbFiltro.Text = "Id:";
            // 
            // pnData
            // 
            this.pnData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnData.Controls.Add(this.lbFim);
            this.pnData.Controls.Add(this.lbInicio);
            this.pnData.Controls.Add(this.dtFim);
            this.pnData.Controls.Add(this.dtInicio);
            this.pnData.Location = new System.Drawing.Point(456, 31);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(191, 52);
            this.pnData.TabIndex = 4;
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
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(52, 27);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(125, 21);
            this.dtFim.TabIndex = 12;
            this.dtFim.Value = new System.DateTime(2017, 11, 9, 0, 0, 0, 0);
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(52, 3);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(125, 21);
            this.dtInicio.TabIndex = 11;
            this.dtInicio.Value = new System.DateTime(2017, 11, 9, 19, 40, 47, 0);
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
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Image = global::ControlX.Properties.Resources.left_arrow;
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // detalhesToolStripMenuItem
            // 
            this.detalhesToolStripMenuItem.Image = global::ControlX.Properties.Resources.details_icon;
            this.detalhesToolStripMenuItem.Name = "detalhesToolStripMenuItem";
            this.detalhesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.detalhesToolStripMenuItem.Text = "Detalhes";
            this.detalhesToolStripMenuItem.Click += new System.EventHandler(this.btView_Click);
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
            // colUser
            // 
            this.colUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUser.FillWeight = 40F;
            this.colUser.HeaderText = "Usuario";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            // 
            // colDataCompra
            // 
            this.colDataCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.colDataCompra.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDataCompra.FillWeight = 30F;
            this.colDataCompra.HeaderText = "Data da Compra";
            this.colDataCompra.Name = "colDataCompra";
            this.colDataCompra.ReadOnly = true;
            // 
            // colDataEntrega
            // 
            this.colDataEntrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colDataEntrega.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDataEntrega.FillWeight = 30F;
            this.colDataEntrega.HeaderText = "Data de Entrega";
            this.colDataEntrega.Name = "colDataEntrega";
            this.colDataEntrega.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTotal.FillWeight = 25F;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.NullValue = null;
            this.colStatus.DefaultCellStyle = dataGridViewCellStyle4;
            this.colStatus.FillWeight = 15F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // DataFinal
            // 
            this.DataFinal.HeaderText = "DataFinal";
            this.DataFinal.Name = "DataFinal";
            this.DataFinal.ReadOnly = true;
            this.DataFinal.Visible = false;
            // 
            // formHistoricoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 467);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.gbEstoque);
            this.Controls.Add(this.pnId);
            this.Controls.Add(this.pnFiltros);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formHistoricoCompras";
            this.Text = "ControlX - Histórico de Compras";
            this.gbEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistCompras)).EndInit();
            this.pnFiltros.ResumeLayout(false);
            this.pnFiltros.PerformLayout();
            this.pnId.ResumeLayout(false);
            this.pnId.PerformLayout();
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbEstoque;
        private System.Windows.Forms.DataGridView dgvHistCompras;
        private System.Windows.Forms.RadioButton rbDataEntrega;
        private System.Windows.Forms.RadioButton rbId;
        public System.Windows.Forms.Panel pnFiltros;
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.Panel pnId;
        private System.Windows.Forms.TextBox txPesquisar;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Label lbFim;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalhesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFinal;
    }
}