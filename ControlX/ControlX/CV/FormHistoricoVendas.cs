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
    public partial class FormHistoricoVendas : Form
    {
        public FormHistoricoVendas()
        {
            InitializeComponent();
            Fill();
            checaFiltros();
            dtInicio.MaxDate = DateTime.Now;
            dtFim.MaxDate = DateTime.Now;
        }

        public void Fill()
        {
            VenderDao db = new VenderDao();
            List<Object> ps = db.ListAll();

            dgvHistVendas.Rows.Clear();
            foreach (Vender v in ps)
            {
                string dataVenda = v.Data.ToString("dd-MM-yyyy");
                dgvHistVendas.Rows.Add(v.Id, v.Nome_usuario, v.Valor, dataVenda);
            }
            buttonEnable();
        }

        private void buttonEnable()
        {

            if (dgvHistVendas.RowCount == 0)
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
            FormHistoricoVendasView form = new FormHistoricoVendasView();
            //Enviando informacões para os labels e bottons.
            form.txId.Text = (dgvHistVendas.Rows[dgvHistVendas.CurrentRow.Index].Cells[0].Value.ToString());
            form.txUser.Text = (dgvHistVendas.Rows[dgvHistVendas.CurrentRow.Index].Cells[1].Value.ToString());
            form.txValor.Text = Convert.ToDouble(dgvHistVendas.Rows[dgvHistVendas.CurrentRow.Index].Cells[2].Value.ToString()).ToString("C");
            form.dateVenda.Text = (dgvHistVendas.Rows[dgvHistVendas.CurrentRow.Index].Cells[3].Value.ToString());

            VenderDao db = new VenderDao();
            List<Object> ps = db.ListProdutos(int.Parse(dgvHistVendas.Rows[dgvHistVendas.CurrentRow.Index].Cells[0].Value.ToString()));

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

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvHistVendas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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
            checaFiltros();
        }

        private void checaFiltros()
        {
            if (rbDataVenda.Checked)
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

        private void txPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            pesquisaFiltro();
        }

        private void pesquisaFiltro()
        {
            VenderDao db = new VenderDao();
            List<Object> vs = (rbDataVenda.Checked) ? db.ListByDate(dtInicio.Value, dtFim.Value) : (txPesquisar.Text.Trim() == "") ? db.ListAll() : db.ListById(int.Parse(txPesquisar.Text));

            dgvHistVendas.Rows.Clear();
            foreach (Vender v in vs)
            {
                string dataVenda = v.Data.ToString("dd-MM-yyyy");
                dgvHistVendas.Rows.Add(v.Id, v.Nome_usuario, v.Valor, dataVenda);
            }

        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            pesquisaFiltro();
        }
    }
}
