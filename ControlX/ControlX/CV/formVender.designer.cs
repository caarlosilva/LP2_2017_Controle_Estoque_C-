namespace ControlX
{
    partial class FormVender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVender));
            this.pnForm = new System.Windows.Forms.Panel();
            this.gbDetalheItem = new System.Windows.Forms.GroupBox();
            this.txFornecedor = new System.Windows.Forms.TextBox();
            this.txCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbQntdEstoque = new System.Windows.Forms.Label();
            this.lbQntdEstoqueShow = new System.Windows.Forms.Label();
            this.lbPrecoShow = new System.Windows.Forms.Label();
            this.gbSelItem = new System.Windows.Forms.GroupBox();
            this.txValorTotalItem = new System.Windows.Forms.TextBox();
            this.lbValorTotalItem = new System.Windows.Forms.Label();
            this.txQntdVenda = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbQntdVenda = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.pnBtCad = new System.Windows.Forms.Panel();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbVendedor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnTroco = new System.Windows.Forms.Panel();
            this.txValorPago = new System.Windows.Forms.TextBox();
            this.lbTrocoShow = new System.Windows.Forms.Label();
            this.lbTroco = new System.Windows.Forms.Label();
            this.lbValorPago = new System.Windows.Forms.Label();
            this.btDelItemVenda = new System.Windows.Forms.Button();
            this.pnTotal = new System.Windows.Forms.Panel();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.gpVendas = new System.Windows.Forms.GroupBox();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coLPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBtVender = new System.Windows.Forms.Panel();
            this.btVender = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pbImagemProd = new System.Windows.Forms.PictureBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.pnForm.SuspendLayout();
            this.gbDetalheItem.SuspendLayout();
            this.gbSelItem.SuspendLayout();
            this.pnBtCad.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnTroco.SuspendLayout();
            this.pnTotal.SuspendLayout();
            this.gpVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.pnBtVender.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnForm.Controls.Add(this.gbDetalheItem);
            this.pnForm.Controls.Add(this.gbSelItem);
            this.pnForm.Controls.Add(this.panel2);
            this.pnForm.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnForm.Location = new System.Drawing.Point(12, 31);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(402, 435);
            this.pnForm.TabIndex = 8;
            // 
            // gbDetalheItem
            // 
            this.gbDetalheItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetalheItem.Controls.Add(this.picLogo);
            this.gbDetalheItem.Controls.Add(this.pbImagemProd);
            this.gbDetalheItem.Controls.Add(this.txFornecedor);
            this.gbDetalheItem.Controls.Add(this.txCategoria);
            this.gbDetalheItem.Controls.Add(this.label1);
            this.gbDetalheItem.Controls.Add(this.lbCategoria);
            this.gbDetalheItem.Controls.Add(this.lbPreco);
            this.gbDetalheItem.Controls.Add(this.lbQntdEstoque);
            this.gbDetalheItem.Controls.Add(this.lbQntdEstoqueShow);
            this.gbDetalheItem.Controls.Add(this.lbPrecoShow);
            this.gbDetalheItem.Location = new System.Drawing.Point(8, 141);
            this.gbDetalheItem.Name = "gbDetalheItem";
            this.gbDetalheItem.Size = new System.Drawing.Size(391, 256);
            this.gbDetalheItem.TabIndex = 32;
            this.gbDetalheItem.TabStop = false;
            this.gbDetalheItem.Text = "Detalhe do Item";
            // 
            // txFornecedor
            // 
            this.txFornecedor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txFornecedor.Location = new System.Drawing.Point(80, 97);
            this.txFornecedor.Name = "txFornecedor";
            this.txFornecedor.ReadOnly = true;
            this.txFornecedor.Size = new System.Drawing.Size(301, 21);
            this.txFornecedor.TabIndex = 35;
            // 
            // txCategoria
            // 
            this.txCategoria.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCategoria.Location = new System.Drawing.Point(80, 59);
            this.txCategoria.Name = "txCategoria";
            this.txCategoria.ReadOnly = true;
            this.txCategoria.Size = new System.Drawing.Size(301, 21);
            this.txCategoria.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fornecedor:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(2, 62);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(68, 13);
            this.lbCategoria.TabIndex = 32;
            this.lbCategoria.Text = "Categoria:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(2, 27);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(44, 13);
            this.lbPreco.TabIndex = 22;
            this.lbPreco.Text = "Preço:";
            // 
            // lbQntdEstoque
            // 
            this.lbQntdEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQntdEstoque.AutoSize = true;
            this.lbQntdEstoque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQntdEstoque.Location = new System.Drawing.Point(180, 27);
            this.lbQntdEstoque.Name = "lbQntdEstoque";
            this.lbQntdEstoque.Size = new System.Drawing.Size(81, 13);
            this.lbQntdEstoque.TabIndex = 23;
            this.lbQntdEstoque.Text = "Qtd Estoque:";
            // 
            // lbQntdEstoqueShow
            // 
            this.lbQntdEstoqueShow.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbQntdEstoqueShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbQntdEstoqueShow.Location = new System.Drawing.Point(266, 23);
            this.lbQntdEstoqueShow.Name = "lbQntdEstoqueShow";
            this.lbQntdEstoqueShow.Size = new System.Drawing.Size(115, 21);
            this.lbQntdEstoqueShow.TabIndex = 30;
            this.lbQntdEstoqueShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPrecoShow
            // 
            this.lbPrecoShow.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbPrecoShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPrecoShow.Location = new System.Drawing.Point(56, 23);
            this.lbPrecoShow.Name = "lbPrecoShow";
            this.lbPrecoShow.Size = new System.Drawing.Size(116, 21);
            this.lbPrecoShow.TabIndex = 31;
            this.lbPrecoShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSelItem
            // 
            this.gbSelItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSelItem.Controls.Add(this.txValorTotalItem);
            this.gbSelItem.Controls.Add(this.lbValorTotalItem);
            this.gbSelItem.Controls.Add(this.txQntdVenda);
            this.gbSelItem.Controls.Add(this.lbNome);
            this.gbSelItem.Controls.Add(this.lbQntdVenda);
            this.gbSelItem.Controls.Add(this.txNome);
            this.gbSelItem.Controls.Add(this.pnBtCad);
            this.gbSelItem.Controls.Add(this.lbId);
            this.gbSelItem.Controls.Add(this.txId);
            this.gbSelItem.Location = new System.Drawing.Point(8, 3);
            this.gbSelItem.Name = "gbSelItem";
            this.gbSelItem.Size = new System.Drawing.Size(391, 131);
            this.gbSelItem.TabIndex = 20;
            this.gbSelItem.TabStop = false;
            this.gbSelItem.Text = "Adicionar Itens";
            // 
            // txValorTotalItem
            // 
            this.txValorTotalItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txValorTotalItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txValorTotalItem.Enabled = false;
            this.txValorTotalItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txValorTotalItem.Location = new System.Drawing.Point(300, 64);
            this.txValorTotalItem.Name = "txValorTotalItem";
            this.txValorTotalItem.Size = new System.Drawing.Size(81, 21);
            this.txValorTotalItem.TabIndex = 31;
            // 
            // lbValorTotalItem
            // 
            this.lbValorTotalItem.AutoSize = true;
            this.lbValorTotalItem.Location = new System.Drawing.Point(175, 68);
            this.lbValorTotalItem.Name = "lbValorTotalItem";
            this.lbValorTotalItem.Size = new System.Drawing.Size(123, 13);
            this.lbValorTotalItem.TabIndex = 30;
            this.lbValorTotalItem.Text = "Valor Total do Item:";
            // 
            // txQntdVenda
            // 
            this.txQntdVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txQntdVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txQntdVenda.Location = new System.Drawing.Point(72, 64);
            this.txQntdVenda.Name = "txQntdVenda";
            this.txQntdVenda.Size = new System.Drawing.Size(87, 21);
            this.txQntdVenda.TabIndex = 2;
            this.txQntdVenda.TextChanged += new System.EventHandler(this.txId_TextChanged);
            this.txQntdVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txQntdVenda_KeyPress);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(2, 28);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 13);
            this.lbNome.TabIndex = 25;
            this.lbNome.Text = "Nome:";
            // 
            // lbQntdVenda
            // 
            this.lbQntdVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQntdVenda.AutoSize = true;
            this.lbQntdVenda.Location = new System.Drawing.Point(1, 68);
            this.lbQntdVenda.Name = "lbQntdVenda";
            this.lbQntdVenda.Size = new System.Drawing.Size(72, 13);
            this.lbQntdVenda.TabIndex = 29;
            this.lbQntdVenda.Text = "Qtd Venda:";
            // 
            // txNome
            // 
            this.txNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(48, 26);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(238, 21);
            this.txNome.TabIndex = 0;
            this.txNome.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // pnBtCad
            // 
            this.pnBtCad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBtCad.Controls.Add(this.btPesquisar);
            this.pnBtCad.Controls.Add(this.btLimpar);
            this.pnBtCad.Controls.Add(this.btAdd);
            this.pnBtCad.Location = new System.Drawing.Point(62, 93);
            this.pnBtCad.Name = "pnBtCad";
            this.pnBtCad.Size = new System.Drawing.Size(266, 28);
            this.pnBtCad.TabIndex = 28;
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btLimpar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(14, 3);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(87, 23);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(119, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(87, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbId
            // 
            this.lbId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(292, 28);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 13);
            this.lbId.TabIndex = 26;
            this.lbId.Text = "ID:";
            this.lbId.Click += new System.EventHandler(this.lbId_Click);
            // 
            // txId
            // 
            this.txId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txId.Location = new System.Drawing.Point(319, 26);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(62, 21);
            this.txId.TabIndex = 1;
            this.txId.TextChanged += new System.EventHandler(this.txId_TextChanged);
            this.txId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txId_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbVendedor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(8, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 27);
            this.panel2.TabIndex = 17;
            // 
            // lbVendedor
            // 
            this.lbVendedor.BackColor = System.Drawing.Color.Transparent;
            this.lbVendedor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbVendedor.Location = new System.Drawing.Point(76, 1);
            this.lbVendedor.Name = "lbVendedor";
            this.lbVendedor.Size = new System.Drawing.Size(304, 21);
            this.lbVendedor.TabIndex = 15;
            this.lbVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Vendedor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnTroco
            // 
            this.pnTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTroco.Controls.Add(this.txValorPago);
            this.pnTroco.Controls.Add(this.lbTrocoShow);
            this.pnTroco.Controls.Add(this.lbTroco);
            this.pnTroco.Controls.Add(this.lbValorPago);
            this.pnTroco.Location = new System.Drawing.Point(420, 401);
            this.pnTroco.Name = "pnTroco";
            this.pnTroco.Size = new System.Drawing.Size(282, 27);
            this.pnTroco.TabIndex = 19;
            // 
            // txValorPago
            // 
            this.txValorPago.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txValorPago.Location = new System.Drawing.Point(71, 3);
            this.txValorPago.Name = "txValorPago";
            this.txValorPago.Size = new System.Drawing.Size(68, 20);
            this.txValorPago.TabIndex = 0;
            this.txValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txValorPago.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txTroco_KeyUp);
            // 
            // lbTrocoShow
            // 
            this.lbTrocoShow.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbTrocoShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTrocoShow.Location = new System.Drawing.Point(219, 3);
            this.lbTrocoShow.Name = "lbTrocoShow";
            this.lbTrocoShow.Size = new System.Drawing.Size(53, 21);
            this.lbTrocoShow.TabIndex = 20;
            this.lbTrocoShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTroco
            // 
            this.lbTroco.AutoSize = true;
            this.lbTroco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTroco.Location = new System.Drawing.Point(145, 6);
            this.lbTroco.Name = "lbTroco";
            this.lbTroco.Size = new System.Drawing.Size(68, 13);
            this.lbTroco.TabIndex = 19;
            this.lbTroco.Text = "Troco: R$";
            // 
            // lbValorPago
            // 
            this.lbValorPago.AutoSize = true;
            this.lbValorPago.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorPago.Location = new System.Drawing.Point(2, 6);
            this.lbValorPago.Name = "lbValorPago";
            this.lbValorPago.Size = new System.Drawing.Size(63, 13);
            this.lbValorPago.TabIndex = 17;
            this.lbValorPago.Text = "Pago: R$";
            // 
            // btDelItemVenda
            // 
            this.btDelItemVenda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelItemVenda.Location = new System.Drawing.Point(4, 3);
            this.btDelItemVenda.Name = "btDelItemVenda";
            this.btDelItemVenda.Size = new System.Drawing.Size(105, 23);
            this.btDelItemVenda.TabIndex = 0;
            this.btDelItemVenda.Text = "Remover Item";
            this.btDelItemVenda.UseVisualStyleBackColor = true;
            this.btDelItemVenda.Click += new System.EventHandler(this.btDelItemVenda_Click);
            // 
            // pnTotal
            // 
            this.pnTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTotal.Controls.Add(this.lbValorTotal);
            this.pnTotal.Controls.Add(this.lbTotal);
            this.pnTotal.Location = new System.Drawing.Point(707, 401);
            this.pnTotal.Name = "pnTotal";
            this.pnTotal.Size = new System.Drawing.Size(160, 27);
            this.pnTotal.TabIndex = 15;
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbValorTotal.Location = new System.Drawing.Point(67, 2);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(86, 21);
            this.lbValorTotal.TabIndex = 15;
            this.lbValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(3, 6);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(64, 13);
            this.lbTotal.TabIndex = 14;
            this.lbTotal.Text = "Total: R$";
            // 
            // gpVendas
            // 
            this.gpVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpVendas.Controls.Add(this.dgvVendas);
            this.gpVendas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpVendas.Location = new System.Drawing.Point(420, 35);
            this.gpVendas.Name = "gpVendas";
            this.gpVendas.Size = new System.Drawing.Size(447, 360);
            this.gpVendas.TabIndex = 14;
            this.gpVendas.TabStop = false;
            this.gpVendas.Text = "Lista de Itens da Venda";
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = null;
            this.dgvVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.colUn,
            this.colPrecoUn,
            this.coLPreco});
            this.dgvVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVendas.Location = new System.Drawing.Point(3, 17);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(441, 340);
            this.dgvVendas.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 15F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 40F;
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
            this.colUn.HeaderText = "Un.";
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
            // pnBtVender
            // 
            this.pnBtVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBtVender.Controls.Add(this.btDelItemVenda);
            this.pnBtVender.Controls.Add(this.btVender);
            this.pnBtVender.Controls.Add(this.btCancelar);
            this.pnBtVender.Location = new System.Drawing.Point(420, 437);
            this.pnBtVender.Name = "pnBtVender";
            this.pnBtVender.Size = new System.Drawing.Size(447, 29);
            this.pnBtVender.TabIndex = 10;
            // 
            // btVender
            // 
            this.btVender.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVender.Location = new System.Drawing.Point(369, 3);
            this.btVender.Name = "btVender";
            this.btVender.Size = new System.Drawing.Size(75, 23);
            this.btVender.TabIndex = 1;
            this.btVender.Text = "Finalizar";
            this.btVender.UseVisualStyleBackColor = true;
            this.btVender.Click += new System.EventHandler(this.btVender_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(294, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(70, 23);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Limpar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(879, 28);
            this.menuStrip1.TabIndex = 19;
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
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(6, 126);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(167, 122);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 37;
            this.picLogo.TabStop = false;
            this.picLogo.Tag = "";
            // 
            // pbImagemProd
            // 
            this.pbImagemProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemProd.Image = global::ControlX.Properties.Resources.product;
            this.pbImagemProd.Location = new System.Drawing.Point(234, 124);
            this.pbImagemProd.Name = "pbImagemProd";
            this.pbImagemProd.Size = new System.Drawing.Size(123, 124);
            this.pbImagemProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProd.TabIndex = 36;
            this.pbImagemProd.TabStop = false;
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
            this.btPesquisar.Location = new System.Drawing.Point(223, 3);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(23, 22);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // FormVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 469);
            this.Controls.Add(this.gpVendas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnTroco);
            this.Controls.Add(this.pnForm);
            this.Controls.Add(this.pnBtVender);
            this.Controls.Add(this.pnTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormVender";
            this.Text = "ControlX - Vendas";
            this.pnForm.ResumeLayout(false);
            this.gbDetalheItem.ResumeLayout(false);
            this.gbDetalheItem.PerformLayout();
            this.gbSelItem.ResumeLayout(false);
            this.gbSelItem.PerformLayout();
            this.pnBtCad.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnTroco.ResumeLayout(false);
            this.pnTroco.PerformLayout();
            this.pnTotal.ResumeLayout(false);
            this.pnTotal.PerformLayout();
            this.gpVendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.pnBtVender.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnForm;
        private System.Windows.Forms.Panel pnBtVender;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btVender;
        private System.Windows.Forms.Panel pnTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.GroupBox gpVendas;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Button btDelItemVenda;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.Panel pnTroco;
        private System.Windows.Forms.Label lbTrocoShow;
        private System.Windows.Forms.Label lbTroco;
        private System.Windows.Forms.Label lbValorPago;
        private System.Windows.Forms.TextBox txValorPago;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbVendedor;
        private System.Windows.Forms.GroupBox gbSelItem;
        private System.Windows.Forms.TextBox txQntdVenda;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbPrecoShow;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbQntdEstoqueShow;
        private System.Windows.Forms.Label lbQntdEstoque;
        private System.Windows.Forms.Label lbQntdVenda;
        public System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Panel pnBtCad;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btLimpar;
        public System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lbId;
        public System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.GroupBox gbDetalheItem;
        private System.Windows.Forms.TextBox txFornecedor;
        private System.Windows.Forms.TextBox txCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coLPreco;
        private System.Windows.Forms.TextBox txValorTotalItem;
        private System.Windows.Forms.Label lbValorTotalItem;
        private System.Windows.Forms.PictureBox pbImagemProd;
        private System.Windows.Forms.PictureBox picLogo;
    }
}