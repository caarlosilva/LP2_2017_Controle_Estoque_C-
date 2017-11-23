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
        public formHistoricoCompras()
        {
            InitializeComponent();
            buttonEnable();
            ChecaFiltros();
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
            CV.FormHistoricoComprasView form = new CV.FormHistoricoComprasView();
            //Enviando informacões para os labels e bottons.
            form.txId.Text = (dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[0].Value.ToString());
            form.txUser.Text = (dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[1].Value.ToString());
            form.txValor.Text = Convert.ToDouble(dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[4].Value.ToString()).ToString("C");
            form.txStatus.Text = (dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[5].Value.ToString());

            ComprarDao db = new ComprarDao();
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
            if (rbDataEntrega.Checked)
            {
                dtInicio.Enabled = true;
                txPesquisar.Enabled = false;
            }
            else if (rbId.Checked)
            {
                dtInicio.Enabled = false;
                txPesquisar.Enabled = true;
            }
        }

        private void dgvHistCompras_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            detalhes();
        }
    }
}
