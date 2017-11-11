using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    class VenderDao : IDao
    {

        Database db = Database.GetInstance();

        public void Adicionar(object o)
        {
            Vender v = (Vender)o;
            string dataCompraMySql = v.Data.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string sql = string.Format("INSERT INTO vendas(nome_usuario, valor, dataVenda) values('{0}',{1},{2})", v.Nome_usuario, v.Valor, dataCompraMySql);
            db.ExecuteNonQuery(sql);
            for (int i = 0; i < v.Itens.Count; i++)
            {
                sql = string.Format("INSERT INTO produtos_venda(idProduto, idVenda) values ({0},{1})", v.Itens[i].Id, v.Id);
                db.ExecuteNonQuery(sql);
            }
        }

        public void Atualizar(object f)
        {
            throw new NotImplementedException();
        }

        public int GetId()
        {
            throw new NotImplementedException();
        }

        public List<object> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<object> ListById(int id)
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
    }
}
