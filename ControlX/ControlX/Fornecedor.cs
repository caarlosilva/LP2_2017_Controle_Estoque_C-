using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    class Fornecedor
    {
        private int id;
        private string nome;
        private long cnpj;
        private long telefone1;
        private long telefone2;
        private long cep;
        private long num;
        private string rua;
        private string comp;
        private string bairro;
        private string cidade;
        private string estado;

        public string FornecedorFullName
        {
            get
            {
                return Id + " - " + Nome;
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

        public long Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        public long Telefone1
        {
            get
            {
                return telefone1;
            }

            set
            {
                telefone1 = value;
            }
        }

        public long Telefone2
        {
            get
            {
                return telefone2;
            }

            set
            {
                telefone2 = value;
            }
        }

        public long Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public long Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }

        public string Rua
        {
            get
            {
                return rua;
            }

            set
            {
                rua = value;
            }
        }

        public string Comp
        {
            get
            {
                return comp;
            }

            set
            {
                comp = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
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

        public Fornecedor()
        {

        }

        public Fornecedor(int id, long cpnj, long telefone1, long telefone2, long cep, long num, string rua, string comp, string bairro, string cidade, string estado, string nome)
        {
            this.Id = id;
            this.Cnpj = cpnj;
            this.Telefone1 = telefone1;
            this.Telefone2 = telefone2;
            this.Cep = cep;
            this.Rua = rua;
            this.Comp = comp;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Nome = nome;
            this.Num = num;
        }

        public Fornecedor(int id, long cpnj, long telefone1, long cep, long num, string rua, string comp, string bairro, string cidade, string estado, string nome)
        {
            this.Id = id;
            this.Cnpj = cpnj;
            this.Telefone1 = telefone1;
            this.Cep = cep;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Nome = nome;
            this.Num = num;
        }

    }
}
