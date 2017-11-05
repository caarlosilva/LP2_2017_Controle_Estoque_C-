using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX.Modelo
{
    class Categoria
    {
        private int id;
        private string nome;
        private List<Produto> produtos = new List<Produto>();

        public string CategoriaFullName
        {
            get
            {
                return Id + " - " + Nome;
            }
        }

        public Categoria()
        {
        }

        public Categoria(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
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

        internal List<Produto> Produtos
        {
            get
            {
                return produtos;
            }

            set
            {
                produtos = value;
            }
        }
    }
}
