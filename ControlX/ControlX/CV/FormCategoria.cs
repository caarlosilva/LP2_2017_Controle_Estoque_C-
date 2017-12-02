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
    public partial class FormCategoria : Form
    {
        private int idCategoria;
        public FormCategoria()
        {
            InitializeComponent();
            Fill();
        }
        private void Fill()
        {
            IDao db = new DAO.CategoriaDao();
            List<Object> ps = db.ListAll();

            dgvCategoria.Rows.Clear();
            foreach (Modelo.Categoria c in ps)
            {
                dgvCategoria.Rows.Add(c.Id, c.Nome);
            }

            buttonEnable();
        }

        private void buttonEnable()
        {

            if (dgvCategoria.RowCount == 0)
            {
                btDel.Enabled = false;
                btEdit.Enabled = false;
                removerToolStripMenuItem.Enabled = false;
                editarToolStripMenuItem.Enabled = false;
            }
            else
            {
                btDel.Enabled = true;
                btEdit.Enabled = true;
                removerToolStripMenuItem.Enabled = true;
                editarToolStripMenuItem.Enabled = true;
            }
        }

        private void txPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            IDao db = new DAO.CategoriaDao();
            List<Object> ps = (rbNome.Checked) ? db.ListByName(txPesquisar.Text) : (txPesquisar.Text.Trim() == "") ? db.ListAll() : db.ListById(int.Parse(txPesquisar.Text));

            dgvCategoria.Rows.Clear();
            foreach (Modelo.Categoria c in ps)
            {
                dgvCategoria.Rows.Add(c.Id, c.Nome);
            }
        }

        private void txPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && rbId.Checked)
                e.Handled = true;
            if (e.KeyChar == '\'')
                e.Handled = true;
        }

        private void btEstoque_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formEstoque().ShowDialog();
            this.Show();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormCadastroCat form = new FormCadastroCat();
            IDao db = new DAO.CategoriaDao();
            idCategoria = db.GetId();
            form.lbIdCategoria.Text = "" + idCategoria;

            form.ShowDialog(this);
            Fill();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            IDao data = new DAO.CategoriaDao();
            Modelo.Categoria a = new Modelo.Categoria();
            a.Id = int.Parse(dgvCategoria.Rows[dgvCategoria.CurrentRow.Index].Cells[0].Value.ToString());
            //Caixa de aviso caso deseja ou não apagar
            DialogResult result = MessageBox.Show("Tem certeza que deseja remover esta categoria?",
                "Aviso!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Caso clique em sim
            if (result == DialogResult.Yes)
            {
                int aux = data.Remover(a.Id);
                Fill();
                if (aux == 1)
                {
                    MessageBox.Show("Existem produtos registrados com esta categoria. Remova-os primeiro.",
                    "Aviso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Categoria removida com sucesso.",
                    "Aviso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                buttonEnable();
            }
            else if (result == DialogResult.No)
            {

            }
            Fill();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            IDao db = new DAO.CategoriaDao();
            List<Object> categoria = db.ListAll();


            FormCadastroCat form = new FormCadastroCat();
            int id = int.Parse(dgvCategoria.Rows[dgvCategoria.CurrentRow.Index].Cells[0].Value.ToString());
            form.lbIdCategoria.Text = Convert.ToString(id);

            foreach (Modelo.Categoria c in categoria)
            {
                if (c.Id == id)
                {
                    form.txNome.Text = c.Nome;
                }
            }
            form.btCadastrar.Text = "Salvar";
            form.ShowDialog(this);
            Fill();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new formEstoque().ShowDialog();
            this.Show();
            Fill();

        }
    }
}
