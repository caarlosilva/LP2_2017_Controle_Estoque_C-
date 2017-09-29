namespace ControlX
{
    partial class formCadastroForn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastroForn));
            this.lbNome = new System.Windows.Forms.Label();
            this.pnCadForn = new System.Windows.Forms.Panel();
            this.txCNPJ = new System.Windows.Forms.MaskedTextBox();
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
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.pnCadForn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            resources.ApplyResources(this.lbNome, "lbNome");
            this.lbNome.Name = "lbNome";
            // 
            // pnCadForn
            // 
            resources.ApplyResources(this.pnCadForn, "pnCadForn");
            this.pnCadForn.Controls.Add(this.txCNPJ);
            this.pnCadForn.Controls.Add(this.txTel2);
            this.pnCadForn.Controls.Add(this.txTel1);
            this.pnCadForn.Controls.Add(this.txCEP);
            this.pnCadForn.Controls.Add(this.txEstado);
            this.pnCadForn.Controls.Add(this.txCidade);
            this.pnCadForn.Controls.Add(this.txBairro);
            this.pnCadForn.Controls.Add(this.txCompl);
            this.pnCadForn.Controls.Add(this.txRua);
            this.pnCadForn.Controls.Add(this.txNum);
            this.pnCadForn.Controls.Add(this.lbNum);
            this.pnCadForn.Controls.Add(this.lbEstado);
            this.pnCadForn.Controls.Add(this.lbCidade);
            this.pnCadForn.Controls.Add(this.lbBairro);
            this.pnCadForn.Controls.Add(this.lbCompl);
            this.pnCadForn.Controls.Add(this.lbEndereco);
            this.pnCadForn.Controls.Add(this.lbCEP);
            this.pnCadForn.Controls.Add(this.lbTel2);
            this.pnCadForn.Controls.Add(this.lbTel1);
            this.pnCadForn.Controls.Add(this.lbIdForn);
            this.pnCadForn.Controls.Add(this.lbId);
            this.pnCadForn.Controls.Add(this.lbCNPJ);
            this.pnCadForn.Controls.Add(this.txNome);
            this.pnCadForn.Controls.Add(this.lbNome);
            this.pnCadForn.Name = "pnCadForn";
            // 
            // txCNPJ
            // 
            resources.ApplyResources(this.txCNPJ, "txCNPJ");
            this.txCNPJ.Name = "txCNPJ";
            this.txCNPJ.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // txTel2
            // 
            resources.ApplyResources(this.txTel2, "txTel2");
            this.txTel2.Name = "txTel2";
            this.txTel2.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // txTel1
            // 
            resources.ApplyResources(this.txTel1, "txTel1");
            this.txTel1.Name = "txTel1";
            this.txTel1.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // txCEP
            // 
            resources.ApplyResources(this.txCEP, "txCEP");
            this.txCEP.Name = "txCEP";
            this.txCEP.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            this.txCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCEP_KeyPress);
            this.txCEP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txCEP_KeyUp);
            this.txCEP.Leave += new System.EventHandler(this.txCEP_Leave);
            // 
            // txEstado
            // 
            resources.ApplyResources(this.txEstado, "txEstado");
            this.txEstado.Name = "txEstado";
            this.txEstado.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // txCidade
            // 
            resources.ApplyResources(this.txCidade, "txCidade");
            this.txCidade.Name = "txCidade";
            this.txCidade.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // txBairro
            // 
            resources.ApplyResources(this.txBairro, "txBairro");
            this.txBairro.Name = "txBairro";
            this.txBairro.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // txCompl
            // 
            resources.ApplyResources(this.txCompl, "txCompl");
            this.txCompl.Name = "txCompl";
            this.txCompl.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // txRua
            // 
            resources.ApplyResources(this.txRua, "txRua");
            this.txRua.Name = "txRua";
            this.txRua.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // txNum
            // 
            resources.ApplyResources(this.txNum, "txNum");
            this.txNum.Name = "txNum";
            this.txNum.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // lbNum
            // 
            resources.ApplyResources(this.lbNum, "lbNum");
            this.lbNum.Name = "lbNum";
            // 
            // lbEstado
            // 
            resources.ApplyResources(this.lbEstado, "lbEstado");
            this.lbEstado.Name = "lbEstado";
            // 
            // lbCidade
            // 
            resources.ApplyResources(this.lbCidade, "lbCidade");
            this.lbCidade.Name = "lbCidade";
            // 
            // lbBairro
            // 
            resources.ApplyResources(this.lbBairro, "lbBairro");
            this.lbBairro.Name = "lbBairro";
            // 
            // lbCompl
            // 
            resources.ApplyResources(this.lbCompl, "lbCompl");
            this.lbCompl.Name = "lbCompl";
            // 
            // lbEndereco
            // 
            resources.ApplyResources(this.lbEndereco, "lbEndereco");
            this.lbEndereco.Name = "lbEndereco";
            // 
            // lbCEP
            // 
            resources.ApplyResources(this.lbCEP, "lbCEP");
            this.lbCEP.Name = "lbCEP";
            // 
            // lbTel2
            // 
            resources.ApplyResources(this.lbTel2, "lbTel2");
            this.lbTel2.Name = "lbTel2";
            // 
            // lbTel1
            // 
            resources.ApplyResources(this.lbTel1, "lbTel1");
            this.lbTel1.Name = "lbTel1";
            // 
            // lbIdForn
            // 
            resources.ApplyResources(this.lbIdForn, "lbIdForn");
            this.lbIdForn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbIdForn.Name = "lbIdForn";
            // 
            // lbId
            // 
            resources.ApplyResources(this.lbId, "lbId");
            this.lbId.Name = "lbId";
            // 
            // lbCNPJ
            // 
            resources.ApplyResources(this.lbCNPJ, "lbCNPJ");
            this.lbCNPJ.Name = "lbCNPJ";
            // 
            // txNome
            // 
            resources.ApplyResources(this.txNome, "txNome");
            this.txNome.Name = "txNome";
            this.txNome.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.btCadastrar);
            this.panel2.Controls.Add(this.btCancelar);
            this.panel2.Name = "panel2";
            // 
            // btCadastrar
            // 
            resources.ApplyResources(this.btCadastrar, "btCadastrar");
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btCancelar
            // 
            resources.ApplyResources(this.btCancelar, "btCancelar");
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // formCadastroForn
            // 
            this.AcceptButton = this.btCadastrar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnCadForn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCadastroForn";
            this.ShowIcon = false;
            this.pnCadForn.ResumeLayout(false);
            this.pnCadForn.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.Label lbTel2;
        private System.Windows.Forms.Label lbTel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCompl;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbCEP;
        public System.Windows.Forms.TextBox txNome;
        public System.Windows.Forms.Label lbIdForn;
        public System.Windows.Forms.Button btCadastrar;
        public System.Windows.Forms.Button btCancelar;
        public System.Windows.Forms.TextBox txEstado;
        public System.Windows.Forms.TextBox txCidade;
        public System.Windows.Forms.TextBox txBairro;
        public System.Windows.Forms.TextBox txCompl;
        public System.Windows.Forms.TextBox txRua;
        public System.Windows.Forms.TextBox txNum;
        public System.Windows.Forms.MaskedTextBox txTel2;
        public System.Windows.Forms.MaskedTextBox txTel1;
        public System.Windows.Forms.MaskedTextBox txCEP;
        public System.Windows.Forms.MaskedTextBox txCNPJ;
        public System.Windows.Forms.Panel pnCadForn;
    }
}