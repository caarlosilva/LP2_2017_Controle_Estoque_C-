using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    interface IDatabase
    {
        void Adicionar();

        void Atualizar();

        Produto Imprimir(long idProduto);

        void Remover(long idProduto);

        List<Produto> ListAll();

        List<Produto> ListByName(string name);
    }
}
