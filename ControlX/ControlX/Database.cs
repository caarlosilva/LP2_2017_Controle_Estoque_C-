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
        private static Dictionary<int, Produto> produtos = new Dictionary<int, Produto> ();
        private static Dictionary<int, Fornecedor> fornecedor = new Dictionary<int, Fornecedor> ();



        public void Adicionar(Produto p)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server = localhost; Database = controlx; Uid = root; Pwd = ;";
            if(conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string sql = String.Format("INSERT INTO produtos(nome, preco, qntd) values ('{0}','{1}','{2}')", p.Nome, p.Preco, p.Qntd);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            //produtos.Add(p.Id, p);
        }

        public void Adicionar(Fornecedor p)
        {
            fornecedor.Add(p.Id, p);
        }

        public void Atualizar(Produto p)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server = localhost; Database = controlx; Uid = root; Pwd = ;";
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            string qry = string.Format("UPDATE produtos SET nome = '{0}', preco = {1}, qntd = {2} where id = {3}", p.Nome, p.Preco, p.Qntd, p.Id );
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            //produtos[p.Id] = p; 
        }

        public void Atualizar(Fornecedor p)
        {
            fornecedor[p.Id] = p;
        }

        public Produto getProduto(int i)
        {
            return produtos[i];
        }

        public Fornecedor getFornecedor(int i)
        {
            return fornecedor[i];
        }

        public Produto Ler(int idProduto)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListAll()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server = localhost; Database = controlx; Uid = root; Pwd = ;";
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            string qry = string.Format("SELECT id, nome, preco, qntd FROM produtos;");
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
            dr.Close();
            conn.Close();
            return ps;
            //return ListByName("");
        }

        public List<Fornecedor> ListAllF()
        {
            return ListByNameF("");
        }

        public List<Produto> ListByName(string name)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server = localhost; Database = controlx; Uid = root; Pwd = ;";
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
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

            }
            /* foreach (KeyValuePair<int, Produto> k in produtos)
             {
                 if (k.Value.Nome.Contains(name))
                     ps.Add(k.Value);
             }
             */
            dr.Close();
            conn.Close();
            return ps;
        
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

        public void Remover(int idProduto)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server = localhost; Database = controlx; Uid = root; Pwd = ;";
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            string qry = string.Format("DELETE FROM produtos where id = {0}", idProduto);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            //produtos.Remove(idProduto);
        }

        public void Remover(Fornecedor f)
        {
            fornecedor.Remove(f.Id);
        }
    }
}
