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
    public partial class formVender : Form
    {
        public formVender()
        {
            InitializeComponent();
            Auto_Complete();
        }

        private void Auto_Complete()
        {
            txNome.AutoCompleteMode = AutoCompleteMode.Suggest;
            txNome.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            IDao db = new DAO.ProdutoDao();
            List<Object> ps = db.ListAll();
            
            foreach (Produto p in ps)
            {
                col.Add(p.Nome);
            }

            txNome.AutoCompleteCustomSource = col;
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txNome.Text = "";
            txId.Text = "";
            txPreco.Text = "";
            txQntd.Text = "";
        }

        private void txNome_TextChanged(object sender, EventArgs e)
        {
            IDao db = new DAO.ProdutoDao();
            List<Object> produto = db.ListByName(txNome.Text.Trim());

            foreach (Produto p in produto)
                if (txNome.Text.Trim() == p.Nome)
                {
                    txId.Text = Convert.ToString(p.Id);
                    txPreco.Text = Convert.ToString(p.Preco);
                    txQntd.Text = Convert.ToString(p.Qntd);
                }
            
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {

            formEstoque formSearch = new formEstoque();
            /*formSearch.btView.Enabled = false;
            formSearch.btDel.Enabled = false;
            formSearch.btEdit.Enabled = false;
            */
            formSearch.pnButtons.Visible = false;
            //formSearch.pnPesquisa.Visible = false;
            formSearch.btMenu.Text = "Voltar";
            formSearch.ShowDialog(this);

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void pnForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
