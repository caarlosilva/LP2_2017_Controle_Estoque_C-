using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    class Produto
    {
        private string nome;
        private int id;
        private double preco;
        private int qntd;
        Fornecedor fornecedor = new Fornecedor();

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }
        

        internal Fornecedor Fornecedor
        {
            get
            {
                return fornecedor;
            }

            set
            {
                fornecedor = value;
            }
        }

        public int Qntd
        {
            get
            {
                return qntd;
            }

            set
            {
               qntd = value;
            }
        }

        public Produto(string nome, int id, double preco, int qntd, Fornecedor fornecedor)
        {
            Nome = nome;
            Id = id;
            Preco = preco;
            Fornecedor = fornecedor;
            Qntd = qntd;
        }
        public Produto()
        {

        }
    }
}
