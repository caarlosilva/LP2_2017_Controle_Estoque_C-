namespace ControlX
{
    partial class FormCompras
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvUltimasCompras = new System.Windows.Forms.DataGridView();
            this.DataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbComprasFinalizadas = new System.Windows.Forms.GroupBox();
            this.pnAguardando = new System.Windows.Forms.Panel();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.dgvComprasAguardando = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAgendadas = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimasCompras)).BeginInit();
            this.gbComprasFinalizadas.SuspendLayout();
            this.pnAguardando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasAguardando)).BeginInit();
            this.gbAgendadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.novaCompraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Image = global::ControlX.Properties.Resources.left_arrow;
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // novaCompraToolStripMenuItem
            // 
            this.novaCompraToolStripMenuItem.Image = global::ControlX.Properties.Resources.cart_icon;
            this.novaCompraToolStripMenuItem.Name = "novaCompraToolStripMenuItem";
            this.novaCompraToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.novaCompraToolStripMenuItem.Text = "Agendar Compra";
            this.novaCompraToolStripMenuItem.Click += new System.EventHandler(this.novaCompraToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvUltimasCompras
            // 
            this.dgvUltimasCompras.AllowUserToAddRows = false;
            this.dgvUltimasCompras.AllowUserToDeleteRows = false;
            this.dgvUltimasCompras.AllowUserToResizeRows = false;
            this.dgvUltimasCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUltimasCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvUltimasCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUltimasCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DataCompra,
            this.DataFinal});
            this.dgvUltimasCompras.Location = new System.Drawing.Point(3, 17);
            this.dgvUltimasCompras.Name = "dgvUltimasCompras";
            this.dgvUltimasCompras.ReadOnly = true;
            this.dgvUltimasCompras.RowHeadersVisible = false;
            this.dgvUltimasCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUltimasCompras.Size = new System.Drawing.Size(354, 380);
            this.dgvUltimasCompras.TabIndex = 0;
            // 
            // DataFinal
            // 
            this.DataFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataFinal.FillWeight = 40F;
            this.DataFinal.HeaderText = "Data da Entrega";
            this.DataFinal.Name = "DataFinal";
            this.DataFinal.ReadOnly = true;
            // 
            // DataCompra
            // 
            this.DataCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataCompra.FillWeight = 40F;
            this.DataCompra.HeaderText = "Data da Compra";
            this.DataCompra.Name = "DataCompra";
            this.DataCompra.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.FillWeight = 20F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // gbComprasFinalizadas
            // 
            this.gbComprasFinalizadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbComprasFinalizadas.Controls.Add(this.dgvUltimasCompras);
            this.gbComprasFinalizadas.Location = new System.Drawing.Point(4, 31);
            this.gbComprasFinalizadas.Name = "gbComprasFinalizadas";
            this.gbComprasFinalizadas.Size = new System.Drawing.Size(360, 400);
            this.gbComprasFinalizadas.TabIndex = 0;
            this.gbComprasFinalizadas.TabStop = false;
            this.gbComprasFinalizadas.Text = "Ultimas compras finalizadas";
            // 
            // pnAguardando
            // 
            this.pnAguardando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnAguardando.Controls.Add(this.btFinalizar);
            this.pnAguardando.Location = new System.Drawing.Point(6, 368);
            this.pnAguardando.Name = "pnAguardando";
            this.pnAguardando.Size = new System.Drawing.Size(351, 26);
            this.pnAguardando.TabIndex = 4;
            // 
            // btFinalizar
            // 
            this.btFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFinalizar.Location = new System.Drawing.Point(273, 2);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btFinalizar.TabIndex = 0;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // dgvComprasAguardando
            // 
            this.dgvComprasAguardando.AllowUserToAddRows = false;
            this.dgvComprasAguardando.AllowUserToDeleteRows = false;
            this.dgvComprasAguardando.AllowUserToResizeRows = false;
            this.dgvComprasAguardando.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComprasAguardando.BackgroundColor = System.Drawing.Color.White;
            this.dgvComprasAguardando.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasAguardando.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.Usuario,
            this.colDataCompra,
            this.colDataEntrega,
            this.Total,
            this.Status});
            this.dgvComprasAguardando.GridColor = System.Drawing.Color.Black;
            this.dgvComprasAguardando.Location = new System.Drawing.Point(3, 17);
            this.dgvComprasAguardando.Name = "dgvComprasAguardando";
            this.dgvComprasAguardando.ReadOnly = true;
            this.dgvComprasAguardando.RowHeadersVisible = false;
            this.dgvComprasAguardando.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComprasAguardando.Size = new System.Drawing.Size(354, 347);
            this.dgvComprasAguardando.TabIndex = 0;
            this.dgvComprasAguardando.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvComprasAguardando_CellMouseDoubleClick);
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Visible = false;
            // 
            // colDataEntrega
            // 
            this.colDataEntrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colDataEntrega.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDataEntrega.FillWeight = 40F;
            this.colDataEntrega.HeaderText = "Data Prevista";
            this.colDataEntrega.Name = "colDataEntrega";
            this.colDataEntrega.ReadOnly = true;
            this.colDataEntrega.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colDataCompra
            // 
            this.colDataCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.colDataCompra.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDataCompra.FillWeight = 40F;
            this.colDataCompra.HeaderText = "Data da Compra";
            this.colDataCompra.Name = "colDataCompra";
            this.colDataCompra.ReadOnly = true;
            this.colDataCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Visible = false;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID.FillWeight = 20F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // gbAgendadas
            // 
            this.gbAgendadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgendadas.Controls.Add(this.dgvComprasAguardando);
            this.gbAgendadas.Controls.Add(this.pnAguardando);
            this.gbAgendadas.Location = new System.Drawing.Point(370, 31);
            this.gbAgendadas.Name = "gbAgendadas";
            this.gbAgendadas.Size = new System.Drawing.Size(360, 400);
            this.gbAgendadas.TabIndex = 1;
            this.gbAgendadas.TabStop = false;
            this.gbAgendadas.Text = "Compras aguardando recebimento";
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 437);
            this.Controls.Add(this.gbAgendadas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbComprasFinalizadas);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCompras";
            this.Text = "ControlX - Compras";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimasCompras)).EndInit();
            this.gbComprasFinalizadas.ResumeLayout(false);
            this.pnAguardando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasAguardando)).EndInit();
            this.gbAgendadas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvUltimasCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFinal;
        private System.Windows.Forms.GroupBox gbComprasFinalizadas;
        private System.Windows.Forms.Panel pnAguardando;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.DataGridView dgvComprasAguardando;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.GroupBox gbAgendadas;
    }
}