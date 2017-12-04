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
    public partial class FormCompras : Form
    {

        Usuario user = new Usuario();

        public FormCompras()
        {
            InitializeComponent();
            FillComprasAguardando();
            FillUltimasCompras();
            buttonEnable();
        }

        public FormCompras(Usuario u)
        {
            InitializeComponent();
            FillComprasAguardando();
            FillUltimasCompras();
            user = u;
            buttonEnable();
        }

        private void FillComprasAguardando()
        {
            IDao db = new ComprarDao();
            List<object> compras = db.ListAll();
            int i = 0;
            dgvComprasAguardando.Rows.Clear();
            foreach (Comprar c in compras)
            {
                if (c.Status == 0)
                {
                    dgvComprasAguardando.Rows.Add(c.Id, c.Nome_usuario, c.DataCompra, c.DataEntrega, c.Valor, "Pendente");
                    i++;
                    if (DateTime.Compare(c.DataEntrega, DateTime.Now) <= 0)
                    {
                        //dgvComprasAguardando.CurrentRow.DefaultCellStyle.ForeColor = Color.Red;
                        dgvComprasAguardando.Rows[i - 1].DefaultCellStyle.ForeColor = Color.Yellow;
                        dgvComprasAguardando.Rows[i - 1].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            dgvComprasAguardando.Sort(colDataEntrega, ListSortDirection.Ascending);
        }

        private void FillUltimasCompras()
        {
            ComprarDao db = new ComprarDao();
            List<object> compras = db.ListUltimasCompras();

            dgvUltimasCompras.Rows.Clear();
            foreach (Comprar c in compras)
            {
                c.DataCompra = DateTime.Parse(c.DataCompra.ToString("dd/MM/yyyy"));
                dgvUltimasCompras.Rows.Add(c.Id, c.DataCompra, c.DataFinal);
            }
        }

        private void novaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAgendarCompra form = new FormAgendarCompra(user);
            form.lbUser.Text = user.Nome;
            form.ShowDialog();
            FillComprasAguardando();
            FillUltimasCompras();
            buttonEnable();
            this.Show();

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja finalizar esta compra? Seu status será atualizado para 'Entregue'.",
             "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Caso clique em sim
            if (result == DialogResult.Yes)
            {
                ComprarDao db = new ComprarDao();
                List<object> produtos = db.ListProdutos(int.Parse(dgvComprasAguardando.Rows[dgvComprasAguardando.CurrentRow.Index].Cells[0].Value.ToString()));
                Comprar c = new Comprar();
                c.Id = int.Parse(dgvComprasAguardando.Rows[dgvComprasAguardando.CurrentRow.Index].Cells[0].Value.ToString());

                    foreach (Produto p in produtos)
                    {
                        c.Itens.Add(p);
                    }

                db.Atualizar(c);

            }
            else if (result == DialogResult.No)
            {

            }
            FillComprasAguardando();
            FillUltimasCompras();
            buttonEnable();
        }

        private void buttonEnable()
        {

            if (dgvComprasAguardando.RowCount == 0)
            {
                btFinalizar.Enabled = false;
            }
            else
            {
                btFinalizar.Enabled = true;
            }
        }

        private void dgvComprasAguardando_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            detalhes();
        }

        private void detalhes()
        {
            CV.formHistoricoComprasView form = new CV.formHistoricoComprasView();
            //Enviando informacões para os labels e bottons.
            form.txId.Text = (dgvComprasAguardando.Rows[dgvComprasAguardando.CurrentRow.Index].Cells[0].Value.ToString());
            form.txUser.Text = (dgvComprasAguardando.Rows[dgvComprasAguardando.CurrentRow.Index].Cells[1].Value.ToString());
            form.txValor.Text = Convert.ToDouble(dgvComprasAguardando.Rows[dgvComprasAguardando.CurrentRow.Index].Cells[4].Value.ToString()).ToString("C");
            if (dgvComprasAguardando.Rows[dgvComprasAguardando.CurrentRow.Index].Cells[5].Value.ToString() == "Pendente")
            {
                form.txDataRecebido.Text = (dgvComprasAguardando.Rows[dgvComprasAguardando.CurrentRow.Index].Cells[5].Value.ToString());
            }
            else
            {
                form.txDataRecebido.Text = (dgvComprasAguardando.Rows[dgvComprasAguardando.CurrentRow.Index].Cells[6].Value.ToString());
            }


            ComprarDao db = new ComprarDao();
            List<Object> ps = db.ListProdutos(int.Parse(dgvComprasAguardando.Rows[dgvComprasAguardando.CurrentRow.Index].Cells[0].Value.ToString()));

            form.dgvProdutos.Rows.Clear();
            foreach (Produto p in ps)
            {
                form.dgvProdutos.Rows.Add(p.Id, p.Nome, p.Preco.ToString("C"), p.Qntd, p.TipoUn, p.Fornecedor.Nome);
            }

            form.ShowDialog(this);
        }
    }
}
