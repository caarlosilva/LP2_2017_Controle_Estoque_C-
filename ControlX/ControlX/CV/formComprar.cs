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
    public partial class formComprarProd : Form
    {
        public formComprarProd()
        {
            InitializeComponent();
            Fill();
        }

        private void buttonEnable()
        {

            if (dgvEstoque.RowCount == 0)
            {
                btComprar.Enabled = false;
            }
            else
            {
                btComprar.Enabled = true;
            }
        }

        private void txPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            IDao db = new DAO.ProdutoDao();
            List<Object> ps = (rbNome.Checked) ? db.ListByName(txPesquisar.Text) : (txPesquisar.Text.Trim() == "") ? db.ListAll() : db.ListById(int.Parse(txPesquisar.Text));

            dgvEstoque.Rows.Clear();
            foreach (Produto p in ps)
            {
                dgvEstoque.Rows.Add(p.Id, p.Nome, p.Preco, p.Qntd);
            }
        }

        private void Fill()
        {
            IDao db = new DAO.ProdutoDao();
            List<Object> ps = db.ListAll();

            dgvEstoque.Rows.Clear();
            foreach (Produto p in ps)
            {
                dgvEstoque.Rows.Add(p.Id, p.Nome, p.Preco, p.Qntd);
            }

            int countProd = dgvEstoque.RowCount;
            for (int i = 0; i < countProd; i++)
            {
                int Qntd = int.Parse(dgvEstoque.Rows[i].Cells[3].Value.ToString());
                foreach (Produto p in ps)
                {
                    //Alerta em vermelho os produtos com estoque < 20
                    if (Qntd <= 20)
                    {
                        dgvEstoque.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
//                        dgvEstoque.Rows[i].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
                    }
                }
            }

            buttonEnable();
        }

        private void txPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && rbId.Checked)
                e.Handled = true;
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            formEditComprar form = new formEditComprar();
            //Os texts não podem ser editado.
            form.txNome.ReadOnly = true;
            form.txPreco.ReadOnly = true;
            form.txQntd.ReadOnly = true;
            form.cbFornecedor.Enabled = false;
            //Enviando informacões para os labels e bottons.
            form.txNome.Text = (dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[1].Value.ToString());
            form.txPreco.Text = (dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[2].Value.ToString());
            form.txQntd.Text = (dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[3].Value.ToString());
            form.lbIdProduto.Text = (dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[0].Value.ToString());
            int idP = Convert.ToInt32(form.lbIdProduto.Text);
            IDao db = new DAO.ProdutoDao();

            List<Object> p = db.ListById(idP);


            foreach (Produto produto in p)
            {
                form.cbFornecedor.SelectedValue = produto.Fornecedor.Id;
            }
            form.ShowDialog(this);
            Fill();
        }
    }
}
