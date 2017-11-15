using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    class VenderDao : IDao
    {

        Database db = Database.GetInstance();

        public void Adicionar(Object o)
        {
            Vender v = (Vender)o;
            string dataMySql = v.Data.ToString("yyyy-MM-dd HH:mm:ss.fff");

            string valor = Convert.ToString(v.Valor);

            if (valor.ToString().Contains(","))
            {
                valor = valor.Replace(",", ".");
            }

            string sql = string.Format("INSERT INTO vendas(nome_usuario, valor, dataVenda) values('{0}',{1},'{2}')", v.Nome_usuario, valor, dataMySql);
            db.ExecuteNonQuery(sql);
            for (int i = 0; i < v.Itens.Count; i++)
            {
                string preco = Convert.ToString(v.Itens[i].Preco);
                if (preco.ToString().Contains(","))
                {
                    preco = preco.Replace(",", ".");
                }

                sql = string.Format("INSERT INTO produtos_venda(idProduto, idVenda, qtdProduto, precoUnProduto) values ({0}, {1}, {2}, {3})", v.Itens[i].Id, v.Id, v.Itens[i].Qntd, preco);
                db.ExecuteNonQuery(sql);
            }
        }

        public void Atualizar(object f)
        {
            throw new NotImplementedException();
        }

        public int GetId()
        {
            string qry = string.Format("SELECT `AUTO_INCREMENT` FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'controlx' AND TABLE_NAME = 'vendas'");
            DataSet ds = db.ExecuteQuery(qry);
            DataRow dr = ds.Tables[0].Rows[0];
            int idUsuario = int.Parse(dr["AUTO_INCREMENT"].ToString());

            return idUsuario;
        }

        public List<object> ListVendas(DateTime dataInicio, DateTime dataFim)
        {
            string dataMySqlInicio = dataInicio.ToString("yyyy-MM-dd");
            string dataMySqlFim = dataFim.ToString("yyyy-MM-dd");
            string qry = string.Format("SELECT id, nome_usuario, valor, dataVenda FROM vendas WHERE dataVenda BETWEEN '{0}' AND '{1}'", dataMySqlInicio, dataMySqlFim);
            DataSet ds = db.ExecuteQuery(qry);

            List<object> vendas = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Vender v = new Vender();
                v.Id = int.Parse(dr["id"].ToString());
                v.Nome_usuario = dr["nome_usuario"].ToString();
                v.Valor = long.Parse(dr["valor"].ToString());
                v.Data = DateTime.Parse(dr["dataVenda"].ToString());
                vendas.Add(v);
            }
            return vendas;
        }

        public List<object> ListAll()
        {
            string qry = string.Format("SELECT id, nome_usuario, valor, dataVenda FROM vendas");
            DataSet ds = db.ExecuteQuery(qry);

            List<object> vendas = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Vender v = new Vender();
                v.Id = int.Parse(dr["id"].ToString());
                v.Nome_usuario = dr["nome_usuario"].ToString();
                v.Valor = double.Parse(dr["valor"].ToString());
                v.Data = DateTime.Parse(dr["dataVenda"].ToString());
                vendas.Add(v);
            }
            return vendas;
        }

        public List<object> ListProdutos(int id)
        {

            string qry = string.Format("SELECT pv.idVenda, pv.idProduto, p.nome AS nome_prod, pv.precoUnProduto AS preco_prod, pv.qtdProduto AS qtd_prod, p.tipoUn AS un_prod, f.nome AS nome_forn FROM (((vendas v JOIN produtos_venda pv ON v.id = pv.idVenda) JOIN produtos p ON pv.idProduto = p.id) JOIN fornecedor f ON f.id = p.idFornecedor) WHERE v.id = {0}", id);
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
            string qry = string.Format("SELECT id, nome_usuario, valor, dataVenda FROM vendas WHERE id = {0}", id);
            DataSet ds = db.ExecuteQuery(qry);

            List<object> vendas = new List<object>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Vender v = new Vender();
                v.Id = int.Parse(dr["id"].ToString());
                v.Nome_usuario = dr["nome_usuario"].ToString();
                v.Valor = long.Parse(dr["valor"].ToString());
                v.Data = DateTime.Parse(dr["dataVenda"].ToString());
                vendas.Add(v);
            }
            return vendas;
        }

        public List<object> ListByDate(DateTime inicio, DateTime fim)
        {
            throw new NotImplementedException();
            // SEM USO PARA 'COMPRAR' , SERIA UTIL UM 'LISTBYDATE', mas da pra implementar em um form, não precisa de um método
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
