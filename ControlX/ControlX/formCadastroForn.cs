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

        public formCadastroForn()
        {
            InitializeComponent();
            
        }

        private void BuscaCPF()
        {
            try
            {
                var ws = new WsCorreios.AtendeClienteClient();
                var consulta = ws.consultaCEP(txCEP.Text);

                txEndereco.Text = consulta.end;
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

        private void btCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
