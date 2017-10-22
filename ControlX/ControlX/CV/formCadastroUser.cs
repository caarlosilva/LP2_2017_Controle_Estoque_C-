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
    public partial class formCadastroUser : Form
    {

        private IDao db1 = new DAO.UsuarioDao();
        private Usuario user = new Usuario();

        public formCadastroUser()
        {
            InitializeComponent();
            this.btCadastrar.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MaskOff()
        {
            //Tirando a Mascara dos TextBox
            txCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txTel1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txTel2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            MaskOff();  //Tira a máscara para mandar ao Banco somente os valores
            user.Nome = txNome.Text;
            user.Cpf = long.Parse(txCPF.Text);
            user.Sexo = char.Parse(cbSexo.Text);
            user.DataNasc = dtpDataNasc.Value;
            user.Cep = long.Parse(txCEP.Text);
            user.Rua = txRua.Text;
            user.Bairro = txBairro.Text;
            user.Num = long.Parse(txNum.Text);
            user.Cidade = txCidade.Text;
            user.Estado = txEstado.Text;
            user.Comp = txCompl.Text;
            user.Cargo = cbCargo.Text;
            user.Login = txLogin.Text;
            user.Senha = txSenha.Text;
            user.Telefone1 = long.Parse(txTel1.Text);
            user.Telefone2 = (txTel2.Text == "") ? 0 : long.Parse(txTel2.Text);
            //Se o botão estiver com o nome de 'Cadastrar', salvaremos tudo no Banco de Dados

            if (btCadastrar.Text == "Cadastrar")
                db1.Adicionar(user);
            //Se estiver 'Salvar', pegamos o ID no label, referente ao produto que será editado
            //e mandamos ao banco novamente
            else if (btCadastrar.Text == "Salvar")
            {
               user.Id = int.Parse(lbIdUser.Text);
               db1.Atualizar(user);
            }
            this.Close();
        }

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

        private void txCEP_Leave(object sender, EventArgs e)
        {
            if (txCEP.MaskFull)
                BuscaCEP();
        }

        private void txLogin_KeyUp(object sender, KeyEventArgs e)
        {
            DAO.UsuarioDao user = new DAO.UsuarioDao();
            formCadastroUser form = new formCadastroUser();
            bool verifica = user.Verificar(txLogin.Text);
            this.lbMensagem.Visible = true;

            if (verifica == true)
            {
                this.lbMensagem.ForeColor = Color.Red;
                this.lbMensagem.Text = "Usuario já está em uso!";
                this.btCadastrar.Enabled = false;
            }
            else if (verifica == false)
            {
                this.lbMensagem.ForeColor = Color.Green;
                this.lbMensagem.Text = "Usuario disponivel para uso!";
                this.btCadastrar.Enabled = true;
            }
        }
    }
}
