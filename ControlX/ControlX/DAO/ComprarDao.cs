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
            string dataEntregaMySql = c.DataEntrega.ToString("yyyy-MM-dd");

            int status = c.Status;

            string valor = Convert.ToString(c.Valor);
            if (valor.ToString().Contains(","))
            {
                valor = valor.Replace(",", ".");
            }

            string sql = string.Format("INSERT INTO compras(nome_usuario, valor, status, dataCompra, dataEntrega) values('{0}',{1},{2},'{3}','{4}')", c.Nome_usuario, valor, status, dataCompraMySql, dataEntregaMySql);
            db.ExecuteNonQuery(sql);

            for (int i = 0; i < c.Itens.Count; i++)
            {
                string preco = Convert.ToString(c.Itens[i].Preco);
                if (preco.ToString().Contains(","))
                {
                    preco = preco.Replace(",", ".");
                }

                string qntd = Convert.ToString(c.Itens[i].Qntd);
                if (qntd.ToString().Contains(","))
                {
                    qntd = qntd.Replace(",", ".");
                }

                sql = string.Format("INSERT INTO produtos_compra(idProduto, idCompra, qtdProduto, precoUnProduto) values ({0}, {1}, {2}, {3})", c.Itens[i].Id, c.Id, qntd, preco);
                db.ExecuteNonQuery(sql);
            }
        }

        public void Atualizar(object o)
        {
            DateTime data = DateTime.Now;
            string dataMySql = data.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Comprar c = (Comprar)o;
            string qry = string.Format("UPDATE compras SET status = 1, dataFinal = '{1}' WHERE id = {0}", c.Id, dataMySql);
            db.ExecuteQuery(qry);

            for (int i = 0; i < c.Itens.Count; i++)
            {
                string qntd = Convert.ToString(c.Itens[i].Qntd);
                if (qntd.ToString().Contains(","))
                {
                    qntd = qntd.Replace(",", ".");
                }
                string sql = string.Format("UPDATE produtos SET qntd = qntd + {0} WHERE id = {1}", qntd, c.Itens[i].Id);
                db.ExecuteNonQuery(sql);
            }
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
            string dataMySqlInicio = dataInicio.ToString("yyyy-MM-dd");
            string dataMySqlFim = dataFim.ToString("yyyy-MM-dd");
            string qry = string.Format("SELECT id, nome_usuario, valor, status, dataCompra, dataEntrega, dataFinal FROM compras WHERE dataCompra BETWEEN '{0}' AND '{1}'", dataMySqlInicio, dataMySqlFim);
            DataSet ds = db.ExecuteQuery(qry);

            List<object> compras = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Comprar c = new Comprar();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome_usuario = dr["nome_usuario"].ToString();
                c.Valor = double.Parse(dr["valor"].ToString());
                c.Status = int.Parse(dr["status"].ToString());
                c.DataCompra = DateTime.Parse(dr["dataCompra"].ToString());
                c.DataEntrega = DateTime.Parse(dr["dataEntrega"].ToString());
                if (c.Status == 1)               
                    c.DataFinal = DateTime.Parse(dr["dataFinal"].ToString());                
                compras.Add(c);
            }
            return compras;
        }

        public List<object> ListUltimasCompras()
        {
            string qry = string.Format("SELECT * FROM compras ORDER BY id DESC LIMIT 15");
            DataSet ds = db.ExecuteQuery(qry);

            List<object> compras = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (int.Parse(dr["status"].ToString()) == 1)
                {
                    Comprar c = new Comprar();
                    c.Id = int.Parse(dr["id"].ToString());
                    c.Nome_usuario = dr["nome_usuario"].ToString();
                    c.Valor = double.Parse(dr["valor"].ToString());
                    c.Status = int.Parse(dr["status"].ToString());
                    c.DataCompra = DateTime.Parse(dr["dataCompra"].ToString());
                    c.DataEntrega = DateTime.Parse(dr["dataEntrega"].ToString());
                    c.DataFinal = DateTime.Parse(dr["dataFinal"].ToString());
                    compras.Add(c);
                }
            }
            return compras;
        }

        public List<object> ListAll()
        {
            string qry = string.Format("SELECT id, nome_usuario, valor, status, dataCompra, dataEntrega, dataFinal FROM compras");
            DataSet ds = db.ExecuteQuery(qry);

            List<object> compras = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Comprar c = new Comprar();
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome_usuario = dr["nome_usuario"].ToString();
                c.Valor = double.Parse(dr["valor"].ToString());
                c.Status = int.Parse(dr["status"].ToString());
                c.DataCompra = DateTime.Parse(dr["dataCompra"].ToString());
                c.DataEntrega = DateTime.Parse(dr["dataEntrega"].ToString());
                if (c.Status == 1)
                    c.DataFinal = DateTime.Parse(dr["dataFinal"].ToString());
                compras.Add(c);
            }
            return compras;
        }

        public List<object> ListProdutos(int id)
        {

            string qry = string.Format("SELECT pc.idCompra, pc.idProduto, p.nome AS nome_prod, pc.precoUnProduto AS preco_prod, pc.qtdProduto AS qtd_prod, p.tipoUn AS un_prod, f.nome AS nome_forn FROM (((compras c JOIN produtos_compra pc ON c.id = pc.idCompra) JOIN produtos p ON pc.idProduto = p.id) JOIN fornecedor f ON f.id = p.idFornecedor) WHERE c.id = {0}", id);
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
            string qry = string.Format("SELECT id, nome_usuario, valor, status, dataCompra, dataEntrega, dataFinal FROM compras WHERE id = {0}", id);
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
                if (c.Status == 1)
                    c.DataFinal = DateTime.Parse(dr["dataFinal"].ToString());
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
