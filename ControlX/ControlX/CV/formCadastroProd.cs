using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlX
{
    public partial class formCadastroProd : Form
    {
        private IDao db1 = new DAO.ProdutoDao();
        private Produto nProduto = new Produto();
        public formCadastroProd()
        {
            InitializeComponent();
            //btComplete é o método que acionará ou não o Botão de salvar, evitando causar
            //excessões caso mandemos um valor NULL onde não deveria           
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

            //comboBox Categorias

            IDao db3 = new DAO.CategoriaDao();
            List<Object> cat = db3.ListAll();
            cbCategoria.DataSource = cat;

            foreach (Object c in cat)
            {
                cbCategoria.DisplayMember = "CategoriaFullName";
                cbCategoria.ValueMember = "Id";
            }
        }
        
        private void btComplete()
        {
            if (txNome.Text.Trim() == "" || txPreco.Text.Trim() == "" || txQntd.Text.Trim() == "" || cbFornecedor.Text.Trim() == "" || cbCategoria.Text.Trim() == "" || cbTipoUn.Text.Trim() == "")
                btCadastrar.Enabled = false;
            else
                btCadastrar.Enabled = true;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            nProduto.Nome = txNome.Text;
            nProduto.Preco = double.Parse(txPreco.Text);                
            nProduto.Qntd = double.Parse(txQntd.Text);
            nProduto.Fornecedor.Id = int.Parse(cbFornecedor.SelectedValue.ToString());
            nProduto.Cat.Id = int.Parse(cbCategoria.SelectedValue.ToString());
            nProduto.TipoUn = cbTipoUn.Text.ToString();

            btComplete();

            if (btCadastrar.Text != "Salvar")
            {
               db1.Adicionar(nProduto);                    
            }

            else if (btCadastrar.Text == "Salvar")
            {
                nProduto.Id = int.Parse(lbIdProduto.Text);
                db1.Atualizar(nProduto);
            }

            this.Dispose();           
        }

        private void txNome_TextChanged(object sender, EventArgs e)
        {
            btComplete();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void btImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagem = new OpenFileDialog();
            imagem.Filter = "jpg|*.jpg|png|*.png";
            if (imagem.ShowDialog() == DialogResult.OK)
            {
                FileInfo arquivo = new FileInfo(imagem.FileName);
                //testa se tem menos de 1MB (1MB em bytes = 1048576)
                if (arquivo.Length <= 1048576)
                    pbImagemProd.ImageLocation = imagem.FileName;
                else
                    MessageBox.Show("O Tamanho da imagem não pode exceder 1MB!", "Tamanho de arquivo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txQntd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if (e.KeyChar == ',')   //Se o usuario inserir uma virgula
                if (txQntd.Text.Contains(",") || txQntd.Text.Equals(""))//Checa se o usuario ja inseriu uma virgula previamente
                    e.Handled = true; // Caso ja exista uma virgula, outra não será aceita 
        }

        private void txPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if (e.KeyChar == ',')   //Se o usuario inserir uma virgula
                if (txPreco.Text.Contains(",") || txPreco.Text.Equals(""))//Checa se o usuario ja inseriu uma virgula previamente
                    e.Handled = true; // Caso ja exista uma virgula, outra não será aceita            
        }
    }
}
