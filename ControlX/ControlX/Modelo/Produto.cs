﻿using System;
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
        private double qntd;
        private string tipoUn;
        private Categoria cat = new Categoria();
        
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

        public double Qntd
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

        public string TipoUn
        {
            get
            {
                return tipoUn;
            }

            set
            {
                tipoUn = value;
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

        public Categoria Cat
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

        public Produto()
        {

        }

        public Produto(string nome, int id, double preco, double qntd,string tipoUn, Fornecedor f, Categoria cat)
        {
            this.Nome = nome;
            this.Id = id;
            this.Preco = preco;
            this.Qntd = qntd;
            this.TipoUn = tipoUn;
            this.Fornecedor = f;
            this.Cat = cat;
        }
    }
}
