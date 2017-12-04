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
    public partial class formHistoricoCompras : Form
    {
        Comprar compra = new Comprar();
        public formHistoricoCompras()
        {
            InitializeComponent();
            buttonEnable();
            ChecaFiltros();
            dtInicio.MaxDate = DateTime.Now;
            dtFim.MaxDate = DateTime.Now;
            Fill();

        }

        private void Fill()
        {
                ComprarDao db = new ComprarDao();
                List<Object> ps = db.ListAll();
                string status;

                dgvHistCompras.Rows.Clear();
                foreach (Comprar c in ps)
                {
                   if (c.Status == 0)
                   {
                        status = "Pendente";
                   }
                   else
                   {
                        status = "Entregue";
                   }
                string dataCompra = c.DataCompra.ToString("dd-MM-yyyy");
                string dataEntrega = c.DataEntrega.ToString("dd-MM-yyyy");
                dgvHistCompras.Rows.Add(c.Id, c.Nome_usuario, dataCompra, dataEntrega, c.Valor, status);
                }
            buttonEnable();
        }

        private void buttonEnable()
        {

            if (dgvHistCompras.RowCount == 0)
            {
                detalhesToolStripMenuItem.Enabled = false;
            }
            else
            {
                detalhesToolStripMenuItem.Enabled = true;
            }
        }

        private void detalhes()
        {
            CV.formHistoricoComprasView form = new CV.formHistoricoComprasView();
            //Enviando informacões para os labels e bottons.
            int id = int.Parse((dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[0].Value.ToString()));
            ComprarDao db = new ComprarDao();
            compra = db.Ler(id);

            form.dateCompra.Text = compra.DataCompra.ToString("dd-MM-yyyy");
            form.dateEntrega.Text = compra.DataEntrega.ToString("dd-MM-yyyy");
            form.txId.Text = (dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[0].Value.ToString());
            form.txUser.Text = (dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[1].Value.ToString());
            form.txValor.Text = Convert.ToDouble(dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[4].Value.ToString()).ToString("C");
            if (dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[5].Value.ToString() == "Pendente")
            {
                form.txDataRecebido.Text = "Pendente";//(dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[5].Value.ToString());
            }
            else
            {          
                form.txDataRecebido.Text = compra.DataFinal.ToString("dd/MM/yyyy hh:mm");
            }


            
            List<Object> ps = db.ListProdutos(int.Parse(dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[0].Value.ToString()));

            form.dgvProdutos.Rows.Clear();
            foreach (Produto p in ps)
            {
                form.dgvProdutos.Rows.Add(p.Id, p.Nome, p.Preco.ToString("C"), p.Qntd, p.TipoUn, p.Fornecedor.Nome);
            }

            form.ShowDialog(this);
        }
        private void btView_Click(object sender, EventArgs e)
        {
            detalhes();
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbDataEntrega_CheckedChanged(object sender, EventArgs e)
        {
            ChecaFiltros();
        }

        private void ChecaFiltros()
        {
            if (rbDataCompra.Checked)
            {
                dtInicio.Enabled = true;
                dtFim.Enabled = true;
                txPesquisar.Enabled = false;
            }
            else if (rbId.Checked)
            {
                dtInicio.Enabled = false;
                dtFim.Enabled = false;
                txPesquisar.Enabled = true;
            }
        }

        private void dgvHistCompras_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            detalhes();
        }

        private void txPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == '\'')
                e.Handled = true;
        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            txPesquisar.Text = "";
            Fill();
        }

        private void txPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            pesquisaFiltro();       
        }
        private void pesquisaFiltro()
        {

            ComprarDao db = new ComprarDao();
            string status;
            List<Object> cs = (rbDataCompra.Checked) ? db.ListByDate(dtInicio.Value, dtFim.Value) : (txPesquisar.Text.Trim() == "") ? db.ListAll() : db.ListById(int.Parse(txPesquisar.Text));

            dgvHistCompras.Rows.Clear();
            foreach (Comprar c in cs)
            {
                if (c.Status == 0)
                {
                    status = "Pendente";
                }
                else
                {
                    status = "Entregue";
                }
                string dataCompra = c.DataCompra.ToString("dd-MM-yyyy");
                string dataEntrega = c.DataEntrega.ToString("dd-MM-yyyy");
                dgvHistCompras.Rows.Add(c.Id, c.Nome_usuario, dataCompra, dataEntrega, c.Valor, status);
            }

        }

        private void dtFim_ValueChanged(object sender, EventArgs e)
        {
            pesquisaFiltro();
        }
    }
}
