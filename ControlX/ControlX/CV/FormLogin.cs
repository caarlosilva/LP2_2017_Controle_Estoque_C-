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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Close();
            this.Close();
        }

        private int Logado = 0;

        public int Logado1
        {
            get
            {
                return Logado;
            }

            set
            {
                Logado = value;
            }
        }

        private void buttonEnable()
        {

            if (txUsuario.Text == "" || txSenha.Text == "")
            {
                btLogar.Enabled = false;
            }
            else
            {
                btLogar.Enabled = true;
            }
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            formMenu form = new formMenu();
            DAO.UsuarioDao u = new DAO.UsuarioDao();
            int result = u.VerificaLogin(txUsuario.Text, txSenha.Text);
            Usuario user = u.Ler(txUsuario.Text);

            Logado1 = result;

            // | 1 - Admin | 2 - Supervisor | 3 - Almoxarifado | 4 - Caixa |

            if (result != 0)
            {
                this.Hide();
                formMenu menu = new formMenu(user, Logado1);
                if (Logado1 == 3) //Almoxarifado
                {
                    menu.btUsuario.Visible = false;
                    menu.pnMenu.Visible = false;
                    menu.pnAlmoxarife.Visible = true;
                    menu.menuRelatorio.Visible = false;
                    menu.menuHistVendas.Visible = false;
                }

                if (Logado1 == 4) //Caixa
                {
                    menu.menuHistCompras.Visible = false;
                    menu.menuRelatorio.Visible = false;
                    menu.pnMenu.Visible = false;
                    menu.pnCaixa.Visible = true;
                }

                menu.lbMensagem.Text = "Olá '" + user.Nome + "' !";
                menu.ShowDialog();

                this.Show();
                txSenha.Text = "";
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!");
            }
        }

        private void txUsuario_TextChanged(object sender, EventArgs e)
        {
            buttonEnable();
        }

        private void txSenha_TextChanged(object sender, EventArgs e)
        {
            buttonEnable();
        }
    }
}
