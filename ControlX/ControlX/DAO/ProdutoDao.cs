using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
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

            string sql = string.Format("INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('{0}',{1},{2},'{3}',{4},{5})", p.Nome, preco, qntd, p.TipoUn, p.Fornecedor.Id, p.Cat.Id);
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

            string qry = string.Format("UPDATE produtos SET nome = '{0}', preco = {1}, qntd = {2}, tipoUn = '{3}', idFornecedor = {4}, idCategoria = {5} where id = {6}", p.Nome, preco, qntd, p.TipoUn, p.Fornecedor.Id, p.Cat.Id, p.Id);

            db.ExecuteNonQuery(qry);
        }



        public List<object> ListAll()
        {
            string qry = string.Format("SELECT p.id AS id_prod, p.nome AS nome_prod, preco, qntd, tipoUn, idFornecedor, f.nome AS nome_forn, idCategoria FROM (produtos p JOIN fornecedor f ON p.idFornecedor = f.id) WHERE p.deleted_at is null");
            DataSet ds = db.ExecuteQuery(qry);

            List<Object> ps = new List<Object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Produto p = new Produto();
                p.Id = int.Parse(dr["id_prod"].ToString());
                p.Nome = dr["nome_prod"].ToString();
                p.Preco = double.Parse(dr["preco"].ToString());
                p.Qntd = double.Parse(dr["qntd"].ToString());
                p.TipoUn = dr["tipoUn"].ToString();
                p.Fornecedor.Id = int.Parse(dr["idFornecedor"].ToString());
                p.Cat.Id = int.Parse(dr["idCategoria"].ToString());
                p.Fornecedor.Nome = dr["nome_forn"].ToString();

                FornecedorDao fdao = new FornecedorDao();
                Fornecedor f = fdao.Ler(p.Fornecedor.Id);
                p.Fornecedor = f;

                CategoriaDao cdao = new CategoriaDao();
                Modelo.Categoria c = cdao.Ler(p.Cat.Id);
                p.Cat = c;

                ps.Add(p);
                /*List<Object> flist = fdao.ListByName(p.Fornecedor.Id);


                foreach (Fornecedor f in flist)
                {
                    p.Fornecedor.Nome = f.Nome;
                    p.Fornecedor.Cnpj = f.Cnpj;
                    p.Fornecedor.Telefone1 = f.Telefone1;
                    p.Fornecedor.Telefone2 = f.Telefone2;
                    p.Fornecedor.Cep = f.Cep;
                    p.Fornecedor.Num = f.Num;
                    p.Fornecedor.Rua = f.Rua;
                    p.Fornecedor.Comp = f.Comp;
                    p.Fornecedor.Bairro = f.Bairro;
                    p.Fornecedor.Cidade = f.Cidade;
                    p.Fornecedor.Estado = f.Estado;
                }*/
            }
            return ps;
        }

        public List<object> ListById(int id)
        {
            string qry = string.Format("SELECT id, nome, preco, qntd, tipoUn, idFornecedor, idCategoria FROM produtos WHERE id = {0} AND deleted_at is null", id);

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
