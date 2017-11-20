namespace ControlX
{
    partial class FormCadastroCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCat));
            this.lbId = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.pnBtCad = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lbIdCategoria = new System.Windows.Forms.Label();
            this.pnCadastro = new System.Windows.Forms.Panel();
            this.pnBtCad.SuspendLayout();
            this.pnCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(408, 22);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 13);
            this.lbId.TabIndex = 5;
            this.lbId.Text = "ID:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(5, 22);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // txNome
            // 
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(52, 19);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(324, 21);
            this.txNome.TabIndex = 0;
            this.txNome.TextChanged += new System.EventHandler(this.txNome_TextChanged);
            // 
            // pnBtCad
            // 
            this.pnBtCad.Controls.Add(this.btCancelar);
            this.pnBtCad.Controls.Add(this.btCadastrar);
            this.pnBtCad.Location = new System.Drawing.Point(328, 55);
            this.pnBtCad.Name = "pnBtCad";
            this.pnBtCad.Size = new System.Drawing.Size(202, 28);
            this.pnBtCad.TabIndex = 8;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(8, 1);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(87, 23);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(108, 2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(87, 23);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lbIdCategoria
            // 
            this.lbIdCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIdCategoria.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdCategoria.Location = new System.Drawing.Point(435, 19);
            this.lbIdCategoria.Name = "lbIdCategoria";
            this.lbIdCategoria.Size = new System.Drawing.Size(95, 21);
            this.lbIdCategoria.TabIndex = 9;
            this.lbIdCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnCadastro
            // 
            this.pnCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCadastro.Controls.Add(this.lbIdCategoria);
            this.pnCadastro.Controls.Add(this.pnBtCad);
            this.pnCadastro.Controls.Add(this.txNome);
            this.pnCadastro.Controls.Add(this.lbNome);
            this.pnCadastro.Controls.Add(this.lbId);
            this.pnCadastro.Location = new System.Drawing.Point(3, 10);
            this.pnCadastro.Name = "pnCadastro";
            this.pnCadastro.Size = new System.Drawing.Size(541, 87);
            this.pnCadastro.TabIndex = 8;
            // 
            // FormCadastroCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 106);
            this.Controls.Add(this.pnCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroCat";
            this.Text = "ControlX - Cadastro de Categoria";
            this.pnBtCad.ResumeLayout(false);
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Panel pnBtCad;
        public System.Windows.Forms.Button btCancelar;
        public System.Windows.Forms.Button btCadastrar;
        public System.Windows.Forms.Label lbIdCategoria;
        private System.Windows.Forms.Panel pnCadastro;
    }
}