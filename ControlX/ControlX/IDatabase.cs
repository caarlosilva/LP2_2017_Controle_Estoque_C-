using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    interface IDatabase
    {
        void Adicionar(Produto p);

        void Atualizar(Produto p);

        Produto getProduto(int i);

        void Remover(int idProduto);

        List<Produto> ListAll();

        List<Produto> ListByName(string name);

        List<Produto> ListByName(int id);

        int GetIdProduto();

        //FORNECEDOR

        void Adicionar(Fornecedor p);

        void Atualizar(Fornecedor p);

        Fornecedor getFornecedor(Fornecedor p);

        void Remover(Fornecedor p);

        List<Fornecedor> ListAllF();

        List<Fornecedor> ListByNameF(string name);

        int GetIdFornecedor();
    }
}
