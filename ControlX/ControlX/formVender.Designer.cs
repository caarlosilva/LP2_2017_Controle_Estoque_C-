namespace ControlX
{
    partial class formVender
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnBtCad = new System.Windows.Forms.Panel();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.txId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbQntd = new System.Windows.Forms.Label();
            this.txQntd = new System.Windows.Forms.TextBox();
            this.txPreco = new System.Windows.Forms.TextBox();
            this.lbPreco = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btMenu = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btVender = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnBtCad.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.pnMenu);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(12, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 405);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pnBtCad);
            this.panel4.Controls.Add(this.txId);
            this.panel4.Controls.Add(this.lbId);
            this.panel4.Controls.Add(this.txNome);
            this.panel4.Controls.Add(this.lbNome);
            this.panel4.Controls.Add(this.lbQntd);
            this.panel4.Controls.Add(this.txQntd);
            this.panel4.Controls.Add(this.txPreco);
            this.panel4.Controls.Add(this.lbPreco);
            this.panel4.Location = new System.Drawing.Point(8, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 120);
            this.panel4.TabIndex = 16;
            // 
            // pnBtCad
            // 
            this.pnBtCad.Controls.Add(this.btLimpar);
            this.pnBtCad.Controls.Add(this.btCadastrar);
            this.pnBtCad.Location = new System.Drawing.Point(77, 87);
            this.pnBtCad.Name = "pnBtCad";
            this.pnBtCad.Size = new System.Drawing.Size(202, 28);
            this.pnBtCad.TabIndex = 28;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(112, 2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(87, 23);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            // 
            // txId
            // 
            this.txId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txId.Location = new System.Drawing.Point(228, 13);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(88, 20);
            this.txId.TabIndex = 27;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(194, 15);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 13);
            this.lbId.TabIndex = 26;
            this.lbId.Text = "ID:";
            // 
            // txNome
            // 
            this.txNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(67, 12);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(113, 21);
            this.txNome.TabIndex = 24;
            this.txNome.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(20, 15);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 13);
            this.lbNome.TabIndex = 25;
            this.lbNome.Text = "Nome:";
            // 
            // lbQntd
            // 
            this.lbQntd.AutoSize = true;
            this.lbQntd.Location = new System.Drawing.Point(174, 56);
            this.lbQntd.Name = "lbQntd";
            this.lbQntd.Size = new System.Drawing.Size(42, 13);
            this.lbQntd.TabIndex = 23;
            this.lbQntd.Text = "Quant.:";
            // 
            // txQntd
            // 
            this.txQntd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txQntd.Location = new System.Drawing.Point(228, 53);
            this.txQntd.Name = "txQntd";
            this.txQntd.Size = new System.Drawing.Size(88, 20);
            this.txQntd.TabIndex = 21;
            // 
            // txPreco
            // 
            this.txPreco.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txPreco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPreco.Location = new System.Drawing.Point(67, 53);
            this.txPreco.Name = "txPreco";
            this.txPreco.ReadOnly = true;
            this.txPreco.Size = new System.Drawing.Size(94, 21);
            this.txPreco.TabIndex = 20;
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(20, 56);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(44, 13);
            this.lbPreco.TabIndex = 22;
            this.lbPreco.Text = "Preço:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txTotal);
            this.panel3.Controls.Add(this.lbTotal);
            this.panel3.Location = new System.Drawing.Point(18, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 26);
            this.panel3.TabIndex = 15;
            // 
            // txTotal
            // 
            this.txTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txTotal.Location = new System.Drawing.Point(57, 2);
            this.txTotal.Name = "txTotal";
            this.txTotal.ReadOnly = true;
            this.txTotal.Size = new System.Drawing.Size(100, 20);
            this.txTotal.TabIndex = 15;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(17, 5);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 13);
            this.lbTotal.TabIndex = 14;
            this.lbTotal.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvVendas);
            this.groupBox1.Location = new System.Drawing.Point(11, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 200);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas";
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvVendas.Location = new System.Drawing.Point(5, 19);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.Size = new System.Drawing.Size(328, 175);
            this.dgvVendas.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn2.FillWeight = 90F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 70F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMenu.Controls.Add(this.btMenu);
            this.pnMenu.Location = new System.Drawing.Point(16, 371);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(98, 29);
            this.pnMenu.TabIndex = 11;
            // 
            // btMenu
            // 
            this.btMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btMenu.Location = new System.Drawing.Point(5, 3);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(70, 23);
            this.btMenu.TabIndex = 4;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btVender);
            this.panel5.Controls.Add(this.btCancelar);
            this.panel5.Location = new System.Drawing.Point(182, 373);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(174, 29);
            this.panel5.TabIndex = 10;
            // 
            // btVender
            // 
            this.btVender.Location = new System.Drawing.Point(96, 3);
            this.btVender.Name = "btVender";
            this.btVender.Size = new System.Drawing.Size(75, 23);
            this.btVender.TabIndex = 11;
            this.btVender.Text = "Vender";
            this.btVender.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(2, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(5, 3);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(87, 23);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // formVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 425);
            this.Controls.Add(this.panel2);
            this.Name = "formVender";
            this.Text = "Vendas de Mercadoria";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnBtCad.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btVender;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbQntd;
        public System.Windows.Forms.TextBox txQntd;
        public System.Windows.Forms.TextBox txPreco;
        private System.Windows.Forms.Label lbPreco;
        public System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel pnBtCad;
        public System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLimpar;
    }
}