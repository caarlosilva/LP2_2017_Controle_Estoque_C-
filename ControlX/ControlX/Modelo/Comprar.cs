using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    class Comprar
    {
        private int id;
        private string nome_usuario;
        private long valor;
        private List<Produto> itens = new List<Produto>();
        private DateTime dataCompra;
        private DateTime dataEntrega;

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

        public string Nome_usuario
        {
            get
            {
                return nome_usuario;
            }

            set
            {
                nome_usuario = value;
            }
        }

        public long Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        internal List<Produto> Itens
        {
            get
            {
                return itens;
            }

            set
            {
                itens = value;
            }
        }

        public DateTime DataCompra
        {
            get
            {
                return dataCompra;
            }

            set
            {
                dataCompra = value;
            }
        }

        public DateTime DataEntrega
        {
            get
            {
                return dataEntrega;
            }

            set
            {
                dataEntrega = value;
            }
        }

        public Comprar()
        {

        }

        public Comprar(int id, string nome_usuario, long valor, List<Produto> itens, DateTime dataCompra, DateTime dataEntrega)
        {
            this.Id = id;
            this.Nome_usuario = nome_usuario;
            this.Valor = valor;
            this.Itens = itens;
            this.DataCompra = dataCompra;
            this.DataEntrega = dataEntrega;
        }
    }
}
