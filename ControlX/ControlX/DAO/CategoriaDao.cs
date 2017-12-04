using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ControlX.DAO
{
    class CategoriaDao : IDao
    {
        Database db = Database.GetInstance();

        public void Adicionar(object f)
        {
            Modelo.Categoria c = (Modelo.Categoria)f;
            string sql = string.Format("INSERT INTO categoria(nome) values ('{0}')", c.Nome);
            db.ExecuteNonQuery(sql);
        }

        public void Atualizar(object f)
        {
            Modelo.Categoria c = (Modelo.Categoria)f;
            string qry = string.Format("UPDATE categoria SET nome = '{0}' WHERE id = {1}", c.Nome, c.Id);
            db.ExecuteNonQuery(qry);
        }

        public Modelo.Categoria Ler(int id)
        {
            string qry = string.Format("SELECT * FROM categoria WHERE id = {0} AND deleted_at is null", id);
            DataSet ds = db.ExecuteQuery(qry);

            Modelo.Categoria c = null;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                c = new Modelo.Categoria();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome = dr["nome"].ToString();
            }
            return c;
        }

        public int GetId()
        {
            string qry = string.Format("SELECT `AUTO_INCREMENT` FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'controlx' AND TABLE_NAME = 'categoria'");
            DataSet ds = db.ExecuteQuery(qry);
            DataRow dr = ds.Tables[0].Rows[0];
            int idCategoria = int.Parse(dr["AUTO_INCREMENT"].ToString());

            return idCategoria;
        }

        public List<object> ListAll()
        {
            string qry = string.Format("SELECT id, nome FROM categoria WHERE deleted_at is null");
            DataSet ds = db.ExecuteQuery(qry);

            List<object> fs = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Modelo.Categoria c = new Modelo.Categoria();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome = dr["nome"].ToString();
                fs.Add(c);
            }
            return fs;
        }

        public List<object> ListById(int id)
        {
            string qry = string.Format("SELECT id, nome FROM categoria WHERE deleted_at is null AND id = {0}", id);
            DataSet ds = db.ExecuteQuery(qry);

            List<object> fs = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Modelo.Categoria c = new Modelo.Categoria();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome = dr["nome"].ToString();
                fs.Add(c);
            }
            return fs;
        }

        public List<object> ListByName(string name)
        {
            string qry = string.Format("SELECT id, nome FROM categoria WHERE nome LIKE '%{0}%' AND deleted_at is null", name);
            DataSet ds = db.ExecuteQuery(qry);

            List<object> fs = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Modelo.Categoria c = new Modelo.Categoria();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome = dr["nome"].ToString();
                fs.Add(c);
            }
            return fs;
        }

        public int Remover(int idCategoria)
        {
            //PROCURA PRODUTOS COM ID DA CATEGORIA
            string qry = string.Format("SELECT idCategoria FROM produtos WHERE idCategoria = {0} AND deleted_at is null;", idCategoria);
            DataSet ds = db.ExecuteQuery(qry);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                return 1;
            }

            if (idCategoria != -1)
            {
                string dataMySql = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string qry1 = string.Format("UPDATE categoria SET deleted_at = '{0}' WHERE id = {1}", dataMySql, idCategoria);
                db.ExecuteNonQuery(qry1);
            }

            return 0;
        }

    }
}
