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
        private static Dictionary<int, Fornecedor> fornecedor = new Dictionary<int, Fornecedor>();

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
                dgvFornecedor.Rows.Add(p.Id, p.Nome, p.Cnpj);
            }

            buttonEnable();
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
            new formCadastroForn().ShowDialog(this);            
            Fill();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            Database data = new Database();
            Fornecedor a = new Fornecedor();
            a.Id =  int.Parse(dgvFornecedor.Rows[dgvFornecedor.CurrentRow.Index].Cells[0].Value.ToString());
            //Caixa de aviso caso deseja ou não apagar
            DialogResult result = MessageBox.Show("Tem certeza que deseja remover esse item do seu estoque?",
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
            formCadastroForn form = new formCadastroForn();
            int id = int.Parse(dgvFornecedor.Rows[dgvFornecedor.CurrentRow.Index].Cells[0].Value.ToString());
            form.lbIdForn.Text = Convert.ToString(fornecedor[id].Id);
            form.txNome.Text = fornecedor[id].Nome;
            form.txBairro.Text = fornecedor[id].Bairro;
            form.txRua.Text = fornecedor[id].Rua;
            form.txNum.Text = Convert.ToString(fornecedor[id].Num);
            form.txCidade.Text = fornecedor[id].Cidade;
            form.txCEP.Text = Convert.ToString(fornecedor[id].Cep);
            form.txCNPJ.Text = Convert.ToString(fornecedor[id].Cnpj);
            form.txTel1.Text = Convert.ToString(fornecedor[id].Telefone1);
            form.txTel2.Text = Convert.ToString(fornecedor[id].Telefone2);
            form.txEstado.Text = fornecedor[id].Estado;
            form.txCompl.Text = fornecedor[id].Comp;
            form.btCadastrar.Text = "Salvar";//Não esta funcionando
            form.btCadastrar.Enabled = false;
            form.ShowDialog(this);
        }
    }
}
