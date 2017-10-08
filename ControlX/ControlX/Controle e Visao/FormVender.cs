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
    public partial class FormVender : Form
    {
        public FormVender()
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
            
            //Adiciona sugestão de nomes ao digitar no TextBox
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
            lbPrecoShow.Text = "";
            lbQntdEstoqueShow.Text = "";
            txQntdVenda.Text = "";
        }

        private void txNome_TextChanged(object sender, EventArgs e)
        {
            IDao db = new DAO.ProdutoDao();
            List<Object> produto = db.ListByName(txNome.Text.Trim());

            foreach (Produto p in produto)
                if (txNome.Text.Trim() == p.Nome)
                {
                    txId.Text = Convert.ToString(p.Id);
                    lbPrecoShow.Text = Convert.ToString(p.Preco);
                    lbQntdEstoqueShow.Text = Convert.ToString(p.Qntd);
                    txQntdVenda.Text = "0";
                }
            
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {

            formEstoque formSearch = new formEstoque();
            formSearch.pnButtons.Visible = false;
            formSearch.btMenu.Text = "Voltar";
            formSearch.ShowDialog(this);

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {         
            dgvVendas.Rows.Clear();
            lbValorTotal.Text = "";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int qVenda = int.Parse(txQntdVenda.Text); //Quantidade que sera vendida
            int qEstoque = int.Parse(lbQntdEstoqueShow.Text);//Quantidade no estoque

            if (qVenda > qEstoque || qVenda <= 0)
                MessageBox.Show("Impossível vender " + qVenda + " Itens, já que há apenas " + qEstoque + " do mesmo no Estoque !", "Aviso!");
            else
            {
                //Preço da venda (QTD * PREÇO UNITARIO)
                double pVenda = int.Parse(txQntdVenda.Text) * double.Parse(lbPrecoShow.Text);
                //Adicionando ao Data Grid View
                dgvVendas.Rows.Add(txId.Text, txNome.Text, txQntdVenda.Text, pVenda);
                //Valor Total Recebe o valor ja existente, caso esteja NULL, recebe 0
                double vTotal = lbValorTotal.Text ==""? 0 : double.Parse(lbValorTotal.Text);
                //O Label com o Valor Total recebe ele mesmo, mas o Preço de Venda do item em questão
                lbValorTotal.Text = Convert.ToString(vTotal + pVenda);

                txNome.Text = "";
                txId.Text = "";
                lbPrecoShow.Text = "";
                lbQntdEstoqueShow.Text = "";
                txQntdVenda.Text = "";
            }

        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void pnForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btDelItemVenda_Click(object sender, EventArgs e)
        {
            if (dgvVendas.RowCount > 0)
            {
                double pItem = double.Parse(dgvVendas.Rows[dgvVendas.CurrentRow.Index].Cells[3].Value.ToString());
                double vTotal = double.Parse(lbValorTotal.Text);
                lbValorTotal.Text = Convert.ToString(vTotal - pItem);
                dgvVendas.Rows.RemoveAt(dgvVendas.CurrentRow.Index);
            }
        }

        private void txId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txQntdVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
