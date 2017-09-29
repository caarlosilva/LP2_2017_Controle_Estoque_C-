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
        private static Dictionary<int, Fornecedor> fornecedor = new Dictionary<int, Fornecedor>();
        private Database db1 = new Database();
        private Fornecedor nFornecedor = new Fornecedor();


        public formCadastroForn()
        {
            InitializeComponent();
            lbIdForn.Text = "" + (fornecedor.Count + 1);
            //btComplete(this.Controls);

        }

        private void BuscaCPF()
        {
            try
            {
                var ws = new WsCorreios.AtendeClienteClient();
                var consulta = ws.consultaCEP(txCEP.Text);

                txRua.Text = consulta.end;
                txCompl.Text = consulta.complemento;
                txBairro.Text =  consulta.bairro;
                txCidade.Text = consulta.cidade;
                txEstado.Text = consulta.uf;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Erro ao efetuar busca do CEP: {0}", ex.Message);
            }
        }

        private void btComplete(Control tx)
        {
            //
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txCEP.TextLength == 9)
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txCEP_KeyUp(object sender, KeyEventArgs e)
        {
                         
        }

        private void txCEP_Leave(object sender, EventArgs e)
        {
            if (txCEP.TextLength == 9)
                BuscaCPF();
        }

        private void MaskOff()
        {
            //Tirando a Mascara dos TextBox
            txCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txTel1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txTel2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }
        private void MaskOn()
        {
            //Rertorna a Mascara dos TextBox
            txCNPJ.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txTel1.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txTel2.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            MaskOff();
            nFornecedor.Id = int.Parse(lbIdForn.Text);
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
            if (txTel2.Text.Trim() != "")
                nFornecedor.Telefone2 = 0;
            else
                nFornecedor.Telefone2 = long.Parse(txTel2.Text);

            if (btCadastrar.Text == "Cadastrar")
               db1.Adicionar(nFornecedor);

            if (btCadastrar.Text == "Salvar")
                db1.Atualizar(nFornecedor);
            this.Close();

        }

        private void txNome_TextChanged(object sender, EventArgs e)
        {
            //btComplete(this.Controls);
        }
    }
}
