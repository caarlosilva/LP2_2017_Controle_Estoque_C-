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
        private static Dictionary<int, Fornecedor> fornecedor = new Dictionary<int, Fornecedor>();

        public void Adicionar(Produto p)
        {
            produtos.Add(p.Id, p);
        }

        public void Adicionar(Fornecedor p)
        {
            fornecedor.Add(p.Id, p);
        }

        public void Atualizar(Produto p)
        {
            produtos[p.Id] = p; 
        }

        public void Atualizar(Fornecedor p)
        {
            fornecedor[p.Id] = p;
        }

        public Produto getProduto(int i)
        {
            return produtos[i];
        }

        public Produto Ler(int idProduto)
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

        public void Remover(int idProduto)
        {
            produtos.Remove(idProduto);
        }

        public void Remover(Fornecedor f)
        {
            fornecedor.Remove(f.Id);
        }
    }
}
