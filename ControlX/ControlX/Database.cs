using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ControlX
{
    class Database : IDatabase
    {

        //Open Database
        public MySqlConnection OpenDB()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server = localhost; Database = controlx; Uid = root; Pwd =ifsp;";
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            return conn;
        }

        //INICIO METODOS PRODUTO

        public void Adicionar(Produto p)
        {
            MySqlConnection conn = OpenDB();

            // CONVERSÃO DA VIRGULA PARA PONTO, O BD SEPARA AS CASAS DECIMAIS POR '.' E O VS POR ','.
            string preco = Convert.ToString(p.Preco);
            if (preco.ToString().Contains(","))
            {
                preco = preco.Replace(",", ".");
            }

            string sql = string.Format("INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('{0}',{1},{2},{3})", p.Nome, preco, p.Qntd, p.Fornecedor.Id);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Atualizar(Produto p)
        {
            MySqlConnection conn = OpenDB();
            // CONVERSÃO DA VIRGULA PARA PONTO, O BD SEPARA AS CASAS DECIMAIS POR '.' E O VS POR ',' .
            string preco = Convert.ToString(p.Preco);
            if (preco.ToString().Contains(","))
            {
                preco = preco.Replace(",", ".");
            }
            string qry = string.Format("UPDATE produtos SET nome = '{0}', preco = {1}, qntd = {2}, idFornecedor = {4} where id = {3}", p.Nome, preco, p.Qntd, p.Id, p.Fornecedor.Id );
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.ExecuteNonQuery();
            conn.Close();                         
        }

        

        public List<Produto> ListAll()
        {
            MySqlConnection conn = OpenDB();

            string qry = string.Format("SELECT id, nome, preco, qntd, idFornecedor FROM produtos");
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
                p.Fornecedor.Id = dr.GetInt32(4);
                ps.Add(p);  
            }
            conn.Close();
            return ps;
        }

        public List<Produto> ListByName(int id)
        {
                MySqlConnection conn = OpenDB();
                string qry = string.Format("SELECT id, nome, preco, qntd, idFornecedor FROM produtos WHERE id = @id_produto;");
                MySqlCommand cmd = new MySqlCommand(qry, conn);

                cmd.Parameters.AddWithValue("@id_produto", id);


                MySqlDataReader dr = cmd.ExecuteReader();

                List<Produto> ps = new List<Produto>();

                while (dr.Read())
                {
                    Produto p = new Produto();
                    p.Id = dr.GetInt32(0);
                    p.Nome = dr.GetString(1);
                    p.Preco = dr.GetDouble(2);
                    p.Qntd = dr.GetInt32(3);
                    p.Fornecedor.Id = dr.GetInt32(4);
                    ps.Add(p);
                }
                conn.Close();
                return ps;
        }

        public List<Produto> ListByName(string name)
        {
            MySqlConnection conn = OpenDB();
            string qry = string.Format("SELECT id, nome, preco, qntd FROM produtos WHERE nome LIKE '%{0}%';", name);
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

        //BUSCA NA TABELA PRODUTOS PELO ULTIMO VALOR DO AUTO INCREMENTO
        public int GetIdProduto()
        {
            MySqlConnection conn = OpenDB();
            string qry = string.Format("SELECT `AUTO_INCREMENT` FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'controlx' AND TABLE_NAME = 'produtos'");
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int idProduto = dr.GetInt32(0);     
            conn.Close();
            return idProduto;
        }
        //FIM METODOS PRODUTO


        //INICIO METODOS FORNECEDOR

        public void Adicionar(Fornecedor f)
        {
            MySqlConnection conn = OpenDB();
            string sql = string.Format("INSERT INTO fornecedor(nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado) values ('{0}', '{1}', '{2}', '{3}', {4}, {5},'{6}','{7}','{8}','{9}','{10}')", f.Nome, f.Cnpj, f.Telefone1, f.Telefone2, f.Cep, f.Num, f.Rua, f.Comp, f.Bairro, f.Cidade, f.Estado);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
               
        public void Atualizar(Fornecedor f)
        {
            MySqlConnection conn = OpenDB();
            string qry = string.Format("UPDATE fornecedor SET nome = '{0}', cnpj = '{1}', tel1 = '{2}', tel2 = '{3}', cep = {4}, num = {5}, rua = '{6}', comp = '{7}', bairro = '{8}', cidade = '{9}', estado = '{10}' WHERE id = {11}", f.Nome, f.Cnpj, f.Telefone1, f.Telefone2, f.Cep, f.Num, f.Rua, f.Comp, f.Bairro, f.Cidade, f.Estado, f.Id);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Fornecedor getFornecedor(Fornecedor f)
        {            
            return f;
        }

        public List<Fornecedor> ListAllF()
        {
            MySqlConnection conn = OpenDB();

            string qry = string.Format("SELECT id, nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado FROM fornecedor");
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dr = cmd.ExecuteReader();


            List<Fornecedor> fs = new List<Fornecedor>();

            while (dr.Read())
            {
                Fornecedor f = new Fornecedor();
                f.Id = dr.GetInt32(0);
                f.Nome = dr.GetString(1);
                f.Cnpj = long.Parse(dr.GetString(2));
                f.Telefone1 = long.Parse(dr.GetString(3));
                f.Telefone2 = long.Parse(dr.GetString(4));
                f.Cep = long.Parse(dr.GetString(5));
                f.Num = dr.GetInt32(6);
                f.Rua = dr.GetString(7);
                f.Comp = dr.GetString(8);
                f.Bairro = dr.GetString(9);
                f.Cidade = dr.GetString(10);
                f.Estado = dr.GetString(11);
                fs.Add(f);
            }
            dr.Close();
            conn.Close();
            return fs;
        }

        public List<Fornecedor> ListByNameF(string name)
        {
            MySqlConnection conn = OpenDB();

            string qry = string.Format("SELECT id, nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado FROM fornecedor WHERE nome LIKE '%{0}%'", name);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            List<Fornecedor> fs = new List<Fornecedor>();

            while (dr.Read())
            {
                Fornecedor f = new Fornecedor();
                f.Id = dr.GetInt32(0);
                f.Nome = dr.GetString(1);
                f.Cnpj = long.Parse(dr.GetString(2));
                f.Telefone1 = long.Parse(dr.GetString(3));
                f.Telefone2 = long.Parse(dr.GetString(4));
                f.Cep = long.Parse(dr.GetString(5));
                f.Num = dr.GetInt32(6);
                f.Rua = dr.GetString(7);
                f.Comp = dr.GetString(8);
                f.Bairro = dr.GetString(9);
                f.Cidade = dr.GetString(10);
                f.Estado = dr.GetString(11);
                fs.Add(f);

            }
            dr.Close();
            conn.Close();
            return fs;
        }

        public void Remover(Fornecedor f)
        {
            MySqlConnection conn = OpenDB();

            //PROCURA PRODUTOS COM ID DO FORNECEDOR
            string qry = string.Format("SELECT idFornecedor FROM produtos WHERE idFornecedor = {0}", f.Id);
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            //DELETA PRODUTOS COM O ID DO FORNECEDOR
            string qry1 = string.Format("DELETE FROM produtos WHERE idFornecedor = {0}", f.Id);
            MySqlCommand cmd1 = new MySqlCommand(qry1, conn);

            //VERIFICA SE EXISTE PRODUTOS DESTE FORNECEDOR
            while (dr.Read())
            {
                dr.Close();
                cmd1.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
            }
            dr.Close();


            string qry2 = string.Format("DELETE FROM fornecedor WHERE id = {0}", f.Id);
            MySqlCommand cmd2 = new MySqlCommand(qry2, conn);
            cmd2.ExecuteNonQuery();
            conn.Close();
        }

        //BUSCA NA TABELA FORNECEDOR PELO ULTIMO VALOR DO AUTO INCREMENTO
        public int GetIdFornecedor()
        {
            MySqlConnection conn = OpenDB();
            string qry = string.Format("SELECT `AUTO_INCREMENT` FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'controlx' AND TABLE_NAME = 'fornecedor'");
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int idFornecedor = dr.GetInt32(0);
            conn.Close();
            return idFornecedor;
        }

        public Produto getProduto(int i)
        {
            throw new NotImplementedException();
        }
        //FIM METODOS FORNECEDOR
    }
}
