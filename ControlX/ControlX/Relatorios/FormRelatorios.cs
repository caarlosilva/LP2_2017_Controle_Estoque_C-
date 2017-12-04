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
        private Usuario func;

        //NotaFiscal - Vendas
        private DateTime dataVenda;
        private int idVenda;
        private string vendedor;

        //NotaFiscal - Compras
        private DateTime dataCompra;
        private DateTime dataEntrega;
        private int idCompra;
        private string funcionario;


        private DateTime dataInicio;
        private DateTime dataFim;


        public FormRelatorios()
        {
            InitializeComponent();
        }

        //Construtor Nota Fiscal - Vendas
        public FormRelatorios(string autor, DateTime dataVenda, int idVenda, string vendedor) 
        {           
            this.autor = autor;
            this.dataVenda = dataVenda;
            this.idVenda = idVenda;
            this.vendedor = vendedor;
            InitializeComponent();
        }

        //Construtor Nota Fiscal - Compras
        public FormRelatorios(string autor, DateTime dataCompra, DateTime dataEntrega, int idCompra, string funcionario)
        {
            this.autor = autor;
            this.dataCompra = dataCompra;
            this.dataEntrega = dataEntrega;
            this.idCompra = idCompra;
            this.funcionario = funcionario;
            InitializeComponent();
        }

        //Construtor Rel Estoque Minimo
        public FormRelatorios(string autor)
        {
            this.autor = autor;
            InitializeComponent();
        }

        // Construtor Rel Compras e Vendas por periodo
        public FormRelatorios(string autor, DateTime dataInicio, DateTime dataFim) 
        {
            this.autor = autor;
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
            InitializeComponent();
        }

        // Construtor Rel Vendas por Funcionario
        public FormRelatorios(string autor, DateTime dataInicio, DateTime dataFim, Usuario func) 
        {
            this.autor = autor;
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
            this.func = func;
            InitializeComponent();
        }

        private void RelatorioCompras_Load(object sender, EventArgs e)
        {
            formMenu form = new formMenu();
            string dataI = dataInicio.ToString("dd-MM-yyyy");
            string dataF = dataFim.ToString("dd-MM-yyyy");
            double total = 0;

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

            if (tipoRelatorio == 2) //Vendas > Por periodo
            {
                List<Object> lista = new VenderDao().ListVendas(dataInicio, dataFim);

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

            if (tipoRelatorio == 3) //Estoque > Estoque abaixo do minimo
            {
                List<Object> lista = new DAO.ProdutoDao().ListEstoqueMinimo();

                Relatorios.EstoqueMin_Rel report = new Relatorios.EstoqueMin_Rel();
                report.SetDataSource(lista);
                report.SetParameterValue("Autor", autor);
                report.SetParameterValue("Count", lista.Count);
                crvRelatorio.ReportSource = report;
                crvRelatorio.Refresh();
            }

            if (tipoRelatorio == 4) //Vendas > Por funcionario
            {
                List<Object> lista = new VenderDao().ListByUser(dataInicio, dataFim, func);

                double valor = 0;
                foreach (Vender c in lista)
                {
                    valor += c.Valor;
                }

                Relatorios.Func_Rel report = new Relatorios.Func_Rel();
                report.SetDataSource(lista);
                report.SetParameterValue("Autor", autor);
                report.SetParameterValue("Id_Func", func.Id);
                report.SetParameterValue("Nome_Func", func.Nome);
                report.SetParameterValue("Cpf_Func", func.Cpf);
                report.SetParameterValue("DataInicio", dataI);
                report.SetParameterValue("DataFim", dataF);
                report.SetParameterValue("Count", lista.Count);
                report.SetParameterValue("Valor", valor);
                crvRelatorio.ReportSource = report;
                crvRelatorio.Refresh();

            }

            if (tipoRelatorio == 5) //Nota Fiscal - Vendas
            {
                List<Object> lista = new VenderDao().ListProdutos(idVenda);

                double valor = 0;
                foreach (Produto p in lista)
                {
                    valor += (p.Qntd * p.Preco);
                }
                string dataV = dataVenda.ToString("dd-MM-yyyy HH:mm:ss");

                Relatorios.NotaFiscal report = new Relatorios.NotaFiscal();
                report.SetDataSource(lista);
                report.SetParameterValue("Autor", autor);
                report.SetParameterValue("dataVenda", dataV);
                report.SetParameterValue("Count", lista.Count);
                report.SetParameterValue("Valor", valor);
                report.SetParameterValue("idVenda", idVenda);
                report.SetParameterValue("Vendedor", vendedor);
                crvRelatorio.ReportSource = report;
                crvRelatorio.Refresh();
            }

            if (tipoRelatorio == 6) //Estoque > Inventario
            {
                List<Object> lista = new DAO.ProdutoDao().ListAll();

                Relatorios.Inventario_Rel report = new Relatorios.Inventario_Rel();
                report.SetDataSource(lista);
                report.SetParameterValue("Autor", autor);
                report.SetParameterValue("Count", lista.Count);
                crvRelatorio.ReportSource = report;
                crvRelatorio.Refresh();
            }

            if (tipoRelatorio == 7) //Nota Fiscal - Compras
            {
                List<Object> lista = new ComprarDao().ListProdutos(idCompra);

                double valor = 0;
                foreach (Produto p in lista)
                {
                    valor += (p.Qntd * p.Preco);
                }
                string dataC = dataCompra.ToString("dd-MM-yyyy HH:mm:ss");
                string dataE = dataCompra.ToString("dd-MM-yyyy");

                Relatorios.Compras_NF report = new Relatorios.Compras_NF();
                report.SetDataSource(lista);
                report.SetParameterValue("Autor", autor);
                report.SetParameterValue("dataCompra", dataC);
                report.SetParameterValue("dataEntrega", dataE);
                report.SetParameterValue("Count", lista.Count);
                report.SetParameterValue("Valor", valor);
                report.SetParameterValue("idCompra", idCompra);
                report.SetParameterValue("Funcionario", funcionario);
                crvRelatorio.ReportSource = report;
                crvRelatorio.Refresh();
            }
        }
    }
}
