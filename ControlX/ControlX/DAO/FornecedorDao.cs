using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ControlX.DAO
{

    class FornecedorDao : IDao
    {
        Database db = Database.GetInstance();
        //INICIO METODOS FORNECEDOR

        public void Adicionar(Object o)
        {
            Fornecedor f = (Fornecedor)o;
            string sql = string.Format("INSERT INTO fornecedor(nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado) values ('{0}', '{1}', '{2}', '{3}', {4}, {5},'{6}','{7}','{8}','{9}','{10}')", f.Nome, f.Cnpj, f.Telefone1, f.Telefone2, f.Cep, f.Num, f.Rua, f.Comp, f.Bairro, f.Cidade, f.Estado);
            db.ExecuteNonQuery(sql);
        }

        public void Atualizar(Object o)
        {
            Fornecedor f = (Fornecedor)o;
            string qry = string.Format("UPDATE fornecedor SET nome = '{0}', cnpj = '{1}', tel1 = '{2}', tel2 = '{3}', cep = {4}, num = {5}, rua = '{6}', comp = '{7}', bairro = '{8}', cidade = '{9}', estado = '{10}' WHERE id = {11}", f.Nome, f.Cnpj, f.Telefone1, f.Telefone2, f.Cep, f.Num, f.Rua, f.Comp, f.Bairro, f.Cidade, f.Estado, f.Id);
            db.ExecuteNonQuery(qry);
        }

        public List<object> ListAll()
        {
            string qry = string.Format("SELECT id, nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado FROM fornecedor");
            DataSet ds = db.ExecuteQuery(qry);

            List<object> fs = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Fornecedor f = new Fornecedor();
                f.Id = int.Parse(dr["id"].ToString());
                f.Nome = dr["nome"].ToString();
                f.Cnpj = long.Parse(dr["cnpj"].ToString());
                f.Telefone1 = long.Parse(dr["tel1"].ToString());
                f.Telefone2 = long.Parse(dr["tel2"].ToString());
                f.Cep = long.Parse(dr["cep"].ToString());
                f.Num = int.Parse(dr["num"].ToString());
                f.Rua = dr["rua"].ToString();
                f.Comp = dr["comp"].ToString();
                f.Bairro = dr["bairro"].ToString();
                f.Cidade = dr["cidade"].ToString();
                f.Estado = dr["estado"].ToString();
                fs.Add(f);
            }
            return fs;
        }

        public Fornecedor Ler(int id)
        {
            string qry = string.Format("SELECT * FROM fornecedor WHERE id ={0}",id);
            DataSet ds = db.ExecuteQuery(qry);

            Fornecedor f = null;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                f = new Fornecedor();
                f.Id = int.Parse(dr["id"].ToString());
                f.Nome = dr["nome"].ToString();
                f.Cnpj = long.Parse(dr["cnpj"].ToString());
                f.Telefone1 = long.Parse(dr["tel1"].ToString());
                f.Telefone2 = long.Parse(dr["tel2"].ToString());
                f.Cep = long.Parse(dr["cep"].ToString());
                f.Num = int.Parse(dr["num"].ToString());
                f.Rua = dr["rua"].ToString();
                f.Comp = dr["comp"].ToString();
                f.Bairro = dr["bairro"].ToString();
                f.Cidade = dr["cidade"].ToString();
                f.Estado = dr["estado"].ToString();
            }
            return f;
        }

        public List<object> ListByName(string name)
        {
            string qry = string.Format("SELECT id, nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado FROM fornecedor WHERE nome LIKE '%{0}%'", name);
            DataSet ds = db.ExecuteQuery(qry);

            List<object> fs = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Fornecedor f = new Fornecedor();
                f.Id = int.Parse(dr["id"].ToString());
                f.Nome = dr["nome"].ToString();
                f.Cnpj = long.Parse(dr["cnpj"].ToString());
                f.Telefone1 = long.Parse(dr["tel1"].ToString());
                f.Telefone2 = long.Parse(dr["tel2"].ToString());
                f.Cep = long.Parse(dr["cep"].ToString());
                f.Num = int.Parse(dr["num"].ToString());
                f.Rua = dr["rua"].ToString();
                f.Comp = dr["comp"].ToString();
                f.Bairro = dr["bairro"].ToString();
                f.Cidade = dr["cidade"].ToString();
                f.Estado = dr["estado"].ToString();
                fs.Add(f);
            }
            return fs;
        }

        public List<object> ListByName(int id)
        {
            List<object> fs = new List<object>();
            return fs;
        }

        public int Remover(int idFornecedor)
        {
            //PROCURA PRODUTOS COM ID DO FORNECEDOR
            string qry = string.Format("SELECT idFornecedor FROM produtos WHERE idFornecedor = {0}", idFornecedor);
            DataSet ds = db.ExecuteQuery(qry);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                return 1;
            }

            if (idFornecedor != -1)
            {
                string qry1 = string.Format("DELETE FROM fornecedor WHERE id = {0}", idFornecedor);
                db.ExecuteNonQuery(qry1);
            }

            return 0;

        }

        //BUSCA NA TABELA FORNECEDOR PELO ULTIMO VALOR DO AUTO INCREMENTO
        public int GetId()
        {
            string qry = string.Format("SELECT `AUTO_INCREMENT` FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'controlx' AND TABLE_NAME = 'fornecedor'");
            DataSet ds = db.ExecuteQuery(qry);
            DataRow dr = ds.Tables[0].Rows[0];
            int idFornecedor = int.Parse(dr["AUTO_INCREMENT"].ToString());

            return idFornecedor;
        }
    }
}
