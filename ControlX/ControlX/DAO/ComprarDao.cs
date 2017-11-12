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
            int status = c.Status;
            string sql = string.Format("INSERT INTO compras(nome_usuario, valor, status, dataCompra, dataEntrega) values('{0}',{1},{2},'{3}','{4}')", c.Nome_usuario, c.Valor, status, dataCompraMySql, dataEntregaMySql);
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

        public List<object> ListCompras(DateTime dataInicio, DateTime dataFim)
        {
            string dataMySqlInicio = dataInicio.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string dataMySqlFim = dataFim.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string qry = string.Format("SELECT id, nome_usuario, valor, status, dataCompra, dataEntrega FROM compras WHERE dataCompra BETWEEN {0} AND {1}", dataMySqlInicio, dataMySqlFim);
            DataSet ds = db.ExecuteQuery(qry);

            List<object> compras = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Comprar c = new Comprar();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome_usuario = dr["nome_usuario"].ToString();
                c.Valor = long.Parse(dr["valor"].ToString());
                c.Status = int.Parse(dr["status"].ToString());
                c.DataCompra = DateTime.Parse(dr["dataCompra"].ToString());
                c.DataEntrega = DateTime.Parse(dr["dataEntrega"].ToString());
                compras.Add(c);
            }
            return compras;
        }

        public List<object> ListAll()
        {
            string qry = string.Format("SELECT id, nome_usuario, valor, status, dataCompra, dataEntrega FROM compras");
            DataSet ds = db.ExecuteQuery(qry);

            List<object> compras = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Comprar c = new Comprar();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome_usuario = dr["nome_usuario"].ToString();
                c.Valor = long.Parse(dr["valor"].ToString());
                c.Status = int.Parse(dr["status"].ToString());
                c.DataCompra = DateTime.Parse(dr["dataCompra"].ToString());
                c.DataEntrega = DateTime.Parse(dr["dataEntrega"].ToString());
                compras.Add(c);
            }
            return compras;
        }

        public List<object> ListProdutos(int id)
        {

            string qry = string.Format("SELECT pc.idCompra, pc.idProduto, p.nome AS nome_prod, p.preco AS preco_prod, p.qntd AS qtd_prod, p.tipoUn AS un_prod, f.nome AS nome_forn FROM (((compras c JOIN produtos_compra pc ON c.id = pc.idCompra) JOIN produtos p ON pc.idProduto = p.id) JOIN fornecedor f ON f.id = p.idFornecedor) WHERE c.id = {0}", id);
            DataSet ds = db.ExecuteQuery(qry);

            List<object> prods = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Produto p = new Produto();
                p.Id = int.Parse(dr["idProduto"].ToString());
                p.Nome = dr["nome_prod"].ToString();
                p.Preco = double.Parse(dr["preco_prod"].ToString());
                p.Qntd = double.Parse(dr["qtd_prod"].ToString());
                p.TipoUn = dr["un_prod"].ToString();
                p.Fornecedor.Nome = dr["nome_forn"].ToString();
                prods.Add(p);
            }
            return prods;
        }

        public List<object> ListById(int id)
        {
            string qry = string.Format("SELECT id, nome_usuario, valor, status, dataCompra, dataEntrega FROM compras WHERE id = {0}", id);
            DataSet ds = db.ExecuteQuery(qry);

            List<object> compras = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Comprar c = new Comprar();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome_usuario = dr["nome_usuario"].ToString();
                c.Valor = long.Parse(dr["valor"].ToString());
                c.Status = int.Parse(dr["status"].ToString());
                c.DataCompra = DateTime.Parse(dr["dataCompra"].ToString());
                c.DataEntrega = DateTime.Parse(dr["dataEntrega"].ToString());
                compras.Add(c);
            }
            return compras;
        }

        public List<object> ListByDate(DateTime inicio, DateTime fim)
        {
            throw new NotImplementedException(); 
            // SEM USO PARA 'COMPRAR' , SERIA UTIL UM 'LISTBYDATE', mas da pra implementar em um form, não precisa de um método
        }

        public int Remover(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> ListByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
