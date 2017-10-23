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

        private void btLogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu menu = new formMenu(); 
            menu.lbMensagem.Text = "Você está conectado como '" + txUsuario.Text +"' !";
            menu.ShowDialog();


            this.Show();
            txSenha.Text = "";
        }
    }
}
