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
    public partial class MenuFunc : Form
    {
        public MenuFunc()
        {
            InitializeComponent();
        }

        private void btControleEstoq_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            new Login().Show();
        }
    }
}
