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
        DAO.UsuarioDao u = new DAO.UsuarioDao();
        

       

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

        private void btVender_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVender form = new FormVender();
            Usuario user = u.Ler(txNome.Text);
            form.lbVendedor.Text = user.Nome;
            form.ShowDialog();

            this.Show();
        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCompras form = new FormCompras();
            Usuario user = u.Ler(txNome.Text);
            form.tx.Text = user.Nome;
            form.ShowDialog();
            this.Show();
        }

        private void btUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formUsuario().ShowDialog();
            this.Show();
        }

        private void menuHistCompras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formHistoricoCompras().ShowDialog();
            this.Show();
        }

        private void menuHistVendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormHistoricoVendas().ShowDialog();
            this.Show();
        }

        private void menuRelCompras_Click(object sender, EventArgs e)
        {
            CV.FormDataRelatorio form = new CV.FormDataRelatorio();
            form.tipoRelatorio = 1;
            form.Show();
        }

        private void menuRelVendas_Click(object sender, EventArgs e)
        {
            CV.FormDataRelatorio form = new CV.FormDataRelatorio();
            form.tipoRelatorio = 2;
            form.Show();
        }

        private void menuRelEstoque_Click(object sender, EventArgs e)
        {
            Usuario usuario = u.Ler(txNome.Text);
            FormRelatorios form = new FormRelatorios(usuario.Nome);
            form.tipoRelatorio = 3;
            form.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserRelatorio form = new FormUserRelatorio();
            FormRelatorios relatorio = new FormRelatorios();
            relatorio.tipoRelatorio = 4;
            form.Show();
        }
    }
}
