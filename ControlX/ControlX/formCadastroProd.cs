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
    public partial class formCadastroProd : Form
    {
        private static Dictionary <int, Produto> produtos = new Dictionary<int, Produto>();
        private Database db1 = new Database();
        private Produto nProduto = new Produto();
       

        public formCadastroProd()
        {
            InitializeComponent();
            int count = 0;
            foreach (KeyValuePair<int, Produto> k in produtos)
            {
                count++;
            }
            lbIdProduto.Text = "" + (count+=1);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
                      
            nProduto.Nome = txNome.Text;
            nProduto.Preco = double.Parse(txPreco.Text);
            nProduto.Id = int.Parse(lbIdProduto.Text);
            
            produtos.Add(nProduto.Id, nProduto);
            db1.Adicionar(nProduto);
            
            this.Close();
           
        }
    }
}
