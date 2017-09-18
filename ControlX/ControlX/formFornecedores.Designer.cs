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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFornecedores));
            this.btMenu = new System.Windows.Forms.Button();
            this.pnFiltro = new System.Windows.Forms.Panel();
            this.pnBtns = new System.Windows.Forms.Panel();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btVisualizar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbFornecedores = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnFiltro.SuspendLayout();
            this.pnBtns.SuspendLayout();
            this.gbFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btMenu
            // 
            this.btMenu.Location = new System.Drawing.Point(6, 3);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(70, 23);
            this.btMenu.TabIndex = 4;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // pnFiltro
            // 
            this.pnFiltro.Controls.Add(this.textBox1);
            this.pnFiltro.Controls.Add(this.lbFiltro);
            this.pnFiltro.Location = new System.Drawing.Point(12, 12);
            this.pnFiltro.Name = "pnFiltro";
            this.pnFiltro.Size = new System.Drawing.Size(666, 30);
            this.pnFiltro.TabIndex = 1;
            // 
            // pnBtns
            // 
            this.pnBtns.Controls.Add(this.btRemover);
            this.pnBtns.Controls.Add(this.btEditar);
            this.pnBtns.Controls.Add(this.btVisualizar);
            this.pnBtns.Controls.Add(this.btAdicionar);
            this.pnBtns.Controls.Add(this.btMenu);
            this.pnBtns.Location = new System.Drawing.Point(12, 388);
            this.pnBtns.Name = "pnBtns";
            this.pnBtns.Size = new System.Drawing.Size(666, 29);
            this.pnBtns.TabIndex = 3;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(588, 3);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 0;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btVisualizar
            // 
            this.btVisualizar.Location = new System.Drawing.Point(426, 3);
            this.btVisualizar.Name = "btVisualizar";
            this.btVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btVisualizar.TabIndex = 2;
            this.btVisualizar.Text = "Visualizar";
            this.btVisualizar.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(507, 3);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 1;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(345, 3);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 3;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(9, 9);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(40, 13);
            this.lbFiltro.TabIndex = 0;
            this.lbFiltro.Text = "Filtro:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(613, 21);
            this.textBox1.TabIndex = 0;
            // 
            // gbFornecedores
            // 
            this.gbFornecedores.Controls.Add(this.dataGridView1);
            this.gbFornecedores.Location = new System.Drawing.Point(12, 48);
            this.gbFornecedores.Name = "gbFornecedores";
            this.gbFornecedores.Size = new System.Drawing.Size(666, 334);
            this.gbFornecedores.TabIndex = 4;
            this.gbFornecedores.TabStop = false;
            this.gbFornecedores.Text = "Fornecedores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colCNPJ});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(654, 309);
            this.dataGridView1.TabIndex = 0;
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
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colCNPJ
            // 
            this.colCNPJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCNPJ.FillWeight = 50F;
            this.colCNPJ.HeaderText = "CNPJ";
            this.colCNPJ.Name = "colCNPJ";
            this.colCNPJ.ReadOnly = true;
            // 
            // formFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 429);
            this.Controls.Add(this.gbFornecedores);
            this.Controls.Add(this.pnBtns);
            this.Controls.Add(this.pnFiltro);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formFornecedores";
            this.Text = "Fornecedores";
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            this.pnBtns.ResumeLayout(false);
            this.gbFornecedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Panel pnFiltro;
        private System.Windows.Forms.Panel pnBtns;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btVisualizar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbFornecedores;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCNPJ;
    }
}