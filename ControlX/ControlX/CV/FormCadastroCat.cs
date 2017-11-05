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
    public partial class FormCadastroCat : Form
    {
        private IDao db1 = new DAO.CategoriaDao();
        private Modelo.Categoria nCategoria = new Modelo.Categoria();
        public FormCadastroCat()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            nCategoria.Nome = txNome.Text;
            btComplete();
            //Se o botão estiver com o nome de 'Cadastrar', salvaremos tudo no Banco de Dados
            if (btCadastrar.Text == "Cadastrar")
                db1.Adicionar(nCategoria);
            //Se estiver 'Salvar', pegamos o ID no label, referente ao produto que será editado
            //e mandamos ao banco novamente
            else if (btCadastrar.Text == "Salvar")
            {
                nCategoria.Id = int.Parse(lbIdCategoria.Text);
                db1.Atualizar(nCategoria);
            }
            this.Close();
        }

        private void btComplete()
        {
            if (txNome.Text.Trim() == "")
                btCadastrar.Enabled = false;
            else
                btCadastrar.Enabled = true;
        }

        private void txNome_TextChanged(object sender, EventArgs e)
        {
            //Qualquer alteração nos Text Boxs, o btComplete será executado
            btComplete();
        }
    }
}
