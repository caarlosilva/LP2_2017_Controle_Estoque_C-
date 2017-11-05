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
    public partial class formEstoque : Form
    {
        //private static Dictionary<int, Produto> produtos = new Dictionary<int, Produto>();
        private int idProduto;

        public formEstoque()
        {
            InitializeComponent();
            Fill();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            formCadastroProd form = new formCadastroProd();
            IDao db = new DAO.ProdutoDao();
            idProduto = db.GetId();
            form.lbIdProduto.Text = "" + idProduto;

            form.ShowDialog(this);
            Fill();
        }

        private void Fill()
        {
            IDao db = new DAO.ProdutoDao();
            List<Object> ps = db.ListAll();

            dgvEstoque.Rows.Clear();
            foreach (Produto p in ps)
            {
                dgvEstoque.Rows.Add(p.Id, p.Nome, p.Preco, p.Qntd, p.Cat.Nome);
            }

            buttonEnable();
        }

        private void buttonEnable()
        {

            if (dgvEstoque.RowCount == 0)
            {
                btDel.Enabled = false;
                btEdit.Enabled = false;
                btView.Enabled = false;
            }
            else
            {
                btDel.Enabled = true;
                btEdit.Enabled = true;
                btView.Enabled = true;
            }
        }

        private void txPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            DAO.ProdutoDao db = new DAO.ProdutoDao();

                List<Object> ps = (rbNome.Checked) ? db.ListByName(txPesquisar.Text) : (txPesquisar.Text.Trim() == "") ? db.ListAll() : db.ListById(int.Parse(txPesquisar.Text));

                dgvEstoque.Rows.Clear();
                foreach (Produto p in ps)
                {
                    dgvEstoque.Rows.Add(p.Id, p.Nome, p.Preco, p.Qntd, p.Cat.Nome);
                }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            IDao data = new DAO.ProdutoDao();
            int a = int.Parse(dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[0].Value.ToString());
            //Caixa de aviso caso deseja ou não apagar
            DialogResult result = MessageBox.Show("Tem certeza que deseja remover esse item do seu estoque?",
                "Aviso!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Caso clique em sim
            if (result == DialogResult.Yes)
            {
                data.Remover(a);
                Fill();
                MessageBox.Show("Item removido com sucesso.",
                "Aviso!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                buttonEnable();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[1].Value.ToString()
            //Rows linha selecionada.
            //dgvEstoque.CurrentRow.Index pega o numero da linha que foi selecionada.
            //Cells[x] celula da coluna. ex colId Cell[0] pq é a primeira celula e coluna.
            //Value.ToString() para pegar o valor da celular usar o tostring.

            formCadastroProd form = new formCadastroProd();
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
                form.cbCategoria.SelectedValue = produto.Cat.Id;
            }

            form.btCadastrar.Text = "Salvar";
            form.ShowDialog(this);
            Fill();
        }

        private void btView_Click(object sender, EventArgs e)
        {
            formCadastroProd form = new formCadastroProd();
            //Os texts não podem ser editado.
            form.txNome.ReadOnly = true;
            form.txPreco.ReadOnly = true;
            form.txQntd.ReadOnly = true;
            form.cbFornecedor.Enabled = false;
            form.cbCategoria.Enabled = false;
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
                form.cbCategoria.SelectedValue = produto.Cat.Id;
            }

            //form.cbFornecedor.DataSource = p;
            //form.cbFornecedor.DisplayMember = "FornecedorFullName";
            //form.cbFornecedor.ValueMember = "Id";


            //Deixa o botão Cadastrar oculto.
            form.btCadastrar.Enabled = false;
            //Modifica o texto do botão Cancelar.
            form.btCancelar.Text = "Voltar";
            form.ShowDialog(this);
            Fill();
        }

        private void btMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && rbId.Checked)
                e.Handled = true;
        }

        private void btCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormCategoria().ShowDialog();
            this.Show();
        }
    }
}
