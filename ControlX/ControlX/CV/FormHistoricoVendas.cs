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
        }

        public void Fill()
        {
            VenderDao db = new VenderDao();
            List<Object> ps = db.ListAll();

            dgvHistVendas.Rows.Clear();
            foreach (Vender v in ps)
            {
                dgvHistVendas.Rows.Add(v.Id, v.Nome_usuario, v.Valor, v.Data);
            }
            buttonEnable();
        }

        private void buttonEnable()
        {

            if (dgvHistVendas.RowCount == 0)
            {
                btView.Enabled = false;
            }
            else
            {
                btView.Enabled = true;
            }
        }

        private void btView_Click(object sender, EventArgs e)
        {
            FormHistoricoVendasView form = new FormHistoricoVendasView();
            //Enviando informacões para os labels e bottons.
            form.txId.Text = (dgvHistVendas.Rows[dgvHistVendas.CurrentRow.Index].Cells[0].Value.ToString());
            form.txUser.Text = (dgvHistVendas.Rows[dgvHistVendas.CurrentRow.Index].Cells[1].Value.ToString());
            form.txValor.Text = Convert.ToDouble(dgvHistVendas.Rows[dgvHistVendas.CurrentRow.Index].Cells[2].Value.ToString()).ToString("C");

            VenderDao db = new VenderDao();
            List<Object> ps = db.ListProdutos(int.Parse(dgvHistVendas.Rows[dgvHistVendas.CurrentRow.Index].Cells[0].Value.ToString()));

            form.dgvProdutos.Rows.Clear();
            foreach (Produto p in ps)
            {
                form.dgvProdutos.Rows.Add(p.Id, p.Nome, p.Preco, p.Qntd, p.TipoUn, p.Fornecedor.Nome);
            }

            form.ShowDialog(this);
        }
    }
}
