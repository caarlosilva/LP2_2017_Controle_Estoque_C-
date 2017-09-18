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
        public formFornecedores()
        {
            InitializeComponent();
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new formMenu().ShowDialog();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            new formCadastroForn().ShowDialog(this);
            //Fill();
        }
    }
}
