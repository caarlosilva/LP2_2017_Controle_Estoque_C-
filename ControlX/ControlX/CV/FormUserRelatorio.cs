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
    public partial class FormUserRelatorio : Form
    {
        Usuario user = new Usuario();
        Usuario user1 = new Usuario();
        public FormUserRelatorio()
        {
            InitializeComponent();
            iniComboBox();
        }

        public FormUserRelatorio(Usuario u)
        {
            InitializeComponent();
            iniComboBox();
            user = u;
        }

        private void iniComboBox()
        {
            IDao db2 = new DAO.UsuarioDao();
            List<Object> func = db2.ListAll();
            //Pegamos a lista fornecida pelo ListAll, que contém todos os Fornecedores
            //E colocamos como 'fonte' do combobox essa lista
            cbFunc.DataSource = func;
            //Precisamos depois colocar 'valores' para cada 'item' desse combo box, pois precisaremos
            //Saber qual fornecedor o devido produto terá
            foreach (Object p in func)
            {
                //DisplayMember será a Property do que será mostrado no ComboBox, colocamos a Property
                //'FornecedorFullName', que retorna as propertys 'Id' e 'Nome' concatenados
                cbFunc.DisplayMember = "UsuarioFullName";
                //E para cada item mostrado, o seu 'valor' será o Id desse fornecedor
                cbFunc.ValueMember = "Id";
                //Ex.: Mostraremos o Fornecedor 'Jorge Cutigi' que possui Id 13
                //O Combo Box então mostrará '13 - Jorge Cutigi', e caso for selecionado
                //O seu Id '13' será o valor que o combo box terá em seu ValueMember
            }
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            DateTime dataIni = DateTime.Parse(dateInicio.Value.ToString());
            DateTime dataFim = DateTime.Parse(dateFim.Value.ToString());
            int idFunc = int.Parse(cbFunc.SelectedValue.ToString());
            DAO.UsuarioDao func = new DAO.UsuarioDao();
            user1 = func.LerUser(idFunc); 

            FormRelatorios form = new FormRelatorios(user1.Nome, dataIni, dataFim, user1);
            form.Text = "ControlX - Relatorio de vendas por funcionário";
            form.tipoRelatorio = 4;
            form.Show();
        }
    }
}
