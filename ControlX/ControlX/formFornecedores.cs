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
            List<Fornecedor> ps = new List<Fornecedor>();//ERRO AQUI
            
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
    }
}
