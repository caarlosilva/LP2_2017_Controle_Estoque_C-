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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            this.gbAgendadas = new System.Windows.Forms.GroupBox();
            this.dgvComprasAguardando = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbComprasFinalizadas = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnAguardando = new System.Windows.Forms.Panel();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.tx = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbAgendadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasAguardando)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbComprasFinalizadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnAguardando.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAgendadas
            // 
            this.gbAgendadas.Controls.Add(this.dgvComprasAguardando);
            this.gbAgendadas.Location = new System.Drawing.Point(370, 31);
            this.gbAgendadas.Name = "gbAgendadas";
            this.gbAgendadas.Size = new System.Drawing.Size(360, 369);
            this.gbAgendadas.TabIndex = 0;
            this.gbAgendadas.TabStop = false;
            this.gbAgendadas.Text = "Compras aguardando recebimento";
            // 
            // dgvComprasAguardando
            // 
            this.dgvComprasAguardando.AllowUserToAddRows = false;
            this.dgvComprasAguardando.AllowUserToDeleteRows = false;
            this.dgvComprasAguardando.AllowUserToResizeRows = false;
            this.dgvComprasAguardando.BackgroundColor = System.Drawing.Color.White;
            this.dgvComprasAguardando.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasAguardando.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDataCompra,
            this.colDataEntrega});
            this.dgvComprasAguardando.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComprasAguardando.GridColor = System.Drawing.Color.Black;
            this.dgvComprasAguardando.Location = new System.Drawing.Point(3, 17);
            this.dgvComprasAguardando.Name = "dgvComprasAguardando";
            this.dgvComprasAguardando.ReadOnly = true;
            this.dgvComprasAguardando.RowHeadersVisible = false;
            this.dgvComprasAguardando.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComprasAguardando.Size = new System.Drawing.Size(354, 349);
            this.dgvComprasAguardando.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID.FillWeight = 20F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
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
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.novaCompraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Image = global::ControlX.Properties.Resources.left_arrow;
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
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
            // gbComprasFinalizadas
            // 
            this.gbComprasFinalizadas.Controls.Add(this.dataGridView1);
            this.gbComprasFinalizadas.Location = new System.Drawing.Point(4, 31);
            this.gbComprasFinalizadas.Name = "gbComprasFinalizadas";
            this.gbComprasFinalizadas.Size = new System.Drawing.Size(363, 399);
            this.gbComprasFinalizadas.TabIndex = 3;
            this.gbComprasFinalizadas.TabStop = false;
            this.gbComprasFinalizadas.Text = "Ultimas compras finalizadas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(357, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnAguardando
            // 
            this.pnAguardando.Controls.Add(this.btFinalizar);
            this.pnAguardando.Controls.Add(this.tx);
            this.pnAguardando.Location = new System.Drawing.Point(373, 404);
            this.pnAguardando.Name = "pnAguardando";
            this.pnAguardando.Size = new System.Drawing.Size(357, 26);
            this.pnAguardando.TabIndex = 4;
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(278, 1);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btFinalizar.TabIndex = 0;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // tx
            // 
            this.tx.Location = new System.Drawing.Point(3, 3);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(100, 21);
            this.tx.TabIndex = 5;
            this.tx.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 436);
            this.Controls.Add(this.pnAguardando);
            this.Controls.Add(this.gbComprasFinalizadas);
            this.Controls.Add(this.gbAgendadas);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCompras";
            this.Text = "ControlX - Compras";
            this.gbAgendadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasAguardando)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbComprasFinalizadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnAguardando.ResumeLayout(false);
            this.pnAguardando.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAgendadas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaCompraToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvComprasAguardando;
        private System.Windows.Forms.GroupBox gbComprasFinalizadas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnAguardando;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataEntrega;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        public System.Windows.Forms.TextBox tx;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}