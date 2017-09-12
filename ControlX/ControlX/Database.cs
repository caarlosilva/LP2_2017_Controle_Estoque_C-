using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    class Database : IDatabase
    {

        private static Dictionary<int, Produto> produtos = new Dictionary<int, Produto> ();

        public void Adicionar(Produto p)
        {
            produtos.Add(p.Id, p);
        }

        public void Atualizar(Produto p)
        {
            throw new NotImplementedException();
        }

        public Produto Ler(long idProduto)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListAll()
        {
            return ListByName("");
        }

        public List<Produto> ListByName(string name)
        {
            List<Produto> ps = new List<Produto>();

            foreach (KeyValuePair<int, Produto> k in produtos)
            {
                if (k.Value.Nome.Contains(name))
                    ps.Add(k.Value);
            }
            return ps;
        }

        public void Remover(long idProduto)
        {
            throw new NotImplementedException();
        }
    }
}
