using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX.DAO
{
    class UsuarioDao : IDao
    {
        Database db = Database.GetInstance();

        public void Adicionar(Object o)
        {
            Usuario u = (Usuario)o;
            string dataMySql = u.DataNasc.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string sql = string.Format("INSERT INTO usuario(nome, cpf, sexo, dataNasc, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado, cargo, login, senha) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", u.Nome, u.Cpf, u.Sexo, dataMySql, u.Telefone1, u.Telefone2, u.Cep, u.Num, u.Rua, u.Comp, u.Bairro, u.Cidade, u.Estado, u.Cargo, u.Login, u.Senha);
            db.ExecuteNonQuery(sql);
        }

        public void Atualizar(object f)
        {
            throw new NotImplementedException();
        }

        public List<object> ListAll()
        {
            string qry = string.Format("SELECT id, nome, cpf, sexo, dataNasc, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado, cargo, login, senha FROM usuario");
            DataSet ds = db.ExecuteQuery(qry);

            List<object> user = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Usuario u = new Usuario();
                u.Id = int.Parse(dr["id"].ToString());
                u.Nome = dr["nome"].ToString();
                u.Cpf = long.Parse(dr["cpf"].ToString());
                u.Sexo = char.Parse(dr["sexo"].ToString());
                u.DataNasc = DateTime.Parse(dr["dataNasc"].ToString());
                u.Telefone1 = long.Parse(dr["tel1"].ToString());
                u.Telefone2 = long.Parse(dr["tel2"].ToString());
                u.Cep = long.Parse(dr["cep"].ToString());
                u.Num = int.Parse(dr["num"].ToString());
                u.Rua = dr["rua"].ToString();
                u.Comp = dr["comp"].ToString();
                u.Bairro = dr["bairro"].ToString();
                u.Cidade = dr["cidade"].ToString();
                u.Estado = dr["estado"].ToString();
                u.Cargo = dr["cargo"].ToString();
                u.Login = dr["login"].ToString();
                u.Senha = dr["senha"].ToString();
                user.Add(u);
            }
            return user;
        }

        public List<object> ListByName(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> ListByName(string name)
        {
            throw new NotImplementedException();
        }

        public int Remover(int id)
        {
            throw new NotImplementedException();
        }

        //BUSCA NA TABELA PRODUTOS PELO ULTIMO VALOR DO AUTO INCREMENTO
        public int GetId()
        {
            string qry = string.Format("SELECT `AUTO_INCREMENT` FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'controlx' AND TABLE_NAME = 'usuario'");
            DataSet ds = db.ExecuteQuery(qry);
            DataRow dr = ds.Tables[0].Rows[0];
            int idUsuario = int.Parse(dr["AUTO_INCREMENT"].ToString());

            return idUsuario;
        }
        //FIM METODOS PRODUTO

    }
}
