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
        private DAO.UsuarioDao u = new DAO.UsuarioDao();
        private Usuario user = new Usuario();        

        public formMenu()
        {
            InitializeComponent();            
        }

        public formMenu(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
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
            FormVender form = new FormVender(user);
            form.lbVendedor.Text = user.Nome;
            form.ShowDialog();

            this.Show();
        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCompras form = new FormCompras(user);
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
            CV.FormDataRelatorio form = new CV.FormDataRelatorio(user);
            form.tipoRelatorio = 1;
            form.Show();
        }

        private void estoqueMinimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios(user.Nome);
            form.tipoRelatorio = 3;
            form.Show();
        }

        private void porFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserRelatorio form = new FormUserRelatorio(user);
            form.Show();
        }

        private void porPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CV.FormDataRelatorio form = new CV.FormDataRelatorio(user);
            form.tipoRelatorio = 2;
            form.Show();
        }

        private void inventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
