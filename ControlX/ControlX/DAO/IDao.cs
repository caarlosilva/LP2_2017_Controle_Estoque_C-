using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    interface IDao
    {
                void Adicionar(object f);

                void Atualizar(object f);

                int Remover(int id);

                List<Object> ListAll();

                List<Object> ListByName(string name);

                List<Object> ListById(int id);

                int GetId();
                
    }
}
