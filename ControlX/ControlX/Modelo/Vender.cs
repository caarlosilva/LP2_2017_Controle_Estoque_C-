using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    class Vender
    {
        private int id;
        private string nome_usuario;
        private double valor;
        private List<Produto> itens = new List<Produto>();
        private DateTime data;

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

        public double Valor
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

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public Vender(int id, string nome_usuario, double valor, List<Produto> itens, DateTime data)
        {
            this.Id = id;
            this.Nome_usuario = nome_usuario;
            this.Valor = valor;
            this.Itens = itens;
            this.Data = data;
        }

        public Vender()
        {
        }
    }
}
