using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Componentes_Revisao_2._0
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }
        // botao definir
        private void btn_Definir_Click(object sender, EventArgs e)
        {   // verificando se o valor é maior ou menor que o maximo
            if (int.Parse(txt_Valor.Text) >= progressBar1.Minimum &
                int.Parse(txt_Valor.Text) <= progressBar1.Maximum)
                progressBar1.Value = int.Parse(txt_Valor.Text);
        }
        // botao preencher
        private void btn_Preencher_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = int.Parse(txt_Maximo.Text);
            // loop
            for (int i=0; i <= int.Parse(txt_Maximo.Text); i++)
            {
                label1.Text = i.ToString();
                progressBar1.Value = i;
               // Thread.Sleep(200);
            }
        }
    }
}
