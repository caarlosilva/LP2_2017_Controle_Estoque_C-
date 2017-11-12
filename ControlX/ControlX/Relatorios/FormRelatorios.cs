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
        public int tipoRelatorio;
        public FormRelatorios()
        {
            InitializeComponent();
        }

        private void RelatorioCompras_Load(object sender, EventArgs e)
        {
            formMenu form = new formMenu();

            CV.FormDataRelatorio data = new CV.FormDataRelatorio();
            if (tipoRelatorio == 1)
            {
                List<Object> lista = new ComprarDao().ListCompras(DateTime.Parse(data.dtInicio.Value.ToString()), DateTime.Parse(data.dtFim.Value.ToString()));

                Relatorios.Compras_Rel report = new Relatorios.Compras_Rel();
                report.SetDataSource(lista);
                crvRelatorio.ReportSource = report;
            }

            if (tipoRelatorio == 2)
            {
                List<Object> lista = new VenderDao().ListVendas(DateTime.Parse(data.dtInicio.Value.ToString()), DateTime.Parse(data.dtFim.Value.ToString()));

                Relatorios.Vendas_Rel report = new Relatorios.Vendas_Rel();
                report.SetDataSource(lista);
                crvRelatorio.ReportSource = report;
            }

            if (tipoRelatorio == 3)
            {
                List<Object> lista = new DAO.ProdutoDao().ListEstoqueMinimo();

                Relatorios.EstoqueMin_Rel report = new Relatorios.EstoqueMin_Rel();
                report.SetDataSource(lista);
                crvRelatorio.ReportSource = report;
            }
        }
    }
}
