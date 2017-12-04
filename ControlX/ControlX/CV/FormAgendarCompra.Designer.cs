namespace ControlX
{
    partial class FormAgendarCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgendarCompra));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btRemoverTudo = new System.Windows.Forms.Button();
            this.btDelItemCompra = new System.Windows.Forms.Button();
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.txPrecoCompra = new System.Windows.Forms.TextBox();
            this.lbPrecoCompra = new System.Windows.Forms.Label();
            this.txQntdCompra = new System.Windows.Forms.TextBox();
            this.lbPrecoShow = new System.Windows.Forms.Label();
            this.lbQntdEstoqueShow = new System.Windows.Forms.Label();
            this.lbQntdCompra = new System.Windows.Forms.Label();
            this.pnBtCad = new System.Windows.Forms.Panel();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbQntdEstoque = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.gpItensCompra = new System.Windows.Forms.GroupBox();
            this.dgvItensCompra = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coLPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnListaCompra = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDetalhesCompra = new System.Windows.Forms.GroupBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbNumCompra = new System.Windows.Forms.Label();
            this.lbValorShow = new System.Windows.Forms.Label();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.btComprar = new System.Windows.Forms.Button();
            this.lbValor = new System.Windows.Forms.Label();
            this.dtCompra = new System.Windows.Forms.DateTimePicker();
            this.lbDataEntrega = new System.Windows.Forms.Label();
            this.dtEntrega = new System.Windows.Forms.DateTimePicker();
            this.lbDataCompra = new System.Windows.Forms.Label();
            this.pnMenu.SuspendLayout();
            this.pnCabecalho.SuspendLayout();
            this.pnBtCad.SuspendLayout();
            this.gpItensCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensCompra)).BeginInit();
            this.pnListaCompra.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbDetalhesCompra.SuspendLayout();
            this.pnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMenu.Controls.Add(this.btRemoverTudo);
            this.pnMenu.Controls.Add(this.btDelItemCompra);
            this.pnMenu.Location = new System.Drawing.Point(6, 369);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(499, 29);
            this.pnMenu.TabIndex = 13;
            // 
            // btRemoverTudo
            // 
            this.btRemoverTudo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverTudo.Location = new System.Drawing.Point(392, 3);
            this.btRemoverTudo.Name = "btRemoverTudo";
            this.btRemoverTudo.Size = new System.Drawing.Size(104, 23);
            this.btRemoverTudo.TabIndex = 2;
            this.btRemoverTudo.Text = "Remover Tudo";
            this.btRemoverTudo.UseVisualStyleBackColor = true;
            this.btRemoverTudo.Click += new System.EventHandler(this.btRemoverTudo_Click);
            // 
            // btDelItemCompra
            // 
            this.btDelItemCompra.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelItemCompra.Location = new System.Drawing.Point(273, 3);
            this.btDelItemCompra.Name = "btDelItemCompra";
            this.btDelItemCompra.Size = new System.Drawing.Size(98, 23);
            this.btDelItemCompra.TabIndex = 1;
            this.btDelItemCompra.Text = "Remover Item";
            this.btDelItemCompra.UseVisualStyleBackColor = true;
            this.btDelItemCompra.Click += new System.EventHandler(this.btDelItemCompra_Click);
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCabecalho.Controls.Add(this.txPrecoCompra);
            this.pnCabecalho.Controls.Add(this.lbPrecoCompra);
            this.pnCabecalho.Controls.Add(this.txQntdCompra);
            this.pnCabecalho.Controls.Add(this.lbPrecoShow);
            this.pnCabecalho.Controls.Add(this.lbQntdEstoqueShow);
            this.pnCabecalho.Controls.Add(this.lbQntdCompra);
            this.pnCabecalho.Controls.Add(this.pnBtCad);
            this.pnCabecalho.Controls.Add(this.txId);
            this.pnCabecalho.Controls.Add(this.lbId);
            this.pnCabecalho.Controls.Add(this.txNome);
            this.pnCabecalho.Controls.Add(this.lbNome);
            this.pnCabecalho.Controls.Add(this.lbQntdEstoque);
            this.pnCabecalho.Controls.Add(this.lbPreco);
            this.pnCabecalho.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnCabecalho.Location = new System.Drawing.Point(3, 3);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Size = new System.Drawing.Size(502, 125);
            this.pnCabecalho.TabIndex = 18;
            // 
            // txPrecoCompra
            // 
            this.txPrecoCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txPrecoCompra.Location = new System.Drawing.Point(84, 92);
            this.txPrecoCompra.Name = "txPrecoCompra";
            this.txPrecoCompra.Size = new System.Drawing.Size(111, 21);
            this.txPrecoCompra.TabIndex = 34;
            this.txPrecoCompra.TextChanged += new System.EventHandler(this.txQntdCompra_TextChanged);
            this.txPrecoCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPrecoCompra_KeyPress);
            // 
            // lbPrecoCompra
            // 
            this.lbPrecoCompra.Location = new System.Drawing.Point(4, 86);
            this.lbPrecoCompra.Name = "lbPrecoCompra";
            this.lbPrecoCompra.Size = new System.Drawing.Size(84, 34);
            this.lbPrecoCompra.TabIndex = 33;
            this.lbPrecoCompra.Text = "Preço Un. do     Produto:";
            // 
            // txQntdCompra
            // 
            this.txQntdCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txQntdCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txQntdCompra.Location = new System.Drawing.Point(432, 53);
            this.txQntdCompra.Name = "txQntdCompra";
            this.txQntdCompra.Size = new System.Drawing.Size(62, 21);
            this.txQntdCompra.TabIndex = 32;
            this.txQntdCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txQntdCompra.TextChanged += new System.EventHandler(this.txQntdCompra_TextChanged);
            this.txQntdCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txQntdCompra_KeyPress);
            // 
            // lbPrecoShow
            // 
            this.lbPrecoShow.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbPrecoShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPrecoShow.Location = new System.Drawing.Point(50, 53);
            this.lbPrecoShow.Name = "lbPrecoShow";
            this.lbPrecoShow.Size = new System.Drawing.Size(97, 21);
            this.lbPrecoShow.TabIndex = 31;
            this.lbPrecoShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbQntdEstoqueShow
            // 
            this.lbQntdEstoqueShow.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbQntdEstoqueShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbQntdEstoqueShow.Location = new System.Drawing.Point(237, 53);
            this.lbQntdEstoqueShow.Name = "lbQntdEstoqueShow";
            this.lbQntdEstoqueShow.Size = new System.Drawing.Size(110, 21);
            this.lbQntdEstoqueShow.TabIndex = 30;
            this.lbQntdEstoqueShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbQntdCompra
            // 
            this.lbQntdCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQntdCompra.AutoSize = true;
            this.lbQntdCompra.Location = new System.Drawing.Point(353, 57);
            this.lbQntdCompra.Name = "lbQntdCompra";
            this.lbQntdCompra.Size = new System.Drawing.Size(82, 13);
            this.lbQntdCompra.TabIndex = 29;
            this.lbQntdCompra.Text = "Qtd Compra:";
            // 
            // pnBtCad
            // 
            this.pnBtCad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBtCad.Controls.Add(this.btPesquisar);
            this.pnBtCad.Controls.Add(this.btLimpar);
            this.pnBtCad.Controls.Add(this.btAdd);
            this.pnBtCad.Location = new System.Drawing.Point(264, 88);
            this.pnBtCad.Name = "pnBtCad";
            this.pnBtCad.Size = new System.Drawing.Size(230, 28);
            this.pnBtCad.TabIndex = 28;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btPesquisar.BackgroundImage = global::ControlX.Properties.Resources.search;
            this.btPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesquisar.Cursor = System.Windows.Forms.Cursors.Help;
            this.btPesquisar.FlatAppearance.BorderSize = 0;
            this.btPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Location = new System.Drawing.Point(8, 3);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(23, 22);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btLimpar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(42, 3);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(87, 23);
            this.btLimpar.TabIndex = 0;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(137, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(87, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txId
            // 
            this.txId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txId.Location = new System.Drawing.Point(428, 13);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(66, 21);
            this.txId.TabIndex = 1;
            this.txId.TextChanged += new System.EventHandler(this.txId_TextChanged);
            // 
            // lbId
            // 
            this.lbId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(396, 15);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 13);
            this.lbId.TabIndex = 26;
            this.lbId.Text = "ID:";
            // 
            // txNome
            // 
            this.txNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(46, 13);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(331, 21);
            this.txNome.TabIndex = 0;
            this.txNome.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(4, 15);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 13);
            this.lbNome.TabIndex = 25;
            this.lbNome.Text = "Nome:";
            // 
            // lbQntdEstoque
            // 
            this.lbQntdEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQntdEstoque.AutoSize = true;
            this.lbQntdEstoque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQntdEstoque.Location = new System.Drawing.Point(153, 55);
            this.lbQntdEstoque.Name = "lbQntdEstoque";
            this.lbQntdEstoque.Size = new System.Drawing.Size(81, 13);
            this.lbQntdEstoque.TabIndex = 23;
            this.lbQntdEstoque.Text = "Qtd Estoque:";
            // 
            // lbPreco
            // 
            this.lbPreco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(4, 47);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(50, 36);
            this.lbPreco.TabIndex = 22;
            this.lbPreco.Text = "Preço Venda:";
            // 
            // gpItensCompra
            // 
            this.gpItensCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpItensCompra.Controls.Add(this.dgvItensCompra);
            this.gpItensCompra.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpItensCompra.Location = new System.Drawing.Point(6, 134);
            this.gpItensCompra.Name = "gpItensCompra";
            this.gpItensCompra.Size = new System.Drawing.Size(499, 229);
            this.gpItensCompra.TabIndex = 17;
            this.gpItensCompra.TabStop = false;
            this.gpItensCompra.Text = "Produtos da compra";
            // 
            // dgvItensCompra
            // 
            this.dgvItensCompra.AllowUserToAddRows = false;
            this.dgvItensCompra.AllowUserToDeleteRows = false;
            this.dgvItensCompra.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = null;
            this.dgvItensCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItensCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvItensCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.colUn,
            this.colPrecoUn,
            this.coLPreco});
            this.dgvItensCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItensCompra.Location = new System.Drawing.Point(3, 17);
            this.dgvItensCompra.Name = "dgvItensCompra";
            this.dgvItensCompra.ReadOnly = true;
            this.dgvItensCompra.RowHeadersVisible = false;
            this.dgvItensCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensCompra.Size = new System.Drawing.Size(493, 209);
            this.dgvItensCompra.TabIndex = 0;
            this.dgvItensCompra.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItensCompra_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 15F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 45F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.FillWeight = 15F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Qtd.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // colUn
            // 
            this.colUn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colUn.DefaultCellStyle = dataGridViewCellStyle3;
            this.colUn.FillWeight = 7F;
            this.colUn.HeaderText = "";
            this.colUn.Name = "colUn";
            this.colUn.ReadOnly = true;
            // 
            // colPrecoUn
            // 
            this.colPrecoUn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.colPrecoUn.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPrecoUn.FillWeight = 20F;
            this.colPrecoUn.HeaderText = "Preço Unitário";
            this.colPrecoUn.Name = "colPrecoUn";
            this.colPrecoUn.ReadOnly = true;
            // 
            // coLPreco
            // 
            this.coLPreco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.coLPreco.DefaultCellStyle = dataGridViewCellStyle5;
            this.coLPreco.FillWeight = 20F;
            this.coLPreco.HeaderText = "Preço Total";
            this.coLPreco.Name = "coLPreco";
            this.coLPreco.ReadOnly = true;
            // 
            // pnListaCompra
            // 
            this.pnListaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnListaCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListaCompra.Controls.Add(this.pnCabecalho);
            this.pnListaCompra.Controls.Add(this.gpItensCompra);
            this.pnListaCompra.Controls.Add(this.pnMenu);
            this.pnListaCompra.Location = new System.Drawing.Point(3, 31);
            this.pnListaCompra.Name = "pnListaCompra";
            this.pnListaCompra.Size = new System.Drawing.Size(510, 403);
            this.pnListaCompra.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Image = global::ControlX.Properties.Resources.left_arrow;
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // gbDetalhesCompra
            // 
            this.gbDetalhesCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetalhesCompra.BackgroundImage = global::ControlX.Properties.Resources.shopping_cart_PNG362;
            this.gbDetalhesCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbDetalhesCompra.Controls.Add(this.lbUser);
            this.gbDetalhesCompra.Controls.Add(this.lbUsuario);
            this.gbDetalhesCompra.Controls.Add(this.lbNumCompra);
            this.gbDetalhesCompra.Controls.Add(this.lbValorShow);
            this.gbDetalhesCompra.Controls.Add(this.pnButtons);
            this.gbDetalhesCompra.Controls.Add(this.lbValor);
            this.gbDetalhesCompra.Controls.Add(this.dtCompra);
            this.gbDetalhesCompra.Controls.Add(this.lbDataEntrega);
            this.gbDetalhesCompra.Controls.Add(this.dtEntrega);
            this.gbDetalhesCompra.Controls.Add(this.lbDataCompra);
            this.gbDetalhesCompra.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalhesCompra.Location = new System.Drawing.Point(519, 31);
            this.gbDetalhesCompra.Name = "gbDetalhesCompra";
            this.gbDetalhesCompra.Size = new System.Drawing.Size(314, 403);
            this.gbDetalhesCompra.TabIndex = 15;
            this.gbDetalhesCompra.TabStop = false;
            this.gbDetalhesCompra.Text = "Detalhes da Compra";
            // 
            // lbUser
            // 
            this.lbUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUser.Location = new System.Drawing.Point(88, 136);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(208, 21);
            this.lbUser.TabIndex = 17;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(8, 141);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(61, 13);
            this.lbUsuario.TabIndex = 16;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbNumCompra
            // 
            this.lbNumCompra.AutoSize = true;
            this.lbNumCompra.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumCompra.Location = new System.Drawing.Point(65, 19);
            this.lbNumCompra.Name = "lbNumCompra";
            this.lbNumCompra.Size = new System.Drawing.Size(164, 13);
            this.lbNumCompra.TabIndex = 15;
            this.lbNumCompra.Text = "Pedido de Compra N° 01";
            // 
            // lbValorShow
            // 
            this.lbValorShow.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbValorShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbValorShow.Location = new System.Drawing.Point(88, 108);
            this.lbValorShow.Name = "lbValorShow";
            this.lbValorShow.Size = new System.Drawing.Size(208, 21);
            this.lbValorShow.TabIndex = 14;
            this.lbValorShow.TextChanged += new System.EventHandler(this.lbValorShow_TextChanged);
            // 
            // pnButtons
            // 
            this.pnButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnButtons.Controls.Add(this.btComprar);
            this.pnButtons.Location = new System.Drawing.Point(9, 370);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(305, 29);
            this.pnButtons.TabIndex = 12;
            // 
            // btComprar
            // 
            this.btComprar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btComprar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComprar.Location = new System.Drawing.Point(183, 3);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(119, 23);
            this.btComprar.TabIndex = 0;
            this.btComprar.Text = "Agendar Compra";
            this.btComprar.UseVisualStyleBackColor = true;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.BackColor = System.Drawing.Color.Transparent;
            this.lbValor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.Location = new System.Drawing.Point(8, 111);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(82, 13);
            this.lbValor.TabIndex = 13;
            this.lbValor.Text = "Valor Total:";
            // 
            // dtCompra
            // 
            this.dtCompra.CustomFormat = "dd/MM/yyy";
            this.dtCompra.Enabled = false;
            this.dtCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCompra.Location = new System.Drawing.Point(157, 44);
            this.dtCompra.Name = "dtCompra";
            this.dtCompra.Size = new System.Drawing.Size(139, 21);
            this.dtCompra.TabIndex = 0;
            // 
            // lbDataEntrega
            // 
            this.lbDataEntrega.AutoSize = true;
            this.lbDataEntrega.BackColor = System.Drawing.Color.Transparent;
            this.lbDataEntrega.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataEntrega.Location = new System.Drawing.Point(8, 80);
            this.lbDataEntrega.Name = "lbDataEntrega";
            this.lbDataEntrega.Size = new System.Drawing.Size(143, 13);
            this.lbDataEntrega.TabIndex = 3;
            this.lbDataEntrega.Text = "Previsão de Entrega:";
            // 
            // dtEntrega
            // 
            this.dtEntrega.CustomFormat = "dd/MM/yyy";
            this.dtEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEntrega.Location = new System.Drawing.Point(157, 76);
            this.dtEntrega.Name = "dtEntrega";
            this.dtEntrega.Size = new System.Drawing.Size(139, 21);
            this.dtEntrega.TabIndex = 1;
            // 
            // lbDataCompra
            // 
            this.lbDataCompra.AutoSize = true;
            this.lbDataCompra.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCompra.Location = new System.Drawing.Point(8, 47);
            this.lbDataCompra.Name = "lbDataCompra";
            this.lbDataCompra.Size = new System.Drawing.Size(115, 13);
            this.lbDataCompra.TabIndex = 2;
            this.lbDataCompra.Text = "Data da Compra:";
            // 
            // FormAgendarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 434);
            this.Controls.Add(this.gbDetalhesCompra);
            this.Controls.Add(this.pnListaCompra);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAgendarCompra";
            this.Text = "ControlX - Agendar Compra";
            this.pnMenu.ResumeLayout(false);
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.pnBtCad.ResumeLayout(false);
            this.gpItensCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensCompra)).EndInit();
            this.pnListaCompra.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbDetalhesCompra.ResumeLayout(false);
            this.gbDetalhesCompra.PerformLayout();
            this.pnButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnMenu;
        public System.Windows.Forms.Panel pnButtons;
        public System.Windows.Forms.Button btComprar;
        private System.Windows.Forms.Panel pnCabecalho;
        private System.Windows.Forms.TextBox txQntdCompra;
        private System.Windows.Forms.Label lbPrecoShow;
        private System.Windows.Forms.Label lbQntdEstoqueShow;
        private System.Windows.Forms.Label lbQntdCompra;
        private System.Windows.Forms.Panel pnBtCad;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btLimpar;
        public System.Windows.Forms.Button btAdd;
        public System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label lbId;
        public System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbQntdEstoque;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.GroupBox gpItensCompra;
        private System.Windows.Forms.DataGridView dgvItensCompra;
        private System.Windows.Forms.Panel pnListaCompra;
        private System.Windows.Forms.Button btRemoverTudo;
        private System.Windows.Forms.Button btDelItemCompra;
        private System.Windows.Forms.DateTimePicker dtCompra;
        private System.Windows.Forms.DateTimePicker dtEntrega;
        private System.Windows.Forms.Label lbDataCompra;
        private System.Windows.Forms.Label lbDataEntrega;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbValorShow;
        private System.Windows.Forms.GroupBox gbDetalhesCompra;
        private System.Windows.Forms.Label lbNumCompra;
        private System.Windows.Forms.TextBox txPrecoCompra;
        private System.Windows.Forms.Label lbPrecoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coLPreco;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        public System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbUsuario;
    }
}