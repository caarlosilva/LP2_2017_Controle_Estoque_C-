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
    public partial class formFornecedores : Form
    {

        private int idFornecedor;
        public formFornecedores()
        {
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            IDao db = new DAO.FornecedorDao();
            List<Object> ps = db.ListAll();            
            
            dgvFornecedor.Rows.Clear();
            foreach (Fornecedor p in ps)
            {
                dgvFornecedor.Rows.Add(p.Id, p.Nome, p.Cnpj, p.Cidade + " - " + p.Estado);
            }

            buttonEnable();
        }

        public static IEnumerable<Control> GetAllControls(Control root)
        {
            var stack = new Stack<Control>();
            stack.Push(root);

            while (stack.Any())
            {
                var next = stack.Pop();
                foreach (Control child in next.Controls)
                    stack.Push(child);

                yield return next;
            }
        }

        private void buttonEnable()
        {

            if (dgvFornecedor.RowCount == 0)
            {
                btDel.Enabled = false;
                btEdit.Enabled = false;
                btView.Enabled = false;

                removerToolStripMenuItem.Enabled = false;
                editarToolStripMenuItem.Enabled = false;
                detalhesToolStripMenuItem.Enabled = false;
            }
            else
            {
                btDel.Enabled = true;
                btEdit.Enabled = true;
                btView.Enabled = true;

                removerToolStripMenuItem.Enabled = true;
                editarToolStripMenuItem.Enabled = true;
                detalhesToolStripMenuItem.Enabled = true;
            }
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            formCadastroForn form = new formCadastroForn();
            IDao db = new DAO.FornecedorDao();
            idFornecedor = db.GetId();
            form.lbIdForn.Text = "" + idFornecedor;

            form.ShowDialog(this);
            Fill();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            IDao data = new DAO.FornecedorDao();
            Fornecedor a = new Fornecedor();
            a.Id =  int.Parse(dgvFornecedor.Rows[dgvFornecedor.CurrentRow.Index].Cells[0].Value.ToString());
            //Caixa de aviso caso deseja ou não apagar
            DialogResult result = MessageBox.Show("Tem certeza que deseja remover este fornecedor?",
                "Aviso!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Caso clique em sim
            if (result == DialogResult.Yes)
            {
                int aux = data.Remover(a.Id);
                Fill();
                if (aux == 1)
                    {
                        MessageBox.Show("Existem produtos registrados com este fornecedor. Remova-os primeiro.",
                        "Aviso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor removido com sucesso.",
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
            IDao db = new DAO.FornecedorDao();
            List<Object> fornecedor = db.ListAll();
                        

            formCadastroForn form = new formCadastroForn();
            int id = int.Parse(dgvFornecedor.Rows[dgvFornecedor.CurrentRow.Index].Cells[0].Value.ToString());
            form.lbIdForn.Text = Convert.ToString(id);
            
            foreach(Fornecedor f in fornecedor)
            {
                if(f.Id == id)
                {
                    form.txNome.Text = f.Nome;
                    form.txBairro.Text = f.Bairro;
                    form.txRua.Text = f.Rua;
                    form.txNum.Text = Convert.ToString(f.Num);
                    form.txCidade.Text = f.Cidade;
                    form.txCEP.Text = Convert.ToString(f.Cep);
                    form.txCNPJ.Text = Convert.ToString(f.Cnpj);
                    form.txTel1.Text = Convert.ToString(f.Telefone1);
                    form.txTel2.Text = Convert.ToString(f.Telefone2);
                    form.txEstado.Text = f.Estado;
                    form.txCompl.Text = f.Comp;
                }
            }
            form.btCadastrar.Text = "Salvar";
            form.ShowDialog(this);
            Fill();
        }


        private void detalhes()
        {
            IDao db = new DAO.FornecedorDao();
            List<Object> fornecedor = db.ListAll();
            formCadastroForn form = new formCadastroForn();

            int id = int.Parse(dgvFornecedor.Rows[dgvFornecedor.CurrentRow.Index].Cells[0].Value.ToString());
            form.lbIdForn.Text = Convert.ToString(id);

            foreach (TextBox textbox in form.pnCadForn.Controls.OfType<TextBox>())
            {
                textbox.ReadOnly = true;
            }

            foreach (MaskedTextBox textbox in form.pnCadForn.Controls.OfType<MaskedTextBox>())
            {
                textbox.ReadOnly = true;
            }

            foreach (Fornecedor f in fornecedor)
            {
                if (f.Id == id)
                {
                    form.txNome.Text = f.Nome;
                    form.txBairro.Text = f.Bairro;
                    form.txRua.Text = f.Rua;
                    form.txNum.Text = Convert.ToString(f.Num);
                    form.txCidade.Text = f.Cidade;
                    form.txCEP.Text = Convert.ToString(f.Cep);
                    form.txCNPJ.Text = Convert.ToString(f.Cnpj);
                    form.txTel1.Text = Convert.ToString(f.Telefone1);
                    form.txTel2.Text = Convert.ToString(f.Telefone2);
                    form.txEstado.Text = f.Estado;
                    form.txCompl.Text = f.Comp;
                }
            }
            form.btCadastrar.Enabled = false;
            form.btCancelar.Text = "Voltar";
            form.ShowDialog(this);
        }


        private void btView_Click(object sender, EventArgs e)
        {
            detalhes();
        }

        private void txPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            IDao db = new DAO.FornecedorDao();
            List<Object> ps = db.ListByName(txPesquisar.Text);

            dgvFornecedor.Rows.Clear();
            foreach (Fornecedor p in ps)
            {
                dgvFornecedor.Rows.Add(p.Id, p.Nome, p.Cnpj, p.Cidade + "-" + p.Estado);
            }
        }

        private void dgvFornecedor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            detalhes();
        }
    }
}
