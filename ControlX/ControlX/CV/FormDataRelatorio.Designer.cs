namespace ControlX.CV
{
    partial class FormDataRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataRelatorio));
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.lbDataInicio = new System.Windows.Forms.Label();
            this.lbDataFim = new System.Windows.Forms.Label();
            this.lbInstrucao = new System.Windows.Forms.Label();
            this.btGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtInicio
            // 
            this.dtInicio.AllowDrop = true;
            this.dtInicio.Checked = false;
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(64, 57);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(115, 20);
            this.dtInicio.TabIndex = 0;
            this.dtInicio.Value = new System.DateTime(2017, 12, 1, 1, 0, 0, 0);
            // 
            // dtFim
            // 
            this.dtFim.Checked = false;
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(64, 109);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(115, 20);
            this.dtFim.TabIndex = 0;
            this.dtFim.Value = new System.DateTime(2017, 12, 1, 23, 0, 0, 0);
            // 
            // lbDataInicio
            // 
            this.lbDataInicio.AutoSize = true;
            this.lbDataInicio.Location = new System.Drawing.Point(100, 38);
            this.lbDataInicio.Name = "lbDataInicio";
            this.lbDataInicio.Size = new System.Drawing.Size(24, 13);
            this.lbDataInicio.TabIndex = 2;
            this.lbDataInicio.Text = "De:";
            // 
            // lbDataFim
            // 
            this.lbDataFim.AutoSize = true;
            this.lbDataFim.Location = new System.Drawing.Point(99, 93);
            this.lbDataFim.Name = "lbDataFim";
            this.lbDataFim.Size = new System.Drawing.Size(26, 13);
            this.lbDataFim.TabIndex = 3;
            this.lbDataFim.Text = "Até:";
            // 
            // lbInstrucao
            // 
            this.lbInstrucao.AutoSize = true;
            this.lbInstrucao.Location = new System.Drawing.Point(9, 13);
            this.lbInstrucao.Name = "lbInstrucao";
            this.lbInstrucao.Size = new System.Drawing.Size(211, 13);
            this.lbInstrucao.TabIndex = 4;
            this.lbInstrucao.Text = "Escolha a data para a geração do relatório:";
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(75, 144);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(75, 23);
            this.btGerar.TabIndex = 5;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // FormDataRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(225, 180);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.lbInstrucao);
            this.Controls.Add(this.lbDataFim);
            this.Controls.Add(this.lbDataInicio);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDataRelatorio";
            this.Text = "ControlX - Relatorios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDataInicio;
        private System.Windows.Forms.Label lbDataFim;
        private System.Windows.Forms.Label lbInstrucao;
        private System.Windows.Forms.Button btGerar;
        public System.Windows.Forms.DateTimePicker dtFim;
        public System.Windows.Forms.DateTimePicker dtInicio;
    }
}