using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlX.CV
{
    public partial class FormDataRelatorio : Form
    {
        public int tipoRelatorio;
        public FormDataRelatorio()
        {
            InitializeComponent();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            FormRelatorios relatorio = new FormRelatorios();
            if (tipoRelatorio == 1)
            {
                relatorio.tipoRelatorio = 1;
            }

            if (tipoRelatorio == 2)
            {
                relatorio.tipoRelatorio = 2;
            }
            this.Dispose();
            relatorio.Show();
        }
    }
}
