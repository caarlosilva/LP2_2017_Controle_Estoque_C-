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
        private bool supervisor;

        //Supervisor
        public formUsuario(bool supervisor)
        {
            this.supervisor = supervisor;
            InitializeComponent();
            if (supervisor == true)
                removerToolStripMenuItem.Visible = false;
            Fill();
        }

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
                string dataMySql = u.DataNasc.ToString("dd-MM-yyyy");
                dgvUsuario.Rows.Add(u.Id, u.Nome, u.Cpf, dataMySql, u.Cargo);
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

                removerToolStripMenuItem.Enabled = false;
                editarToolStripMenuItem.Enabled = false;
                detalhesToolStripMenuItem.Enabled = false;
                
            }
            else
            {
                btDel.Enabled = true;
                btEdit.Enabled = true;
                btView.Enabled = true;

                removerToolStripMenuItem.Enabled = true;
                editarToolStripMenuItem.Enabled = true;
                detalhesToolStripMenuItem.Enabled = true;
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
            if (supervisor == true)
            {
                form.cbCargo.Items.Remove("Administrador");
                form.cbCargo.Items.Remove("Supervisor");
            }
            form.ShowDialog(this);
            Fill();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            IDao db = new DAO.UsuarioDao();
            List<Object> usuarios = db.ListAll();
            int permissao = 0;

            if (dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells[4].Value.ToString() == "Administrador" || dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells[4].Value.ToString() == "Supervisor")
            {
                permissao = 1;
            }

            formCadastroUser form = new formCadastroUser();
            int id = int.Parse(dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells[0].Value.ToString());
            form.lbIdUser.Text = Convert.ToString(id);

            foreach (Usuario u in usuarios)
            {
                if (u.Id == id)
                {
                    form.txNome.Text = u.Nome;
                    form.txCPF.Text = Convert.ToString(u.Cpf);
                    form.cbSexo.Text = Convert.ToString(u.Sexo);
                    form.dtpDataNasc.Text = Convert.ToString(u.DataNasc);
                    form.txTel1.Text = Convert.ToString(u.Telefone1);
                    form.txTel2.Text = Convert.ToString(u.Telefone2);
                    form.txCEP.Text = Convert.ToString(u.Cep);
                    form.txNum.Text = Convert.ToString(u.Num);
                    form.txRua.Text = u.Rua;
                    form.txCompl.Text = u.Comp;
                    form.txBairro.Text = u.Bairro;
                    form.txCidade.Text = u.Cidade;
                    form.txEstado.Text = u.Estado;
                    form.cbCargo.Text = Convert.ToString(u.Cargo);
                    form.txLogin.Text = Convert.ToString(u.Login);
                    form.txSenha.Text = Convert.ToString(u.Senha);
                    form.pbImagemUser.ImageLocation = u.LocalPic;
                }
            }

            form.btCadastrar.Text = "Salvar";
            form.LoginValido = true;
            form.txLogin.Enabled = false;
            if (this.supervisor == true && permissao == 1)
            {
                //Caixa de aviso para edição de Administrador ou Supervisor
                DialogResult result = MessageBox.Show("Você não tem permissão para isso.",
                    "Aviso!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                form.ShowDialog(this);
                Fill();
            }
        }

        private void detalhes()
        {
            IDao db = new DAO.UsuarioDao();
            List<Object> usuarios = db.ListAll();
            formCadastroUser form = new formCadastroUser();

            int id = int.Parse(dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells[0].Value.ToString());
            form.lbIdUser.Text = Convert.ToString(id);
            //Text box desabilitados por painel
            //Painel CadUser
            foreach (TextBox textbox in form.pnCadUser.Controls.OfType<TextBox>())
            {
                textbox.Enabled = false;
            }

            foreach (MaskedTextBox textbox in form.pnCadUser.Controls.OfType<MaskedTextBox>())
            {
                textbox.Enabled = false;
            }
            //Painel LogSenha
            foreach (TextBox textbox in form.pnLogSenha.Controls.OfType<TextBox>())
            {
                textbox.Enabled = false;
            }

            //ComboBox
            form.cbSexo.Enabled = false;
            form.cbCargo.Enabled = false;
            form.dtpDataNasc.Enabled = false;
            form.btImagem.Enabled = false;

            //Fim paineis somente leitura

            foreach (Usuario u in usuarios)
            {
                if (u.Id == id)
                {
                    form.txNome.Text = u.Nome;
                    form.txCPF.Text = Convert.ToString(u.Cpf);
                    form.cbSexo.Text = Convert.ToString(u.Sexo);
                    form.dtpDataNasc.Text = Convert.ToString(u.DataNasc);
                    form.txTel1.Text = Convert.ToString(u.Telefone1);
                    form.txTel2.Text = Convert.ToString(u.Telefone2);
                    form.txCEP.Text = Convert.ToString(u.Cep);
                    form.txNum.Text = Convert.ToString(u.Num);
                    form.txRua.Text = u.Rua;
                    form.txCompl.Text = u.Comp;
                    form.txBairro.Text = u.Bairro;
                    form.txCidade.Text = u.Cidade;
                    form.txEstado.Text = u.Estado;
                    form.cbCargo.Text = Convert.ToString(u.Cargo);
                    form.txLogin.Text = Convert.ToString(u.Login);
                    form.txSenha.Text = Convert.ToString(u.Senha);
                    form.pbImagemUser.ImageLocation = u.LocalPic;
                }
            }
            form.btCadastrar.Enabled = false;
            form.btCancelar.Text = "Voltar";
            form.ShowDialog(this);
        }


        private void btView_Click(object sender, EventArgs e)
        {
            detalhes();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            IDao data = new DAO.UsuarioDao();
            int a = int.Parse(dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells[0].Value.ToString());
            //Caixa de aviso caso deseja ou não apagar
            DialogResult result = MessageBox.Show("Tem certeza que deseja remover este usuario?",
                "Aviso!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Caso clique em sim
            if (result == DialogResult.Yes)
            {
                data.Remover(a);
                Fill();
                MessageBox.Show("Usuario removido com sucesso.",
                "Aviso!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                buttonEnable();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void txPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            IDao db = new DAO.UsuarioDao();
            List<Object> ps = db.ListByName(txPesquisar.Text);

            dgvUsuario.Rows.Clear();
            foreach (Usuario u in ps)
            {
                dgvUsuario.Rows.Add(u.Id, u.Nome, u.Cpf, u.DataNasc, u.Cargo);
            }
        }

        private void dgvUsuario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            detalhes();
        }

        private void txPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == '\'')
                e.Handled = true;
        }
    }
}
