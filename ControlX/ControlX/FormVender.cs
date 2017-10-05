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
    public partial class formVender : Form
    {
        public formVender()
        {
            InitializeComponent();
            Auto_Complete();
        }

        private void Auto_Complete()
        {
            txNome.AutoCompleteMode = AutoCompleteMode.Suggest;
            txNome.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            IDao db = new DAO.ProdutoDao();
            List<Object> ps = db.ListAll();
            
            foreach (Produto p in ps)
            {
                col.Add(p.Nome);
            }

            txNome.AutoCompleteCustomSource = col;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txNome.Text = "";
            txId.Text = "";
            txPreco.Text = "";
            txQntd.Text = "";
        }
    }
}
