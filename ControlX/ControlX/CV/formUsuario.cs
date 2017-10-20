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
    public partial class formUsuario : Form
    {
        private int idUser;

        public formUsuario()
        {
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            IDao db = new DAO.UsuarioDao();
            List<Object> users = db.ListAll();

            dgvUsuario.Rows.Clear();
            foreach (Usuario u in users)
            {
                dgvUsuario.Rows.Add(u.Id, u.Nome, u.Cpf, u.DataNasc, u.Cargo);
            }

            buttonEnable();
        }

        private void buttonEnable()
        {

            if (dgvUsuario.RowCount == 0)
            {
                btDel.Enabled = false;
                btEdit.Enabled = false;
                btView.Enabled = false;
            }
            else
            {
                btDel.Enabled = true;
                btEdit.Enabled = true;
                btView.Enabled = true;
            }
        }


        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            formCadastroUser form = new formCadastroUser();
            IDao db = new DAO.UsuarioDao();
            idUser = db.GetId();
            form.lbIdUser.Text = "" + idUser;
            form.ShowDialog(this);
            Fill();
        }
    }
}
