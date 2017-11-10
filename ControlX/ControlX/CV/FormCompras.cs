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
        public FormCompras()
        {
            InitializeComponent();
            FillComprasAguardando();
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
                    dgvComprasAguardando.Rows.Add(c.Id, c.DataCompra, c.DataEntrega);
                    i++;
                    if(DateTime.Compare(c.DataEntrega ,DateTime.Now) <= 0)
                    {
                        //dgvComprasAguardando.CurrentRow.DefaultCellStyle.ForeColor = Color.Red;
                        dgvComprasAguardando.Rows[i - 1].DefaultCellStyle.ForeColor = Color.Yellow;
                        dgvComprasAguardando.Rows[i - 1].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            dgvComprasAguardando.Sort(colDataEntrega, ListSortDirection.Ascending);
        }

        private void novaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAgendarCompra().ShowDialog();
            FillComprasAguardando();
            this.Show();

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
