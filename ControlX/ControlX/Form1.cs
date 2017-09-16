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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bottonEnable();
            Fill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new formCadastroProd().ShowDialog(this);
            Fill();
            bottonEnable();
        }

        private void Fill()
        {
            IDatabase db = new Database();
            List<Produto> ps = db.ListAll();

            dgvEstoque.Rows.Clear();
            foreach (Produto p in ps)
            {
                dgvEstoque.Rows.Add(p.Id, p.Nome, p.Preco, p.Qntd);
            }
        
        
        }

        private void bottonEnable()
        {
            if (dgvEstoque.CurrentCell == null)
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
                 
            IDatabase db = new Database();
            List<Produto> ps = db.ListByName(txPesquisar.Text);

            dgvEstoque.Rows.Clear();
            foreach (Produto p in ps)
            {
                dgvEstoque.Rows.Add(p.Id, p.Nome, p.Preco, p.Qntd);
            }

        }

        private void btDel_Click(object sender, EventArgs e)
        {

            Database data = new Database();
            int a = int.Parse(dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[0].Value.ToString());
            data.Remover(a);
            Fill();
            bottonEnable();
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
            form.btCadastrar.Text = "Salvar";
            form.ShowDialog(this);
            Fill();
        }

        private void btView_Click(object sender, EventArgs e)
        {
            formCadastroProd form = new formCadastroProd();
            //Os text não pode ser editado.
            form.txNome.ReadOnly = true;
            form.txPreco.ReadOnly = true;
            form.txQntd.ReadOnly = true;
            //Enviando informacao para os label e botton.
            form.txNome.Text = (dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[1].Value.ToString());
            form.txPreco.Text = (dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[2].Value.ToString());
            form.txQntd.Text = (dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[3].Value.ToString());
            form.lbIdProduto.Text = (dgvEstoque.Rows[dgvEstoque.CurrentRow.Index].Cells[0].Value.ToString());
            //Deixa o botão Cadastrar oculto.
            form.btCadastrar.Hide();
            //Modifica o texto do botão Cancelar.
            form.btCancelar.Text = "Voltar";
            form.ShowDialog(this);
            Fill();
        }

        private void btMenuPrincipal_Click(object sender, EventArgs e)
        {
            new MenuAdmin().Show();
            this.Dispose();
        }
    }
}
