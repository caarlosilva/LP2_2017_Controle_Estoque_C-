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
        public string tipoRelatorio = "estoquemin";
        public FormDataRelatorio()
        {
            InitializeComponent();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            FormRelatorios relatorio = new FormRelatorios();

            if (tipoRelatorio == "compras")
            {
                this.Dispose();
                relatorio.Show();
            }

            if (tipoRelatorio == "estoquemin")
            {
                this.Dispose();
                relatorio.Show();
            }

            if (tipoRelatorio == "vendas")
            {
                this.Dispose();
                relatorio.Show();
            }
        }
    }
}
