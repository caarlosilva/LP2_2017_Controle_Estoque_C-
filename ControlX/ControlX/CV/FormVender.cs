﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlX
{
    public partial class FormVender : Form
    {

        static IDao db = new DAO.ProdutoDao();
        static List<Object> ps = db.ListAll();

        public FormVender()
        {
            InitializeComponent();
            Auto_Complete();
            BtComplete();
        }

        private void BtComplete()
        {
            if (dgvVendas.RowCount <= 0)
            {
                btVender.Enabled = false;
                btDelItemVenda.Enabled = false;
                btCancelar.Enabled = false;
                txValorPago.Enabled = false;
            }
            else
            {
                btVender.Enabled = true;
                btDelItemVenda.Enabled = true;
                btCancelar.Enabled = true;
                txValorPago.Enabled = true;
            }
        }

        private void Auto_Complete()
        {
            txNome.AutoCompleteMode = AutoCompleteMode.Suggest;
            txNome.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();           
            //Adiciona sugestão de nomes ao digitar no TextBox
            foreach (Produto p in ps)
            {
                col.Add(p.Nome);
            }

            txNome.AutoCompleteCustomSource = col;
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void Limpar()
        {
            txNome.Text = "";
            txId.Text = "";
            lbPrecoShow.Text = "";
            lbQntdEstoqueShow.Text = "";
            txQntdVenda.Text = "";

        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void txNome_TextChanged(object sender, EventArgs e)
        {        
            foreach (Produto p in ps)
                if (txNome.Text.Trim() == p.Nome)
                {
                    txId.Text = Convert.ToString(p.Id);
                    lbPrecoShow.Text = Convert.ToString(p.Preco);
                    lbQntdEstoqueShow.Text = Convert.ToString(p.Qntd);
                    txQntdVenda.Text = "0";
                }
            
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {

            formEstoque formSearch = new formEstoque();
            formSearch.pnButtons.Visible = false;
            formSearch.btMenu.Text = "Voltar";
            formSearch.ShowDialog(this);

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {         
            dgvVendas.Rows.Clear();
            ps = db.ListAll();
            Limpar();
            lbValorTotal.Text = "";
            BtComplete();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int qVenda = int.Parse(txQntdVenda.Text); //Quantidade que sera vendida
            int qEstoque = int.Parse(lbQntdEstoqueShow.Text);//Quantidade no estoque
            int idProd = int.Parse(txId.Text);//Id do produto a ser adicionado a venda

            if (qVenda > qEstoque || qVenda <= 0)
                MessageBox.Show("Impossível vender " + qVenda + " Itens. A quantidade do produto no estoque é de " + qEstoque + "!", "Aviso!");
            else
            {
                foreach (Produto p in ps)
                {
                    if (p.Id == idProd)
                    {                      
                        //Preço da venda (QTD * PREÇO UNITARIO)
                        double pVenda = qVenda * p.Preco;
                        //Adicionando ao Data Grid View
                        dgvVendas.Rows.Add(p.Id, p.Nome, qVenda, pVenda);
                        //Valor Total Recebe o valor ja existente, caso esteja NULL, recebe 0
                        double vTotal = lbValorTotal.Text == "" ? 0 : double.Parse(lbValorTotal.Text);
                        //O Label com o Valor Total recebe ele mesmo, mais o Preço de Venda do item em questão
                        lbValorTotal.Text = Convert.ToString(vTotal + pVenda);

                        p.Qntd = p.Qntd - qVenda;

                        Limpar();
                        BtComplete();

                    }
                }
            }      
        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void pnForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btDelItemVenda_Click(object sender, EventArgs e)
        {
            if (dgvVendas.RowCount > 0)
            {
                int idProd = int.Parse(dgvVendas.Rows[dgvVendas.CurrentRow.Index].Cells[0].Value.ToString());
                int qntdProd = int.Parse(dgvVendas.Rows[dgvVendas.CurrentRow.Index].Cells[2].Value.ToString());
                double precoProd = double.Parse(dgvVendas.Rows[dgvVendas.CurrentRow.Index].Cells[3].Value.ToString());
                double vTotal = double.Parse(lbValorTotal.Text);

                foreach (Produto p in ps)
                {
                    if (p.Id == idProd)
                    {
                        p.Qntd += qntdProd;
                        lbValorTotal.Text = Convert.ToString(vTotal - precoProd);
                        dgvVendas.Rows.RemoveAt(dgvVendas.CurrentRow.Index);
                        BtComplete();
                        Limpar();
                    }
                }               
            }
        }

        private void txId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txQntdVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btVender_Click(object sender, EventArgs e)
        {
            int numProd = dgvVendas.RowCount;
            for(int i=0; i< numProd; i++)
            {
                int idProd = int.Parse(dgvVendas.Rows[i].Cells[0].Value.ToString());
                foreach(Produto p in ps)
                {
                    if(p.Id == idProd)
                    {
                        db.Atualizar(p);
                    }
                }
            }
            DialogResult result = MessageBox.Show("Venda Concluida com Sucesso !!!\n Deseja imprimir o Recibo do Cliente? ",
                "Venda Realizada",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Caso clique em sim
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
            
        }

        private void txTroco_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double Troco = double.Parse(txValorPago.Text) - double.Parse(lbValorTotal.Text);
                lbTrocoShow.Text = Convert.ToString(Troco);
            }
            catch (System.Exception)
            {

            }
        }
    }
}