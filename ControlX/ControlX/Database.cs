using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    class Database : IDatabase
    {

        private Dictionary<int, Produto> produtos = new Dictionary<int, Produto> ();

        public void Adicionar()
        {
            throw new NotImplementedException();
        }

        public void Atualizar()
        {
            throw new NotImplementedException();
        }

        public Produto Imprimir(long idProduto)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Remover(long idProduto)
        {
            throw new NotImplementedException();
        }
    }
}
