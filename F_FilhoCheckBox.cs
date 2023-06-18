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
    public partial class F_FilhoCheckBox : Form
    {   // criando fp do combo global
        F_CheckBox fp;
        public F_FilhoCheckBox()
        {
            InitializeComponent();
            // inializando meu global com aplicantio forms
            fp = Application.OpenForms["F_CheckBox"] as F_CheckBox;
            /// setando os selecionados 
            Cb_Carro.Checked = fp.Cb_Carro.Checked;
            Cb_Aviao.Checked = fp.Cb_Aviao.Checked;
            Cb_Navio.Checked = fp.Cb_Navio.Checked;
            Cb_Onibus.Checked = fp.Cb_Onibus.Checked;
        }
        // alterando checkbox Carro
        private void Cb_Carro_CheckedChanged(object sender, EventArgs e)
        {
            fp.Cb_Carro.Checked = Cb_Carro.Checked;

        }
        // alterando checkbox Aviao
        private void Cb_Aviao_CheckedChanged(object sender, EventArgs e)
        {
            fp.Cb_Aviao.Checked = Cb_Aviao.Checked;
        }
        // alterando checkbox Navio
        private void Cb_Navio_CheckedChanged(object sender, EventArgs e)
        {
            fp.Cb_Navio.Checked = Cb_Navio.Checked;
        }
        // alterando checkbox Onibus
        private void Cb_Onibus_CheckedChanged(object sender, EventArgs e)
        {
            fp.Cb_Onibus.Checked = Cb_Onibus.Checked;
        }

        private void F_FilhoCheckBox_Load(object sender, EventArgs e)
        {

        }
    }
}
