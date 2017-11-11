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
    public partial class FormRelatorios : Form
    {

        public FormRelatorios()
        {
            InitializeComponent();
        }

        private void RelatorioCompras_Load(object sender, EventArgs e)
        {
            CV.FormDataRelatorio form = new CV.FormDataRelatorio();
            if (form.tipoRelatorio == "compras")
            {

            }
            if (form.tipoRelatorio == "vendas")
            {
                List<Object> lista = new VenderDao().ListVendas(DateTime.Parse(form.dtInicio.ToString()), DateTime.Parse(form.dtFim.ToString()));

                Relatorios.Vendas_Rel report = new Relatorios.Vendas_Rel();
                report.SetDataSource(lista);
                crvRelatorio.ReportSource = report;
            }
            if (form.tipoRelatorio == "estoquemin")
            {
                List<Object> lista = new DAO.ProdutoDao().ListEstoqueMinimo();

                Relatorios.EstoqueMin_Rel report = new Relatorios.EstoqueMin_Rel();
                report.SetDataSource(lista);
                crvRelatorio.ReportSource = report;
            }
        }
    }
}
