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
    public partial class formCadastroForn : Form
    {
        private IDao db1 = new DAO.FornecedorDao();
        private Fornecedor nFornecedor = new Fornecedor();


        public formCadastroForn()
        {
            InitializeComponent();
            //btComplete é o método que acionará ou não o Botão de salvar, evitando causar
            //excessões caso mandemos um valor NULL onde não deveria
            btComplete();
        }

        //Esse método utiliza o WebService dos correios para fazer a busca do CEP
        //e  retornar Rua, Nome, Bairro, Cidade, Estado e Complemento.
        private void BuscaCEP()
        {
            try
            {
                
                var ws = new WsCorreios.AtendeClienteClient();
                //Criamos uma variavel para receber o valor que o método consultaCEP retornará.
                //Ela já é um método que vem pronto com o WS dos correios, precisamos simplesmente passar
                //O CEP
                var consulta = ws.consultaCEP(txCEP.Text);

                //Exibindo os valores retornados em seus respectivos 'TextBox'
                txRua.Text = consulta.end;
                txCompl.Text = consulta.complemento;
                txBairro.Text = consulta.bairro;
                txCidade.Text = consulta.cidade;
                txEstado.Text = consulta.uf;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar busca do CEP: " + txCEP.Text + "\n" + ex.Message, "BUSCA DO CEP INVÁLIDA");
            }
        }

        private void btComplete()
        {
            /*
            foreach (Control c in pnCadForn.Controls)
            {
                if (c is TextBox)
                    if (((TextBox)c).Text.Trim() != "")
                        btCadastrar.Enabled = false;
                else if(c is MaskedTextBox)
                     if (((MaskedTextBox)c).Text.Trim() != "")
                        btCadastrar.Enabled = false;
                else
                        btCadastrar.Enabled = true;
            }
            */

            if (txNome.Text.Trim() == "" || txRua.Text.Trim() == "" 
                || txBairro.Text.Trim() == "" || txCidade.Text.Trim() == "" || txEstado.Text.Trim() == "" 
                || txNum.Text.Trim() == "" || !txCNPJ.MaskCompleted || !txTel1.MaskCompleted) //O IF ACABA AQUI, KRAI
                btCadastrar.Enabled = false;
            else
                btCadastrar.Enabled = true;


        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            
        }

        private void txCEP_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txCEP_Leave(object sender, EventArgs e)
        {                           
            if (txCEP.MaskFull)
                BuscaCEP();
        }

        private void MaskOff()
        {
            //Tirando a Mascara dos TextBox
            txCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txTel1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txTel2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            MaskOff();  //Tira a máscara para mandar ao Banco somente os valores
            nFornecedor.Nome = txNome.Text;
            nFornecedor.Cnpj = long.Parse(txCNPJ.Text);
            nFornecedor.Cep = long.Parse(txCEP.Text);
            nFornecedor.Rua = txRua.Text;
            nFornecedor.Bairro = txBairro.Text;
            nFornecedor.Num = long.Parse(txNum.Text);
            nFornecedor.Cidade = txCidade.Text;
            nFornecedor.Estado = txEstado.Text;
            nFornecedor.Comp = txCompl.Text;
            nFornecedor.Telefone1 = long.Parse(txTel1.Text);
            nFornecedor.Telefone2 = (txTel2.Text == "") ? 0 : long.Parse(txTel2.Text);
            btComplete();
            //Se o botão estiver com o nome de 'Cadastrar', salvaremos tudo no Banco de Dados
            if (btCadastrar.Text == "Cadastrar")
                db1.Adicionar(nFornecedor);
            //Se estiver 'Salvar', pegamos o ID no label, referente ao produto que será editado
            //e mandamos ao banco novamente
            else if (btCadastrar.Text == "Salvar")
            {
                nFornecedor.Id = int.Parse(lbIdForn.Text);
                db1.Atualizar(nFornecedor);
            }
            this.Close();

        }

        private void txNome_TextChanged(object sender, EventArgs e)
        {
            btComplete();
        }
        /*
        private void txRua_TextChanged(object sender, EventArgs e)
        {
            btComplete();
        }

        private void txBairro_TextChanged(object sender, EventArgs e)
        {
            btComplete();
        }


        private void txCidade_TextChanged(object sender, EventArgs e)
        {
            btComplete();
        }

        private void txEstado_TextChanged(object sender, EventArgs e)
        {
            btComplete();
        }
        */

    }
}
