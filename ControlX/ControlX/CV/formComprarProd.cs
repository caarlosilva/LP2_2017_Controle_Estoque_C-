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
    public partial class formEditComprar : Form
    {
        private IDao db1 = new DAO.ProdutoDao();
        private Produto nProduto = new Produto();

        public formEditComprar()
        {
            InitializeComponent();
            btComplete();
            //iniComboBox tem como função inicializar o combo box de Fornecedor com *pasmem*
            //os Fornecedores
            iniComboBox();
        }

        private void iniComboBox()
        {

            IDao db2 = new DAO.FornecedorDao();
            List<Object> forn = db2.ListAll();
            //Pegamos a lista fornecida pelo ListAll, que contém todos os Fornecedores
            //E colocamos como 'fonte' do combobox essa lista
            cbFornecedor.DataSource = forn;
            //Precisamos depois colocar 'valores' para cada 'item' desse combo box, pois precisaremos
            //Saber qual fornecedor o devido produto terá
            foreach (Object p in forn)
            {
                //DisplayMember será a Property do que será mostrado no ComboBox, colocamos a Property
                //'FornecedorFullName', que retorna as propertys 'Id' e 'Nome' concatenados
                cbFornecedor.DisplayMember = "FornecedorFullName";
                //E para cada item mostrado, o seu 'valor' será o Id desse fornecedor
                cbFornecedor.ValueMember = "Id";
                //Ex.: Mostraremos o Fornecedor 'Jorge Cutigi' que possui Id 13
                //O Combo Box então mostrará '13 - Jorge Cutigi', e caso for selecionado
                //O seu Id '13' será o valor que o combo box terá em seu ValueMember
            }
        }

        private void btComplete()
        {
            if (txQntdCompra.Text.Trim() == "")
                btComprar.Enabled = false;
            else
                btComprar.Enabled = true;
        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            int q1 = int.Parse(txQntd.Text);
            int q2 = int.Parse(txQntdCompra.Text);
            nProduto.Nome = txNome.Text;
            nProduto.Preco = double.Parse(txPreco.Text);
            nProduto.Qntd = q1 + q2;
            nProduto.Fornecedor.Id = int.Parse(cbFornecedor.SelectedValue.ToString());

            btComplete();

            nProduto.Id = int.Parse(lbIdProduto.Text);
            db1.Atualizar(nProduto);

            this.Dispose();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txQntdCompra_TextChanged(object sender, EventArgs e)
        {
            btComplete();
        }

        private void txQntdCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
