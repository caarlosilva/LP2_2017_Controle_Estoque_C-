using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ControlX.DAO
{
    class ProdutoDao : IDao
    {
        Database db = Database.GetInstance();
        //INICIO METODOS PRODUTO
        public void Adicionar(Object o)
        {
            Produto p = (Produto)o;
            // CONVERSÃO DA VIRGULA PARA PONTO, O BD SEPARA AS CASAS DECIMAIS POR '.' E O VS POR ','.
            string preco = Convert.ToString(p.Preco);
            if (preco.ToString().Contains(","))
            {
                preco = preco.Replace(",", ".");
            }

            string qntd = Convert.ToString(p.Qntd);
            if (qntd.ToString().Contains(","))
            {
                qntd = qntd.Replace(",", ".");
            }

            string sql = string.Format("INSERT INTO produtos(nome, preco, qntd, tipoUn, estoqueMin, idFornecedor, idCategoria) values ('{0}',{1},{2},'{3}', {4}, {5},{6})", p.Nome, preco, qntd, p.TipoUn, p.EstoqueMin, p.Fornecedor.Id, p.Cat.Id);
            db.ExecuteNonQuery(sql);
        }

        public void Atualizar(Object o)
        {
            Produto p = (Produto)o;
            // CONVERSÃO DA VIRGULA PARA PONTO, O BD SEPARA AS CASAS DECIMAIS POR '.' E O VS POR ',' .
            string preco = Convert.ToString(p.Preco);
            if (preco.ToString().Contains(","))
            {
                preco = preco.Replace(",", ".");
            }

            string qntd = Convert.ToString(p.Qntd);
            if (qntd.ToString().Contains(","))
            {
                qntd = qntd.Replace(",", ".");
            }

            string qry = string.Format("UPDATE produtos SET nome = '{0}', preco = {1}, qntd = {2}, tipoUn = '{3}', estoqueMin = {4}, idFornecedor = {5}, idCategoria = {6} where id = {7}", p.Nome, preco, qntd, p.TipoUn, p.EstoqueMin, p.Fornecedor.Id, p.Cat.Id, p.Id);

            db.ExecuteNonQuery(qry);
        }

        //Relatorio de estoque min
        public List<object> ListEstoqueMinimo()
        {
            string qry = string.Format("SELECT id, nome, preco, qntd, tipoUn, estoqueMin, idFornecedor, idCategoria FROM produtos WHERE deleted_at is null AND qntd < estoqueMin");
            DataSet ds = db.ExecuteQuery(qry);

            List<Object> ps = new List<Object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Produto p = new Produto();
                p.Id = int.Parse(dr["id"].ToString());
                p.Nome = dr["nome"].ToString();
                p.Preco = double.Parse(dr["preco"].ToString());
                p.Qntd = double.Parse(dr["qntd"].ToString());
                p.TipoUn = dr["tipoUn"].ToString();
                p.EstoqueMin = double.Parse(dr["estoqueMin"].ToString());
                p.Fornecedor.Id = int.Parse(dr["idFornecedor"].ToString());
                p.Cat.Id = int.Parse(dr["idCategoria"].ToString());

                FornecedorDao fdao = new FornecedorDao();
                Fornecedor f = fdao.Ler(p.Fornecedor.Id);
                p.Fornecedor = f;

                CategoriaDao cdao = new CategoriaDao();
                Modelo.Categoria c = cdao.Ler(p.Cat.Id);
                p.Cat = c;

                ps.Add(p);
            }
            return ps;
        }
        //

        public List<object> ListAll()
        {
            string qry = string.Format("SELECT id, nome, preco, qntd, tipoUn, estoqueMin, idFornecedor, idCategoria FROM produtos WHERE deleted_at is null");
            DataSet ds = db.ExecuteQuery(qry);

            List<Object> ps = new List<Object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Produto p = new Produto();
                p.Id = int.Parse(dr["id"].ToString());
                p.Nome = dr["nome"].ToString();
                p.Preco = double.Parse(dr["preco"].ToString());
                p.Qntd = double.Parse(dr["qntd"].ToString());
                p.TipoUn = dr["tipoUn"].ToString();
                p.EstoqueMin = double.Parse(dr["estoqueMin"].ToString());
                p.Fornecedor.Id = int.Parse(dr["idFornecedor"].ToString());
                p.Cat.Id = int.Parse(dr["idCategoria"].ToString());

                FornecedorDao fdao = new FornecedorDao();
                Fornecedor f = fdao.Ler(p.Fornecedor.Id);
                p.Fornecedor = f;

                CategoriaDao cdao = new CategoriaDao();
                Modelo.Categoria c = cdao.Ler(p.Cat.Id);
                p.Cat = c;

                ps.Add(p);
            }
            return ps;
        }

        public List<object> ListById(int id)
        {
            string qry = string.Format("SELECT id, nome, preco, qntd, tipoUn, estoqueMin, idFornecedor, idCategoria FROM produtos WHERE id = {0} AND deleted_at is null", id);

            DataSet ds = db.ExecuteQuery(qry);

            List<object> ps = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Produto p = new Produto();
                p.Id = int.Parse(dr["id"].ToString());
                p.Nome = dr["nome"].ToString();
                p.Preco = double.Parse(dr["preco"].ToString());
                p.Qntd = double.Parse(dr["qntd"].ToString());
                p.TipoUn = dr["tipoUn"].ToString();
                p.EstoqueMin = double.Parse(dr["estoqueMin"].ToString());
                p.Fornecedor.Id = int.Parse(dr["idFornecedor"].ToString());
                p.Cat.Id = int.Parse(dr["idCategoria"].ToString());

                FornecedorDao fdao = new FornecedorDao();
                Fornecedor f = fdao.Ler(p.Fornecedor.Id);
                p.Fornecedor = f;

                CategoriaDao cdao = new CategoriaDao();
                Modelo.Categoria c = cdao.Ler(p.Cat.Id);
                p.Cat = c;

                ps.Add(p);
            }
            return ps;
        }

        public List<object> ListByName(string name)
        {
            string qry = string.Format("SELECT * FROM produtos WHERE nome LIKE '%{0}%' AND deleted_at is null;", name);

            DataSet ds = db.ExecuteQuery(qry);

            List<object> ps = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Produto p = new Produto();
                p.Id = int.Parse(dr["id"].ToString());
                p.Nome = dr["nome"].ToString();
                p.Preco = double.Parse(dr["preco"].ToString());
                p.Qntd = double.Parse(dr["qntd"].ToString());
                p.TipoUn = dr["tipoUn"].ToString();
                p.EstoqueMin = double.Parse(dr["estoqueMin"].ToString());
                p.Fornecedor.Id = int.Parse(dr["idFornecedor"].ToString());
                p.Fornecedor.Id = int.Parse(dr["idFornecedor"].ToString());
                p.Cat.Id = int.Parse(dr["idCategoria"].ToString());

                FornecedorDao fdao = new FornecedorDao();
                Fornecedor f = fdao.Ler(p.Fornecedor.Id);
                p.Fornecedor = f;

                CategoriaDao cdao = new CategoriaDao();
                Modelo.Categoria c = cdao.Ler(p.Cat.Id);
                p.Cat = c;

                ps.Add(p);
            }
            return ps;
        }

        public List<object> ListByCategoria(string categoria)
        {
            string qry = string.Format("SELECT p.*, c.nome FROM produtos p JOIN categoria c ON p.idCategoria = c.id WHERE c.nome LIKE '%{0}%' AND p.deleted_at is null;", categoria);

            DataSet ds = db.ExecuteQuery(qry);

            List<object> ps = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Produto p = new Produto();
                p.Id = int.Parse(dr["id"].ToString());
                p.Nome = dr["nome"].ToString();
                p.Preco = double.Parse(dr["preco"].ToString());
                p.Qntd = double.Parse(dr["qntd"].ToString());
                p.TipoUn = dr["tipoUn"].ToString();
                p.EstoqueMin = double.Parse(dr["estoqueMin"].ToString());
                p.Fornecedor.Id = int.Parse(dr["idFornecedor"].ToString());
                p.Cat.Id = int.Parse(dr["idCategoria"].ToString());

                CategoriaDao cdao = new CategoriaDao();
                Modelo.Categoria c = cdao.Ler(p.Cat.Id);
                p.Cat = c;

                ps.Add(p);
            }
            return ps;
        }

        public int Remover(int idProduto)
        {
            string dataMySql = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string qry = string.Format("UPDATE produtos SET deleted_at = '{0}' WHERE id = {1}", dataMySql, idProduto);
            db.ExecuteNonQuery(qry);
            return 1;

        }

        //BUSCA NA TABELA PRODUTOS PELO ULTIMO VALOR DO AUTO INCREMENTO
        public int GetId()
        {
            string qry = string.Format("SELECT `AUTO_INCREMENT` FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'controlx' AND TABLE_NAME = 'produtos'");
            DataSet ds = db.ExecuteQuery(qry);
            DataRow dr = ds.Tables[0].Rows[0];
            int idProduto = int.Parse(dr["AUTO_INCREMENT"].ToString());

            return idProduto;
        }
        //FIM METODOS PRODUTO
    }
}
