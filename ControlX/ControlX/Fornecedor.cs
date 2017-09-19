using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlX
{
    class Fornecedor : Database
    {
        private int id;
        private long cnpj;
        private long telefone1;
        private long telefone2;
        private long cep;
        private string rua;
        private string comp;
        private string bairro;
        private string cidade;
        private string estado;
        private string nome;

        public Fornecedor()
        {

        }

        public Fornecedor(int id, long cpnj, long telefone1, long telefone2, long cep, string rua, string comp, string bairro, string cidade, string estado, string nome)
        {
            this.id = id;
            this.cnpj = cpnj;
            this.telefone1 = telefone1;
            this.telefone2 = telefone2;
            this.cep = cep;
            this.rua = rua;
            this.comp = comp;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.nome = nome;
        }

        public int Id { get => id; set => id = value; }
        public long Cnpj { get => cnpj; set => cnpj = value; }
        public long Telefone1 { get => telefone1; set => telefone1 = value; }
        public long Telefone2 { get => telefone2; set => telefone2 = value; }
        public long Cep { get => cep; set => cep = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Comp { get => comp; set => comp = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
