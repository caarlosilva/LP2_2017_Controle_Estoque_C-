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
        }

        public FormCompras(Usuario u)
        {
            InitializeComponent();
            FillComprasAguardando();
            user = u;
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

        private void novaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAgendarCompra form = new FormAgendarCompra(user);
            form.lbUser.Text = user.Nome;
            form.ShowDialog();
            FillComprasAguardando();
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
        }
    }
}
