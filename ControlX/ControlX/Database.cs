using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ControlX
{
    class Database : IDatabase
    {
        private static Dictionary<int, Produto> produtos = new Dictionary<int, Produto>();
        private static Dictionary<int, Fornecedor> fornecedor = new Dictionary<int, Fornecedor>();

        //Open Database
        public MySqlConnection OpenDB()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server = localhost; Database = controlx; Uid = root; Pwd = ;";
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            return conn;
        }

        //METODOS PRODUTO

        public void Adicionar(Produto p)
        {
            MySqlConnection conn = OpenDB();

            string sql = String.Format("INSERT INTO produtos(nome, preco, qntd) values ('{0}','{1}','{2}')", p.Nome, p.Preco, p.Qntd);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Atualizar(Produto p)
        {
            MySqlConnection conn = OpenDB();

            string qry = string.Format("UPDATE produtos SET nome = '{0}', preco = {1}, qntd = {2} where id = {3}", p.Nome, p.Preco, p.Qntd, p.Id );
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.ExecuteNonQuery();
            conn.Close();                         
        }

        public Produto getProduto(int i)
        {
            return produtos[i];
        }

        public List<Produto> ListAll()
        {
            MySqlConnection conn = OpenDB();

            string qry = string.Format("SELECT id, nome, preco, qntd FROM produtos");
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dr = cmd.ExecuteReader();


            List<Produto> ps = new List<Produto>();

            while (dr.Read())
            {
                Produto p = new Produto();
                p.Id = dr.GetInt32(0);
                p.Nome = dr.GetString(1);
                p.Preco = dr.GetDouble(2);
                p.Qntd = dr.GetInt32(3);
                ps.Add(p);
                
            }
            conn.Close();
            return ps;
        }

        public List<Produto> ListByName(string name)
        {
            MySqlConnection conn = OpenDB();

            string qry = string.Format("SELECT id, nome, preco, qntd FROM produtos WHERE nome LIKE '{0}%';", name);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dr = cmd.ExecuteReader();


            List<Produto> ps = new List<Produto>();

            while (dr.Read())
            {
                Produto p = new Produto();
                p.Id = dr.GetInt32(0);
                p.Nome = dr.GetString(1);
                p.Preco = dr.GetDouble(2);
                p.Qntd = dr.GetInt32(3);
                ps.Add(p);
            }
            conn.Close();
            return ps;        
        }

        public void Remover(int idProduto)
        {
            MySqlConnection conn = OpenDB();

            string qry = string.Format("DELETE FROM produtos where id = {0}", idProduto);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //FIM METODOS PRODUTO

        //METODOS FORNECEDOR

        public void Adicionar(Fornecedor p)
        {
            fornecedor.Add(p.Id, p);
        }

        public void Atualizar(Fornecedor p)
        {
            fornecedor[p.Id] = p;
        }

        public Fornecedor getFornecedor(int i)
        {
            return fornecedor[i];
        }

        public List<Fornecedor> ListAllF()
        {
            return ListByNameF("");
        }

        public List<Fornecedor> ListByNameF(string name)
        {
            List<Fornecedor> ps = new List<Fornecedor>();

            foreach (KeyValuePair<int, Fornecedor> k in fornecedor)
            {
                if (k.Value.Nome.Contains(name))
                    ps.Add(k.Value);
            }
            return ps;
        }

        public void Remover(Fornecedor f)
        {
            MySqlConnection conn = OpenDB();

            string qry = string.Format("DELETE FROM produtos where id = {0}", f.Id);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //FIM METODOS FORNECEDOR
    }
}
