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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }
        //Botao mostrar o Selecionado
        private void btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_Transportes.Text);
        }
        //botao Limpar
        private void btn_LimparElementos_Click(object sender, EventArgs e)
        {
            cb_Transportes.Items.Clear();
        }
        //Botao Restar Dados
        private void btn_ResetarElementos_Click(object sender, EventArgs e)
        {   //apagar os items
            cb_Transportes.Items.Clear();
            //adiconar items
            cb_Transportes.Items.Add("Carro");
            cb_Transportes.Items.Add("Avião");
            cb_Transportes.Items.Add("Návio");
            cb_Transportes.Items.Add("Ônibus");
            cb_Transportes.Items.Add("Trem");
        }

        private void btn_AdicionarNovoTransporte_Click(object sender, EventArgs e)
        {
            if (txt_NovoTransporte.Text != "")
            {
                if (cb_Transportes.FindString(txt_NovoTransporte.Text) < 0)
                {
                    cb_Transportes.Items.Add(txt_NovoTransporte.Text);
                    MessageBox.Show("Novo transporte adicionado com Sucesso!","Tranporte");
                }
            }
            else
            {
                MessageBox.Show("Campo vazio , digite o nome do veiculo desejado.", "Atenção!");
            }
            txt_NovoTransporte.Clear();
            txt_NovoTransporte.Focus();
        }

        private void F_ComboBox_Load(object sender, EventArgs e)
        {

        }
    }
}
