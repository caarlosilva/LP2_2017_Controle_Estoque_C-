namespace ControlX
{
    partial class formCadastroUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastroUser));
            this.pnCadUser = new System.Windows.Forms.Panel();
            this.txCPF = new System.Windows.Forms.MaskedTextBox();
            this.txTel2 = new System.Windows.Forms.MaskedTextBox();
            this.txTel1 = new System.Windows.Forms.MaskedTextBox();
            this.txCEP = new System.Windows.Forms.MaskedTextBox();
            this.txEstado = new System.Windows.Forms.TextBox();
            this.txCidade = new System.Windows.Forms.TextBox();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.txCompl = new System.Windows.Forms.TextBox();
            this.txRua = new System.Windows.Forms.TextBox();
            this.txNum = new System.Windows.Forms.TextBox();
            this.lbNum = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbCompl = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbCEP = new System.Windows.Forms.Label();
            this.lbTel2 = new System.Windows.Forms.Label();
            this.lbTel1 = new System.Windows.Forms.Label();
            this.lbIdForn = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbCargos = new System.Windows.Forms.Panel();
            this.txCargo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.btVerificar = new System.Windows.Forms.Button();
            this.lbVerificacao = new System.Windows.Forms.Label();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.pnCadUser.SuspendLayout();
            this.panel2.SuspendLayout();
            this.lbCargos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCadUser
            // 
            this.pnCadUser.Controls.Add(this.txCPF);
            this.pnCadUser.Controls.Add(this.txTel2);
            this.pnCadUser.Controls.Add(this.txTel1);
            this.pnCadUser.Controls.Add(this.txCEP);
            this.pnCadUser.Controls.Add(this.txEstado);
            this.pnCadUser.Controls.Add(this.txCidade);
            this.pnCadUser.Controls.Add(this.txBairro);
            this.pnCadUser.Controls.Add(this.txCompl);
            this.pnCadUser.Controls.Add(this.txRua);
            this.pnCadUser.Controls.Add(this.txNum);
            this.pnCadUser.Controls.Add(this.lbNum);
            this.pnCadUser.Controls.Add(this.lbEstado);
            this.pnCadUser.Controls.Add(this.lbCidade);
            this.pnCadUser.Controls.Add(this.lbBairro);
            this.pnCadUser.Controls.Add(this.lbCompl);
            this.pnCadUser.Controls.Add(this.lbEndereco);
            this.pnCadUser.Controls.Add(this.lbCEP);
            this.pnCadUser.Controls.Add(this.lbTel2);
            this.pnCadUser.Controls.Add(this.lbTel1);
            this.pnCadUser.Controls.Add(this.lbIdForn);
            this.pnCadUser.Controls.Add(this.lbId);
            this.pnCadUser.Controls.Add(this.lbCPF);
            this.pnCadUser.Controls.Add(this.txNome);
            this.pnCadUser.Controls.Add(this.lbNome);
            this.pnCadUser.Location = new System.Drawing.Point(12, 12);
            this.pnCadUser.Name = "pnCadUser";
            this.pnCadUser.Size = new System.Drawing.Size(410, 295);
            this.pnCadUser.TabIndex = 2;
            // 
            // txCPF
            // 
            this.txCPF.Location = new System.Drawing.Point(54, 42);
            this.txCPF.Mask = "000,000,000-00";
            this.txCPF.Name = "txCPF";
            this.txCPF.Size = new System.Drawing.Size(125, 21);
            this.txCPF.TabIndex = 1;
            // 
            // txTel2
            // 
            this.txTel2.Location = new System.Drawing.Point(141, 108);
            this.txTel2.Mask = "(00) 00000-0009";
            this.txTel2.Name = "txTel2";
            this.txTel2.Size = new System.Drawing.Size(257, 21);
            this.txTel2.TabIndex = 3;
            // 
            // txTel1
            // 
            this.txTel1.Location = new System.Drawing.Point(141, 74);
            this.txTel1.Mask = "(00) 00000-0009";
            this.txTel1.Name = "txTel1";
            this.txTel1.Size = new System.Drawing.Size(257, 21);
            this.txTel1.TabIndex = 2;
            // 
            // txCEP
            // 
            this.txCEP.Location = new System.Drawing.Point(54, 140);
            this.txCEP.Mask = "00000-000";
            this.txCEP.Name = "txCEP";
            this.txCEP.Size = new System.Drawing.Size(91, 21);
            this.txCEP.TabIndex = 4;
            // 
            // txEstado
            // 
            this.txEstado.Location = new System.Drawing.Point(316, 261);
            this.txEstado.Name = "txEstado";
            this.txEstado.Size = new System.Drawing.Size(82, 21);
            this.txEstado.TabIndex = 10;
            // 
            // txCidade
            // 
            this.txCidade.Location = new System.Drawing.Point(58, 261);
            this.txCidade.Name = "txCidade";
            this.txCidade.Size = new System.Drawing.Size(196, 21);
            this.txCidade.TabIndex = 9;
            // 
            // txBairro
            // 
            this.txBairro.Location = new System.Drawing.Point(58, 231);
            this.txBairro.Name = "txBairro";
            this.txBairro.Size = new System.Drawing.Size(340, 21);
            this.txBairro.TabIndex = 8;
            // 
            // txCompl
            // 
            this.txCompl.Location = new System.Drawing.Point(98, 199);
            this.txCompl.Name = "txCompl";
            this.txCompl.Size = new System.Drawing.Size(300, 21);
            this.txCompl.TabIndex = 7;
            // 
            // txRua
            // 
            this.txRua.Location = new System.Drawing.Point(58, 172);
            this.txRua.Name = "txRua";
            this.txRua.Size = new System.Drawing.Size(340, 21);
            this.txRua.TabIndex = 6;
            // 
            // txNum
            // 
            this.txNum.Location = new System.Drawing.Point(328, 140);
            this.txNum.Name = "txNum";
            this.txNum.Size = new System.Drawing.Size(70, 21);
            this.txNum.TabIndex = 5;
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNum.Location = new System.Drawing.Point(302, 143);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(26, 13);
            this.lbNum.TabIndex = 17;
            this.lbNum.Text = "N°:";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbEstado.Location = new System.Drawing.Point(262, 264);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(50, 13);
            this.lbEstado.TabIndex = 16;
            this.lbEstado.Text = "Estado:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCidade.Location = new System.Drawing.Point(6, 264);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(52, 13);
            this.lbCidade.TabIndex = 15;
            this.lbCidade.Text = "Cidade:";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBairro.Location = new System.Drawing.Point(6, 234);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(47, 13);
            this.lbBairro.TabIndex = 14;
            this.lbBairro.Text = "Bairro:";
            // 
            // lbCompl
            // 
            this.lbCompl.AutoSize = true;
            this.lbCompl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCompl.Location = new System.Drawing.Point(3, 203);
            this.lbCompl.Name = "lbCompl";
            this.lbCompl.Size = new System.Drawing.Size(92, 13);
            this.lbCompl.TabIndex = 13;
            this.lbCompl.Text = "Complemento:";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbEndereco.Location = new System.Drawing.Point(6, 175);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(34, 13);
            this.lbEndereco.TabIndex = 12;
            this.lbEndereco.Text = "Rua:";
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCEP.Location = new System.Drawing.Point(6, 143);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(35, 13);
            this.lbCEP.TabIndex = 10;
            this.lbCEP.Text = "CEP:";
            // 
            // lbTel2
            // 
            this.lbTel2.AutoSize = true;
            this.lbTel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTel2.Location = new System.Drawing.Point(6, 108);
            this.lbTel2.Name = "lbTel2";
            this.lbTel2.Size = new System.Drawing.Size(120, 13);
            this.lbTel2.TabIndex = 7;
            this.lbTel2.Text = "Telefone(Opcional):";
            // 
            // lbTel1
            // 
            this.lbTel1.AutoSize = true;
            this.lbTel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTel1.Location = new System.Drawing.Point(6, 77);
            this.lbTel1.Name = "lbTel1";
            this.lbTel1.Size = new System.Drawing.Size(113, 13);
            this.lbTel1.TabIndex = 6;
            this.lbTel1.Text = "Telefone Principal:";
            // 
            // lbIdForn
            // 
            this.lbIdForn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbIdForn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbIdForn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbIdForn.Location = new System.Drawing.Point(336, 42);
            this.lbIdForn.Name = "lbIdForn";
            this.lbIdForn.Size = new System.Drawing.Size(62, 20);
            this.lbIdForn.TabIndex = 5;
            this.lbIdForn.Text = "001";
            this.lbIdForn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbId.Location = new System.Drawing.Point(311, 46);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 13);
            this.lbId.TabIndex = 4;
            this.lbId.Text = "ID:";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCPF.Location = new System.Drawing.Point(6, 46);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(34, 13);
            this.lbCPF.TabIndex = 2;
            this.lbCPF.Text = "CPF:";
            // 
            // txNome
            // 
            this.txNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txNome.Location = new System.Drawing.Point(54, 11);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(344, 21);
            this.txNome.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNome.Location = new System.Drawing.Point(6, 14);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btCadastrar);
            this.panel2.Controls.Add(this.btCancelar);
            this.panel2.Location = new System.Drawing.Point(12, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 31);
            this.panel2.TabIndex = 3;
            // 
            // btCadastrar
            // 
            this.btCadastrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btCadastrar.Location = new System.Drawing.Point(330, 5);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btCancelar.Location = new System.Drawing.Point(243, 5);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbCargos
            // 
            this.lbCargos.Controls.Add(this.lbVerificacao);
            this.lbCargos.Controls.Add(this.btVerificar);
            this.lbCargos.Controls.Add(this.pbUser);
            this.lbCargos.Controls.Add(this.pictureBox1);
            this.lbCargos.Controls.Add(this.textBox2);
            this.lbCargos.Controls.Add(this.lbSenha);
            this.lbCargos.Controls.Add(this.textBox1);
            this.lbCargos.Controls.Add(this.lbLogin);
            this.lbCargos.Controls.Add(this.comboBox1);
            this.lbCargos.Controls.Add(this.txCargo);
            this.lbCargos.Location = new System.Drawing.Point(12, 313);
            this.lbCargos.Name = "lbCargos";
            this.lbCargos.Size = new System.Drawing.Size(410, 84);
            this.lbCargos.TabIndex = 4;
            // 
            // txCargo
            // 
            this.txCargo.AutoSize = true;
            this.txCargo.Location = new System.Drawing.Point(9, 4);
            this.txCargo.Name = "txCargo";
            this.txCargo.Size = new System.Drawing.Size(92, 13);
            this.txCargo.TabIndex = 0;
            this.txCargo.Text = "Cargo/Função:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Supervisor",
            "Auxiliar de Almoxarifado",
            "Caixa"});
            this.comboBox1.Location = new System.Drawing.Point(98, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(9, 33);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(42, 13);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Text = "Login:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 21);
            this.textBox1.TabIndex = 3;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(9, 62);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(48, 13);
            this.lbSenha.TabIndex = 4;
            this.lbSenha.Text = "Senha:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 21);
            this.textBox2.TabIndex = 5;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlX.Properties.Resources.pwd;
            this.pictureBox1.Location = new System.Drawing.Point(272, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUser.Image = global::ControlX.Properties.Resources.user1;
            this.pbUser.Location = new System.Drawing.Point(272, 30);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(24, 23);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 10;
            this.pbUser.TabStop = false;
            // 
            // btVerificar
            // 
            this.btVerificar.Location = new System.Drawing.Point(316, 59);
            this.btVerificar.Name = "btVerificar";
            this.btVerificar.Size = new System.Drawing.Size(75, 23);
            this.btVerificar.TabIndex = 11;
            this.btVerificar.Text = "Verificar";
            this.btVerificar.UseVisualStyleBackColor = true;
            // 
            // lbVerificacao
            // 
            this.lbVerificacao.AutoSize = true;
            this.lbVerificacao.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVerificacao.ForeColor = System.Drawing.Color.Red;
            this.lbVerificacao.Location = new System.Drawing.Point(325, 23);
            this.lbVerificacao.Name = "lbVerificacao";
            this.lbVerificacao.Size = new System.Drawing.Size(49, 25);
            this.lbVerificacao.TabIndex = 12;
            this.lbVerificacao.Text = "X✔";
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.Color.Red;
            this.lbMensagem.Location = new System.Drawing.Point(120, 400);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(193, 14);
            this.lbMensagem.TabIndex = 13;
            this.lbMensagem.Text = "Usuário \'Ronaldo\' já existe !";
            // 
            // formCadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 452);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.lbCargos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnCadUser);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCadastroUser";
            this.Text = "ControlX - Cadastrar Usuário";
            this.pnCadUser.ResumeLayout(false);
            this.pnCadUser.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.lbCargos.ResumeLayout(false);
            this.lbCargos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnCadUser;
        public System.Windows.Forms.MaskedTextBox txCPF;
        public System.Windows.Forms.MaskedTextBox txTel2;
        public System.Windows.Forms.MaskedTextBox txTel1;
        public System.Windows.Forms.MaskedTextBox txCEP;
        public System.Windows.Forms.TextBox txEstado;
        public System.Windows.Forms.TextBox txCidade;
        public System.Windows.Forms.TextBox txBairro;
        public System.Windows.Forms.TextBox txCompl;
        public System.Windows.Forms.TextBox txRua;
        public System.Windows.Forms.TextBox txNum;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCompl;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.Label lbTel2;
        private System.Windows.Forms.Label lbTel1;
        public System.Windows.Forms.Label lbIdForn;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbCPF;
        public System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btCadastrar;
        public System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Panel lbCargos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txCargo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbVerificacao;
        private System.Windows.Forms.Button btVerificar;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lbMensagem;
    }
}