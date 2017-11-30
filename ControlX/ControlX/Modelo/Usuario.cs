using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    public class Usuario
    {
        private int id;
        private string nome;
        private long cpf;
        private char sexo;
        private DateTime dataNasc;
        private long telefone1;
        private long telefone2;
        private long cep;
        private long num;
        private string rua;
        private string comp;
        private string bairro;
        private string cidade;
        private string estado;
        private string cargo;
        private string login;
        private string senha;

        public string UsuarioFullName
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

        public char Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public DateTime DataNasc
        {
            get
            {
                return dataNasc;
            }

            set
            {
                dataNasc = value;
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

        public string Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
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

        public Usuario()
        {

        }

        public Usuario(int id, string nome, DateTime datanasc, long cpf, long telefone1, long telefone2, long cep, long num, string rua, string comp, string bairro, string cidade, string estado, string cargo, string login, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.DataNasc = dataNasc;
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
            this.Cargo = cargo;
            this.Login = login;
            this.Senha = senha;
        }

        public Usuario(int id, string nome, long cpf, char sexo, DateTime dataNasc, long telefone1, long telefone2, long cep, long num, string rua, string comp, string bairro, string cidade, string estado, string cargo, string login, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Sexo = sexo;
            this.DataNasc = dataNasc;
            this.Telefone1 = telefone1;
            this.Telefone2 = telefone2;
            this.Cep = cep;
            this.Num = num;
            this.Rua = rua;
            this.Comp = comp;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Cargo = cargo;
            this.Login = login;
            this.Senha = senha;
        }
    }
}
