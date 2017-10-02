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
            IDatabase db = new Database();
            List<Fornecedor> ps = db.ListAllF();            
            
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
            }
            else
            {
                btDel.Enabled = true;
                btEdit.Enabled = true;
                btView.Enabled = true;
            }
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            formCadastroForn form = new formCadastroForn();
            IDatabase db = new Database();
            idFornecedor = db.GetIdFornecedor();
            form.lbIdForn.Text = "" + idFornecedor;

            form.ShowDialog(this);
            Fill();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            Database data = new Database();
            Fornecedor a = new Fornecedor();
            a.Id =  int.Parse(dgvFornecedor.Rows[dgvFornecedor.CurrentRow.Index].Cells[0].Value.ToString());
            //Caixa de aviso caso deseja ou não apagar
            DialogResult result = MessageBox.Show("Tem certeza que deseja remover esse fornecedor da sua lista?",
                "Aviso!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Caso clique em sim
            if (result == DialogResult.Yes)
            {
                data.Remover(a);
                Fill();
                buttonEnable();
            }
            else if (result == DialogResult.No)
            {

            }
            Fill();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            IDatabase db = new Database();
            List<Fornecedor> fornecedor = db.ListAllF();
                        

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

        private void btView_Click(object sender, EventArgs e)
        {
            IDatabase db = new Database();
            List<Fornecedor> fornecedor = db.ListAllF();
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
            Fill();
        }

        private void txPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            IDatabase db = new Database();
            List<Fornecedor> ps = db.ListByNameF(txPesquisar.Text);

            dgvFornecedor.Rows.Clear();
            foreach (Fornecedor p in ps)
            {
                dgvFornecedor.Rows.Add(p.Id, p.Nome, p.Cnpj);
            }
        }
    }
}
