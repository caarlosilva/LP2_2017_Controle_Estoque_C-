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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void btControleEstoq_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formEstoque().ShowDialog();
            this.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Dispose();          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToLongTimeString();
        }

        private void btCadastroFunc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formFornecedores().ShowDialog();
            this.Show();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void btVender_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormVender().ShowDialog();
            this.Show();
        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormCompras().ShowDialog();
            this.Show();
        }

        private void btUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formUsuario().ShowDialog();
            this.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formHistoricoCompras().ShowDialog();
            this.Show();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioCompras form = new RelatorioCompras();
            form.Show();
        }
    }
}
