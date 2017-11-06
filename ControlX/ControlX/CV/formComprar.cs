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
    public partial class formComprarProd : Form
    {

        static IDao db = new DAO.ProdutoDao();
        static List<Object> ps = db.ListAll();

        public formComprarProd()
        {
            InitializeComponent();
            BtComplete();
        }

        private void BtComplete()
        {
            if (dgvItensCompra.RowCount <= 0)
            {
                btDelItemCompra.Enabled = false;
                btRemoverTudo.Enabled = false;
                btComprar.Enabled = false;
            }
            else
            {
                btDelItemCompra.Enabled = true;
                btRemoverTudo.Enabled = true;
                btComprar.Enabled = true;
            }
            if (txId.Text == "" || txNome.Text == "" || txQntdCompra.Text == "")
                btAdd.Enabled = false;
            else
                btAdd.Enabled = true;
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
