using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes_Revisao_2._0
{
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }
        // criando Metodo Limpar
        private void Limpar()
        {
            txt_Id.Clear();
            txt_Preco.Clear();
            txt_Produto.Clear();
            txt_Quantidade.Clear();
        }
        // criando Meto obter Items
        private void Obter()
        {
            txt_Id.Text = lv_Produtos.SelectedItems[0].SubItems[0].Text;
            txt_Produto.Text = lv_Produtos.SelectedItems[0].SubItems[1].Text;
            txt_Quantidade.Text = lv_Produtos.SelectedItems[0].SubItems[2].Text;
            txt_Preco.Text = lv_Produtos.SelectedItems[0].SubItems[3].Text;
        }
        // botao Adiconar
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            // verificando se nenhum campo esta vazio
            if (txt_Id.Text == "")
            {
                MessageBox.Show("ID não poder ser vazio.");
                return;
            }
            if (txt_Preco.Text == "")
            {
                MessageBox.Show("Preço não pode ser vazio.");
                return;
            }
            if (txt_Produto.Text == "")
            {
                MessageBox.Show("Produto não pode ser vazio.");
                return;
            }
            if (txt_Quantidade.Text == "")
            {
                MessageBox.Show("Quantidade não pode ser vazio.");
                return;
            }

            // criando meu Array
            string[] pr = new string[4];
            pr[0] = txt_Id.Text;
            pr[1] = txt_Preco.Text;
            pr[2] = txt_Produto.Text;
            pr[3] = txt_Quantidade.Text;

            //criando lista
            ListViewItem l = new ListViewItem(pr);

            lv_Produtos.Items.Add(l);
            Limpar();


        }
        // botao Remover
        private void btn_Remover_Click(object sender, EventArgs e)
        {
            lv_Produtos.Items.RemoveAt(lv_Produtos.SelectedIndices[0]);
        }
        // botao Obter
        private void btn_Obter_Click(object sender, EventArgs e)
        {
            Obter();
        }
        // Criando Selected Obter
        private void lv_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_Produtos.SelectedIndices.Count > 0)
            {
                Obter();
            }
        }

        private void F_ListView_Load(object sender, EventArgs e)
        {

        }
    }
}
