using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    class ComprarDao : IDao
    {
        Database db = Database.GetInstance();

        public void Adicionar(object o)
        {
            Comprar c = (Comprar)o;
            string dataCompraMySql = c.DataCompra.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string dataEntregaMySql = c.DataEntrega.ToString("yyyy-MM-dd HH:mm:ss.fff");
            int status = c.Status ? 1 : 0;
            string sql = string.Format("INSERT INTO compras(nome_usuario, valor, status, dataCompra, dataEntrega) values('{0}',{1},{2},'{3}','{4}')","Ronaldo Lopes", c.Valor, status, dataCompraMySql, dataEntregaMySql);
            db.ExecuteNonQuery(sql);
            for(int i = 0; i < c.Itens.Count; i++)
            {
                sql = string.Format("INSERT INTO produtos_compra(idProduto, idCompra) values ({0},{1})", c.Itens[i].Id, c.Id);
                db.ExecuteNonQuery(sql);
            }
        }

        public void Atualizar(object o)
        {
            throw new NotImplementedException(); 
            //IMPOSSIVEL ATUALIZAR UMA COMPRA APÓS AGENDADA
            //ATUALIZAR SERÁ UTILIZADO APENAS PARA MUDAR O STATUS DA COMPRA DE NÂO ENTREGUE PARA FINALIZADO
        }

        public int GetId()
        {
            string qry = string.Format("SELECT `AUTO_INCREMENT` FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'controlx' AND TABLE_NAME = 'compras'");
            DataSet ds = db.ExecuteQuery(qry);
            DataRow dr = ds.Tables[0].Rows[0];
            int idUsuario = int.Parse(dr["AUTO_INCREMENT"].ToString());

            return idUsuario;
        }

        public List<object> ListAll()
        {
            throw new NotImplementedException(); 
            //IMPLEMENTAR P/ MOSTRAR NO HISTORICO, SEPARADOS POR FINALIZADOS(status = 1) E NÃO FINALIZADOS(status = 0)
        }

        public List<object> ListById(int id)
        {
            throw new NotImplementedException(); 
            // SEM USO PARA 'COMPRAR'
        }

        public List<object> ListByName(string name)
        {
            throw new NotImplementedException(); 
            // SEM USO PARA 'COMPRAR' , SERIA UTIL UM 'LISTBYDATE', mas da pra implementar em um form, não precisa de um método
        }

        public int Remover(int id)
        {
            throw new NotImplementedException(); 
            //OLHA, CREIO QUE NÃO TERA UTILIDADE 'APAGAR' UMA COMPRA, A MENOS QUE ELA SEJA CANCELADA ANTES DE ENTREGAR
            //E NO CASO EU NÃO SEI O QUE FAZER
        }
    }
}
