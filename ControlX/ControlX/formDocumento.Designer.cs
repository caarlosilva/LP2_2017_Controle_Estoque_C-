namespace ControlX
{
    partial class formDocumento
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
            this.rtbArea = new System.Windows.Forms.RichTextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btAbrir = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // rtbArea
            // 
            this.rtbArea.Location = new System.Drawing.Point(12, 12);
            this.rtbArea.Name = "rtbArea";
            this.rtbArea.Size = new System.Drawing.Size(478, 330);
            this.rtbArea.TabIndex = 1;
            this.rtbArea.Text = "";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(276, 349);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(150, 349);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(75, 23);
            this.btAbrir.TabIndex = 3;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "*.docx";
            this.ofd.FileName = "Arquivo Word";
            this.ofd.Filter = "Word 201x|*.docx|Word 9x|*.doc";
            // 
            // formDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 384);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.rtbArea);
            this.Name = "formDocumento";
            this.Text = "formDocumento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbArea;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}