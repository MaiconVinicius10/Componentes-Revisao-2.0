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
    public partial class F_CheckListBox : Form
    {
        public F_CheckListBox()
        {
            InitializeComponent();
        }
        // botao Mostrar Selecionados
        private void btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {   // crinado string recber dado
            string txt = "";
            // crinado foreach verificar lista
            foreach (string t in Clb_Tranportes.CheckedItems)
            {
                txt += t + ", ";
            }
            MessageBox.Show(txt);

        }
        // botao Limpar lista
        private void btn_LimparLista_Click(object sender, EventArgs e)
        {
            Clb_Tranportes.Items.Clear();
        }
        //Botao Resetar Lista
        private void btn_RestarLista_Click(object sender, EventArgs e)
        {  // criando uma lista
            List<string> lista = new List<string>();
            //apagando dados antigos
            Clb_Tranportes.Items.Clear();
            //adicionando dados na lista
            lista.Add("Carro");
            lista.Add("Avião");
            lista.Add("Navio");
            lista.Add("Ônibus");
            lista.Add("Trem");
            //setando os dados
            Clb_Tranportes.Items.AddRange(lista.ToArray());

        }
        // botao adicionar novo Transporte
        private void btn_NovoTransporte_Click(object sender, EventArgs e)
        {
            Clb_Tranportes.Items.Add(txt_TransporteNovo.Text);

            txt_TransporteNovo.Clear();
            txt_TransporteNovo.Focus();
        }
    }
}
