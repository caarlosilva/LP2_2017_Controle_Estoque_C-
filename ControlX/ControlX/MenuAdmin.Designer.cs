namespace ControlX
{
    partial class MenuAdmin
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
            this.btMenuVendas = new System.Windows.Forms.Button();
            this.btCadastroFunc = new System.Windows.Forms.Button();
            this.btControleEstoq = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btMenuVendas
            // 
            this.btMenuVendas.Location = new System.Drawing.Point(3, 10);
            this.btMenuVendas.Name = "btMenuVendas";
            this.btMenuVendas.Size = new System.Drawing.Size(139, 51);
            this.btMenuVendas.TabIndex = 0;
            this.btMenuVendas.Text = "Vender";
            this.btMenuVendas.UseVisualStyleBackColor = true;
            // 
            // btCadastroFunc
            // 
            this.btCadastroFunc.Location = new System.Drawing.Point(161, 10);
            this.btCadastroFunc.Name = "btCadastroFunc";
            this.btCadastroFunc.Size = new System.Drawing.Size(139, 51);
            this.btCadastroFunc.TabIndex = 1;
            this.btCadastroFunc.Text = "Cadastrar Funcionário";
            this.btCadastroFunc.UseVisualStyleBackColor = true;
            // 
            // btControleEstoq
            // 
            this.btControleEstoq.Location = new System.Drawing.Point(319, 10);
            this.btControleEstoq.Name = "btControleEstoq";
            this.btControleEstoq.Size = new System.Drawing.Size(139, 51);
            this.btControleEstoq.TabIndex = 2;
            this.btControleEstoq.Text = "Controle de Estoque";
            this.btControleEstoq.UseVisualStyleBackColor = true;
            this.btControleEstoq.Click += new System.EventHandler(this.btControleEstoq_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(161, 77);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(139, 51);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btMenuVendas);
            this.panel1.Controls.Add(this.btCadastroFunc);
            this.panel1.Controls.Add(this.btControleEstoq);
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 139);
            this.panel1.TabIndex = 4;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 164);
            this.Controls.Add(this.panel1);
            this.Name = "MenuAdmin";
            this.Text = "Menu Principal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMenuVendas;
        private System.Windows.Forms.Button btCadastroFunc;
        private System.Windows.Forms.Button btControleEstoq;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Panel panel1;
    }
}