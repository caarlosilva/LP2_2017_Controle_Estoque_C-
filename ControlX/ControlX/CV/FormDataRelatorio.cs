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
        Usuario user = new Usuario();

        public FormDataRelatorio()
        {
            InitializeComponent();
        }

        public FormDataRelatorio(Usuario u)
        {
            InitializeComponent();
            user = u;
        }

        private void btGerar_Click(object sender, EventArgs e)
        {

            DateTime dataIni1 = DateTime.Parse(dtInicio.Value.ToString("dd-MM-yyyy, HH:mm:ss"));
            DateTime dataFim1 = DateTime.Parse(dtFim.Value.ToString("dd-MM-yyyy, HH:mm:ss"));

            FormRelatorios relatorio = new FormRelatorios(user.Nome, dataIni1, dataFim1);
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
