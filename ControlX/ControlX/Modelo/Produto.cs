using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlX.Modelo;

namespace ControlX
{
    class Produto
    {
        private string nome;
        private int id;
        private double preco;
        private int qntd;
        private Modelo.Categoria cat = new Modelo.Categoria();
        
        //private int idFornecedor;
        private Fornecedor fornecedor = new Fornecedor();

        public string FornecedorFullName
        {
            get
            {
                return Fornecedor.Id + " - " + Fornecedor.Nome; 
            }
        }

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

        public Fornecedor Fornecedor
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

        internal Categoria Cat
        {
            get
            {
                return cat;
            }

            set
            {
                cat = value;
            }
        }

        /*public int IdFornecedor
        {
            get
            {
                return idFornecedor;
            }

            set
            {
                idFornecedor = value;
            }
        }*/

        public Produto()
        {

        }

        public Produto(string nome, int id, double preco, int qntd, Fornecedor f, Categoria cat)
        {
            this.nome = nome;
            this.id = id;
            this.preco = preco;
            this.qntd = qntd;
            this.Fornecedor = f;
            this.cat = cat;
        }
    }
}
