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
    public partial class formDataRelatorio : Form
    {
        public int tipoRelatorio;
        Usuario user = new Usuario();

        public formDataRelatorio()
        {
            InitializeComponent();
        }

        public formDataRelatorio(Usuario u)
        {
            InitializeComponent();
            user = u;
        }

        private void btGerar_Click(object sender, EventArgs e)
        {

            DateTime dataIni1 = DateTime.Parse(dtInicio.Value.ToString("dd-MM-yyyy"));
            DateTime dataFim1 = DateTime.Parse(dtFim.Value.ToString("dd-MM-yyyy"));

            FormRelatorios relatorio = new FormRelatorios(user.Nome, dataIni1, dataFim1);

            if (tipoRelatorio == 1) //Compras
            {
                relatorio.Text = "ControlX - Relatório de compras";
                relatorio.tipoRelatorio = 1;
            }

            if (tipoRelatorio == 2) //Vendas por periodo
            {
                relatorio.Text = "ControlX - Relatório de vendas por período";
                relatorio.tipoRelatorio = 2;
            }
            this.Dispose();
            relatorio.Show();
        }
    }
}
