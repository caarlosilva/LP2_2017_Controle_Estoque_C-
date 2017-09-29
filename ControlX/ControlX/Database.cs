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

        //INICIO METODOS PRODUTO

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

        //INICIO METODOS FORNECEDOR

        public void Adicionar(Fornecedor p)
        {
            MySqlConnection conn = OpenDB();

            string sql = String.Format("INSERT INTO fornecedores(nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado) values ('{0}', {1}, {2}, {3}, {4}, {5},'{6}','{7}','{8}','{9}','{10}')", p.Nome, p.Cnpj, p.Telefone1, p.Telefone2, p.Cep, p.Num, p.Rua, p.Comp, p.Bairro, p.Cidade, p.Estado);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //NAO ESTA FUNCIONANDO
        public void Atualizar(Fornecedor p)
        {
            MySqlConnection conn = OpenDB();

            string qry = string.Format("UPDATE fornecedores SET nome = '{0}', cnpj = {1}, tel1 = {2}, tel2 = {3}, cep = {4}, num = {5}, rua = '{6}', comp = '{7}', bairro = '{8}', cidade = '{9}', estado = '{10}' WHERE id = {11}", p.Nome, p.Cnpj, p.Telefone1, p.Telefone2, p.Cep, p.Num, p.Rua, p.Comp, p.Bairro, p.Cidade, p.Estado, p.Id);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Fornecedor getFornecedor(Fornecedor p)
        {            
            return p;
        }

        public List<Fornecedor> ListAllF()
        {
            MySqlConnection conn = OpenDB();

            string qry = string.Format("SELECT id, nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado FROM fornecedores");
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dr = cmd.ExecuteReader();


            List<Fornecedor> ps = new List<Fornecedor>();

            while (dr.Read())
            {
                Fornecedor p = new Fornecedor();
                p.Id = dr.GetInt32(0);
                p.Nome = dr.GetString(1);
                p.Cnpj = dr.GetInt64(2);
                p.Telefone1 = dr.GetInt64(3);
                p.Telefone2 = dr.GetInt64(4);
                p.Cep = dr.GetInt64(5);
                p.Num = dr.GetInt32(6);
                p.Rua = dr.GetString(7);
                p.Comp = dr.GetString(8);
                p.Bairro = dr.GetString(9);
                p.Cidade = dr.GetString(10);
                p.Estado = dr.GetString(11);
                ps.Add(p);
            }
            conn.Close();
            return ps;
        }

        public List<Fornecedor> ListByNameF(string name)
        {
            MySqlConnection conn = OpenDB();

            string qry = string.Format("SELECT id, nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado FROM fornecedores WHERE nome LIKE '{0}%", name);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dr = cmd.ExecuteReader();


            List<Fornecedor> ps = new List<Fornecedor>();

            while (dr.Read())
            {
                Fornecedor p = new Fornecedor();
                p.Id = dr.GetInt32(0);
                p.Nome = dr.GetString(1);
                p.Cnpj = dr.GetInt64(2);
                p.Telefone1 = dr.GetInt64(3);
                p.Telefone2 = dr.GetInt64(4);
                p.Cep = dr.GetInt64(5);
                p.Num = dr.GetInt32(6);
                p.Rua = dr.GetString(7);
                p.Comp = dr.GetString(8);
                p.Bairro = dr.GetString(9);
                p.Cidade = dr.GetString(10);
                p.Estado = dr.GetString(11);
                ps.Add(p);

            }
            conn.Close();
            return ps;
        }

        public void Remover(Fornecedor f)
        {
            MySqlConnection conn = OpenDB();

            string qry = string.Format("DELETE FROM fornecedores WHERE id = {0}", f.Id);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //FIM METODOS FORNECEDOR
    }
}
