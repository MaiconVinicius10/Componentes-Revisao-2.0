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
    public partial class F_RadioButton : Form
    {
        public F_RadioButton()
        {
            InitializeComponent();
        }
        // botao selecionado
        private void btn_Selecionados_Click(object sender, EventArgs e)
        {   // criando variavel
            string txt="";
            // recebendo na variavel o radion selecionado
            txt = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            txt_Selecionados.Text = txt;

            MessageBox.Show(txt);
        }
        // botao selecionado forma 2
        private void btn_Selecionados2_Click(object sender, EventArgs e)
        {   //criando variavel
            string txt="";
            // usando foreach pra pecorrer qual selecionado
            foreach(RadioButton rd in groupBox1.Controls)
            {
                if (rd.Checked)
                {
                    txt = rd.Text;
                }
            }
            // exibindo
            txt_Selecionados.Text = txt;
            MessageBox.Show(txt);
        }
    }
}
