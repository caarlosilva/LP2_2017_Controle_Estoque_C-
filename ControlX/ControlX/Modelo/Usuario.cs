using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    class Usuario
    {
        private int id;
        private string nome;
        private long cpf;
        private DateTime datanasc;
        private long telefone1;
        private long telefone2;
        private long cep;
        private long num;
        private string rua;
        private string comp;
        private string bairro;
        private string cidade;
        private string estado;
        private string login;
        private string senha;

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

        public long Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
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

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public DateTime Datanasc
        {
            get
            {
                return datanasc;
            }

            set
            {
                datanasc = value;
            }
        }

        public Usuario(int id, string nome, DateTime datanasc, long cpf, long telefone1, long telefone2, long cep, long num, string rua, string comp, string bairro, string cidade, string estado, string usuario, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Datanasc = datanasc;
            this.Cpf = cpf;
            this.Telefone1 = telefone1;
            this.Telefone2 = telefone2;
            this.Cep = cep;
            this.Num = num;
            this.Rua = rua;
            this.Comp = comp;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Login = login;
            this.Senha = senha;
        }
    }
}
