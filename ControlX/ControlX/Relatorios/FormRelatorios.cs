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
        private string autor;
        private DateTime dataInicio;
        private DateTime dataFim;


        /*       public FormRelatorios()
               {
                   InitializeComponent();
               }*/

        public FormRelatorios(string autor)
        {
            this.autor = autor;
            InitializeComponent();
        }

        public FormRelatorios(string autor, DateTime dataInicio, DateTime dataFim)
        {
            this.autor = autor;
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
            InitializeComponent();
        }

        private void RelatorioCompras_Load(object sender, EventArgs e)
        {
            formMenu form = new formMenu();
            string dataI = dataInicio.ToString("dd-MM-yyyy");
            string dataF = dataFim.ToString("dd-MM-yyyy");

            CV.FormDataRelatorio data = new CV.FormDataRelatorio();

            if (tipoRelatorio == 1) //Compras
            {
                List<Object> lista = new ComprarDao().ListCompras(dataInicio, dataFim);

                double valor = 0;
                foreach (Comprar c in lista)
                {
                    valor += c.Valor;
                }

                Relatorios.Compras_Rel report = new Relatorios.Compras_Rel();

                report.SetDataSource(lista);
                report.SetParameterValue("Autor", autor);
                report.SetParameterValue("DataInicio", dataI);
                report.SetParameterValue("DataFim", dataF);
                report.SetParameterValue("Count", lista.Count);
                report.SetParameterValue("Valor", valor);
                crvRelatorio.ReportSource = report;
                crvRelatorio.Refresh();
            }

            if (tipoRelatorio == 2) //Vendas
            {
                List<Object> lista = new VenderDao().ListVendas(data.dtInicio.Value, data.dtFim.Value);

                double valor = 0;
                foreach (Vender v in lista)
                {
                    valor += v.Valor;
                }

                Relatorios.Vendas_Rel report = new Relatorios.Vendas_Rel();

                report.SetDataSource(lista);
                report.SetParameterValue("Autor", autor);
                report.SetParameterValue("DataInicio", dataI);
                report.SetParameterValue("DataFim", dataF);
                report.SetParameterValue("Count", lista.Count);
                report.SetParameterValue("Valor", valor);
                crvRelatorio.ReportSource = report;
                crvRelatorio.Refresh();
            }

            if (tipoRelatorio == 3) //Estoque
            {
                List<Object> lista = new DAO.ProdutoDao().ListEstoqueMinimo();

                Relatorios.EstoqueMin_Rel report = new Relatorios.EstoqueMin_Rel();
                report.SetDataSource(lista);
                report.SetParameterValue("Autor", autor);
                report.SetParameterValue("Count", lista.Count);
                crvRelatorio.ReportSource = report;
                crvRelatorio.Refresh();
            }
        }
    }
}
