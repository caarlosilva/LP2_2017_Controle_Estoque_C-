using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    interface IDao
    {
/*              void Adicionar(Produto p);

                void Atualizar(Produto p);

                Produto getProduto(int i);

                void Remover(int idProduto);

                List<Produto> ListAll();

                List<Produto> ListByName(string name);

                List<Produto> ListByName(int id);

                int GetIdProduto();*/

                //FORNECEDOR

                void Adicionar(object f);

                void Atualizar(object f);

                void Remover(int id);

                List<Object> ListAll();

                List<Object> ListByName(string name);

                List<Object> ListByName(int id);

                int GetId();
    }
}
