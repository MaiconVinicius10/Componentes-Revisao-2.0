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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }
        // botao confirmar
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            String msg = maskedTextBox1.Text;
            MessageBox.Show(msg);
        }

        private void F_MaskedTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
