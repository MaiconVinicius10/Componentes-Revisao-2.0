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
    public partial class F_ListBox : Form
    {   // criando a lista de carro
        List<string> Carro = new List<string>();

        // criando metodo Atualizar a lista
        private void Atualização(ListBox lb,List<string> l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }

        public F_ListBox()
        {
            InitializeComponent();
            // Adicionando Dados a lista
            Carro.Add("HRV");
            Carro.Add("Golf");
            Carro.Add("Focus");
            // atualizo
            lb_Carros.DataSource = Carro;
        }
        // botao adiconar
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {  // verifico antes de adicionar se campo esta vazio
            if (txt_Carro.Text == "")
            {
                MessageBox.Show("Campo vazio, digite um veiculo.","Atenção");
                txt_Carro.Focus();
            }
            else
            {   // adiciono e atualizo
                Carro.Add(txt_Carro.Text);
                Atualização(lb_Carros,Carro);
                txt_Carro.Clear();
                txt_Carro.Focus();

            }
        }
        // botao Remover selecionado
        private void btn_Remover_Click(object sender, EventArgs e)
        {   // verifico e removo
            if(lb_Carros.SelectedIndex >= 0)
            {
                Carro.RemoveAt(lb_Carros.SelectedIndex);
                Atualização(lb_Carros, Carro);
            }
            else
            {
                return;
            }
        }
        // obter o selecionado
        private void btn_Obter_Click(object sender, EventArgs e)
        {
            txt_Carro.Text = Carro[lb_Carros.SelectedIndex];
        }
        // botao limpar tudo
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Carro.Clear();
            txt_Carro.Clear();
            Atualização(lb_Carros,Carro);
        }

        private void F_ListBox_Load(object sender, EventArgs e)
        {

        }
    }
}
