namespace ControlX
{
    partial class FormUserRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserRelatorio));
            this.cbFunc = new System.Windows.Forms.ComboBox();
            this.dateFim = new System.Windows.Forms.DateTimePicker();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.lbFuncionario = new System.Windows.Forms.Label();
            this.lbDataInicio = new System.Windows.Forms.Label();
            this.lbDataFim = new System.Windows.Forms.Label();
            this.btGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFunc
            // 
            this.cbFunc.FormattingEnabled = true;
            this.cbFunc.Location = new System.Drawing.Point(12, 33);
            this.cbFunc.Name = "cbFunc";
            this.cbFunc.Size = new System.Drawing.Size(155, 21);
            this.cbFunc.TabIndex = 0;
            // 
            // dateFim
            // 
            this.dateFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFim.Location = new System.Drawing.Point(40, 140);
            this.dateFim.Name = "dateFim";
            this.dateFim.Size = new System.Drawing.Size(98, 20);
            this.dateFim.TabIndex = 1;
            // 
            // dateInicio
            // 
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicio.Location = new System.Drawing.Point(40, 87);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(98, 20);
            this.dateInicio.TabIndex = 2;
            // 
            // lbFuncionario
            // 
            this.lbFuncionario.AutoSize = true;
            this.lbFuncionario.Location = new System.Drawing.Point(57, 10);
            this.lbFuncionario.Name = "lbFuncionario";
            this.lbFuncionario.Size = new System.Drawing.Size(65, 13);
            this.lbFuncionario.TabIndex = 3;
            this.lbFuncionario.Text = "Funcionário:";
            // 
            // lbDataInicio
            // 
            this.lbDataInicio.AutoSize = true;
            this.lbDataInicio.Location = new System.Drawing.Point(77, 64);
            this.lbDataInicio.Name = "lbDataInicio";
            this.lbDataInicio.Size = new System.Drawing.Size(24, 13);
            this.lbDataInicio.TabIndex = 4;
            this.lbDataInicio.Text = "De:";
            // 
            // lbDataFim
            // 
            this.lbDataFim.AutoSize = true;
            this.lbDataFim.Location = new System.Drawing.Point(76, 117);
            this.lbDataFim.Name = "lbDataFim";
            this.lbDataFim.Size = new System.Drawing.Size(26, 13);
            this.lbDataFim.TabIndex = 5;
            this.lbDataFim.Text = "Até:";
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(52, 170);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(75, 23);
            this.btGerar.TabIndex = 6;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // FormUserRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(179, 207);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.lbDataFim);
            this.Controls.Add(this.lbDataInicio);
            this.Controls.Add(this.lbFuncionario);
            this.Controls.Add(this.dateInicio);
            this.Controls.Add(this.dateFim);
            this.Controls.Add(this.cbFunc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUserRelatorio";
            this.Text = "ControlX - Relatório de Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFunc;
        private System.Windows.Forms.DateTimePicker dateFim;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.Label lbFuncionario;
        private System.Windows.Forms.Label lbDataInicio;
        private System.Windows.Forms.Label lbDataFim;
        private System.Windows.Forms.Button btGerar;
    }
}