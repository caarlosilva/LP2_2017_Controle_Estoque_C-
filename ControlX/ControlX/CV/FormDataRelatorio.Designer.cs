namespace ControlX.CV
{
    partial class formDataRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDataRelatorio));
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
            this.dtInicio.Location = new System.Drawing.Point(75, 57);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(112, 21);
            this.dtInicio.TabIndex = 0;
            this.dtInicio.Value = new System.DateTime(2017, 12, 4, 0, 0, 0, 0);
            // 
            // dtFim
            // 
            this.dtFim.Checked = false;
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(75, 109);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(112, 21);
            this.dtFim.TabIndex = 0;
            this.dtFim.Value = new System.DateTime(2017, 12, 4, 0, 0, 0, 0);
            // 
            // lbDataInicio
            // 
            this.lbDataInicio.AutoSize = true;
            this.lbDataInicio.Location = new System.Drawing.Point(117, 38);
            this.lbDataInicio.Name = "lbDataInicio";
            this.lbDataInicio.Size = new System.Drawing.Size(28, 13);
            this.lbDataInicio.TabIndex = 2;
            this.lbDataInicio.Text = "De:";
            // 
            // lbDataFim
            // 
            this.lbDataFim.AutoSize = true;
            this.lbDataFim.Location = new System.Drawing.Point(115, 93);
            this.lbDataFim.Name = "lbDataFim";
            this.lbDataFim.Size = new System.Drawing.Size(31, 13);
            this.lbDataFim.TabIndex = 3;
            this.lbDataFim.Text = "Até:";
            // 
            // lbInstrucao
            // 
            this.lbInstrucao.AutoSize = true;
            this.lbInstrucao.Location = new System.Drawing.Point(3, 13);
            this.lbInstrucao.Name = "lbInstrucao";
            this.lbInstrucao.Size = new System.Drawing.Size(256, 13);
            this.lbInstrucao.TabIndex = 4;
            this.lbInstrucao.Text = "Escolha a data para a geração do relatório:";
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(87, 144);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(87, 23);
            this.btGerar.TabIndex = 5;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // FormDataRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(262, 180);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.lbInstrucao);
            this.Controls.Add(this.lbDataFim);
            this.Controls.Add(this.lbDataInicio);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtInicio);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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