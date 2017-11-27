using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlX
{
    public partial class FormHistoricoVendasView : Form
    {
        public FormHistoricoVendasView()
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

        private void lbValor_Click(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void NFtoolStripMenu_Click(object sender, EventArgs e)
        {
            formLogin user = new formLogin();
            FormRelatorios form = new FormRelatorios(user.txUsuario.Text, DateTime.Parse(dateVenda.Value.ToString()), int.Parse(txId.Text.ToString()), txUser.Text);
            form.Text = "ControlX - Nota Fiscal ID: " + int.Parse(txId.Text.ToString());
            form.tipoRelatorio = 5;
            form.Show();
        }
    }
}
