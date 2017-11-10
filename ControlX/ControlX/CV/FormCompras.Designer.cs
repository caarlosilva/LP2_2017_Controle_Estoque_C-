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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            this.gbAgendadas = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvComprasAguardando = new System.Windows.Forms.DataGridView();
            this.pnAguardando = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAgendadas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasAguardando)).BeginInit();
            this.pnAguardando.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAgendadas
            // 
            this.gbAgendadas.Controls.Add(this.dgvComprasAguardando);
            this.gbAgendadas.Location = new System.Drawing.Point(370, 59);
            this.gbAgendadas.Name = "gbAgendadas";
            this.gbAgendadas.Size = new System.Drawing.Size(360, 335);
            this.gbAgendadas.TabIndex = 0;
            this.gbAgendadas.TabStop = false;
            this.gbAgendadas.Text = "Compras aguardando recebimento";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaCompraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 44);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novaCompraToolStripMenuItem
            // 
            this.novaCompraToolStripMenuItem.Image = global::ControlX.Properties.Resources.newcart;
            this.novaCompraToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.novaCompraToolStripMenuItem.Name = "novaCompraToolStripMenuItem";
            this.novaCompraToolStripMenuItem.Size = new System.Drawing.Size(48, 40);
            this.novaCompraToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.novaCompraToolStripMenuItem.Click += new System.EventHandler(this.novaCompraToolStripMenuItem_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(5, 7);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 2;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 335);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ultimas compras finalizadas";
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
            this.dataGridView1.Size = new System.Drawing.Size(354, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvComprasAguardando
            // 
            this.dgvComprasAguardando.AllowUserToAddRows = false;
            this.dgvComprasAguardando.AllowUserToDeleteRows = false;
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
            this.dgvComprasAguardando.Size = new System.Drawing.Size(354, 315);
            this.dgvComprasAguardando.TabIndex = 0;
            // 
            // pnAguardando
            // 
            this.pnAguardando.Controls.Add(this.btFinalizar);
            this.pnAguardando.Location = new System.Drawing.Point(370, 397);
            this.pnAguardando.Name = "pnAguardando";
            this.pnAguardando.Size = new System.Drawing.Size(360, 33);
            this.pnAguardando.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btVoltar);
            this.panel1.Location = new System.Drawing.Point(7, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 33);
            this.panel1.TabIndex = 5;
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(278, 5);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btFinalizar.TabIndex = 0;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
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
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnAguardando);
            this.Controls.Add(this.groupBox1);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasAguardando)).EndInit();
            this.pnAguardando.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAgendadas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaCompraToolStripMenuItem;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.DataGridView dgvComprasAguardando;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnAguardando;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataEntrega;
    }
}