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

            string sql = string.Format("INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('{0}',{1},{2},{3})", p.Nome, preco, p.Qntd, p.Fornecedor.Id);
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
            string qry = string.Format("UPDATE produtos SET nome = '{0}', preco = {1}, qntd = {2}, idFornecedor = {4} where id = {3}", p.Nome, preco, p.Qntd, p.Id, p.Fornecedor.Id);
            
            db.ExecuteNonQuery(qry);
        }



        public List<object> ListAll()
        {
            string qry = string.Format("SELECT id, nome, preco, qntd, idFornecedor FROM produtos");
            DataSet ds = db.ExecuteQuery(qry);

            List<Object> ps = new List<Object>();
            
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Produto p = new Produto();
                p.Id = int.Parse(dr["id"].ToString());
                p.Nome = dr["nome"].ToString();
                p.Preco = double.Parse(dr["preco"].ToString());
                p.Qntd = int.Parse(dr["qntd"].ToString());
                p.Fornecedor.Id = int.Parse(dr["idFornecedor"].ToString());
                FornecedorDao fdao = new FornecedorDao();
                Fornecedor f = fdao.Ler(p.Fornecedor.Id);
                p.Fornecedor = f;
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

        public List<object> ListByName(int id)
        {
            string qry = string.Format("SELECT id, nome, preco, qntd, idFornecedor FROM produtos WHERE id = {0};", id);
                      
            DataSet ds = db.ExecuteQuery(qry);
            
            List<object> ps = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Produto p = new Produto();
                p.Id = int.Parse(dr["id"].ToString());
                p.Nome = dr["nome"].ToString();
                p.Preco = double.Parse(dr["preco"].ToString());
                p.Qntd = int.Parse(dr["qntd"].ToString());
                p.Fornecedor.Id = int.Parse(dr["idFornecedor"].ToString());
                ps.Add(p);
            }
            return ps;
        }

        public List<object> ListByName(string name)
        {
            string qry = string.Format("SELECT id, nome, preco, qntd FROM produtos WHERE nome LIKE '%{0}%';", name);

            DataSet ds = db.ExecuteQuery(qry);

            List<object> ps = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Produto p = new Produto();
                p.Id = int.Parse(dr["id"].ToString());
                p.Nome = dr["nome"].ToString();
                p.Preco = double.Parse(dr["preco"].ToString());
                p.Qntd = int.Parse(dr["qntd"].ToString());
                p.Fornecedor.Id = int.Parse(dr["idFornecedor"].ToString());
                ps.Add(p);
            }
            return ps;
        }

        public void Remover(int idProduto)
        {
            string qry = string.Format("DELETE FROM produtos where id = {0}", idProduto);

            db.ExecuteNonQuery(qry);
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
