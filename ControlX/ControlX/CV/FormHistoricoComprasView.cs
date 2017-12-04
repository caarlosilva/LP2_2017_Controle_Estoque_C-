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
    public partial class FormHistoricoComprasView : Form
    {
        public FormHistoricoComprasView()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void notaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios(txUser.Text, DateTime.Parse(dateCompra.Value.ToString("dd-MM-yyyy HH:mm:ss")), DateTime.Parse(dateEntrega.Value.ToString("dd-MM-yyyy")), int.Parse(txId.Text.ToString()), txUser.Text);
            form.Text = "ControlX - Nota Fiscal ID: " + txId.ToString();
            form.tipoRelatorio = 7;
            form.ShowDialog();
        }
    }
}
