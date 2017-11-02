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
    public partial class RelatorioCompras : Form
    {
        public RelatorioCompras()
        {
            InitializeComponent();
        }

        private void RelatorioCompras_Load(object sender, EventArgs e)
        {
            List<Object> lista = new DAO.ProdutoDao().ListAll();

            Relatorios.Compras_Rel report = new Relatorios.Compras_Rel();
            report.SetDataSource(lista);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
