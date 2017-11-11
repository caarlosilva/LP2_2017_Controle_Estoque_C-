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
            Fill();

        }

        private void Fill()
        {
                ComprarDao db = new ComprarDao();
                List<Object> ps = db.ListAll();
                string status;

                dgvHistCompras.Rows.Clear();
                foreach (Comprar p in ps)
                {
                   if (p.Status == 0)
                   {
                       status = "Pendente";
                   }
                   else
                   {
                       status = "Entregue";
                   }
                   dgvHistCompras.Rows.Add(p.Id, p.Nome_usuario, p.Valor, status);
                }
            buttonEnable();
        }

        private void buttonEnable()
        {

            if (dgvHistCompras.RowCount == 0)
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
            CV.FormHistoricoComprasView form = new CV.FormHistoricoComprasView();
            //Enviando informacões para os labels e bottons.
            form.txId.Text = (dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[0].Value.ToString());
            form.txUser.Text = (dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[1].Value.ToString());
            form.txValor.Text = Convert.ToDouble(dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[2].Value.ToString()).ToString("C");
            form.txStatus.Text = (dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[3].Value.ToString());

            ComprarDao db = new ComprarDao();
            List<Object> ps = db.ListProdutos(int.Parse(dgvHistCompras.Rows[dgvHistCompras.CurrentRow.Index].Cells[0].Value.ToString()));

            form.dgvProdutos.Rows.Clear();
            foreach (Produto p in ps)
            {
                form.dgvProdutos.Rows.Add(p.Id, p.Nome, p.Preco, p.Qntd, p.TipoUn, p.Fornecedor.Nome);
            }

            form.ShowDialog(this);
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
