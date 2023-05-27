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
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }
        //botão definir valor
        private void btn_DifinirValor_Click(object sender, EventArgs e)
        {   if ( 
                (Decimal.Parse(txt_Valor.Text) >= numericUpDown1.Minimum) &
                (Decimal.Parse(txt_Valor.Text) <= numericUpDown1.Maximum))
            numericUpDown1.Value = Decimal.Parse(txt_Valor.Text);
        }

        private void F_NumericUpDown_Load(object sender, EventArgs e)
        {

        }
    }
}
