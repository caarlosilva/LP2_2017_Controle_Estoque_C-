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

        private void btLogar_Click(object sender, EventArgs e)
        {
            formMenu form = new formMenu();
            DAO.UsuarioDao u = new DAO.UsuarioDao();
            int result = u.VerificaLogin(txUsuario.Text, txSenha.Text);
            Usuario user = u.Ler(txUsuario.Text);

            Logado1 = result;

            if (result != 0)
            {
                this.Hide();
                formMenu menu = new formMenu(user);
                if (Logado1 > 2)
                {
                    menu.btUsuario.Visible = false;
                    menu.menuRelatorio.Visible = false;
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
    }
}
