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
    public partial class F_CheckBox : Form
    {   // criando minha lista checkbox
        List<CheckBox> checkBoxes = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            // adicionando dados a lista
            checkBoxes.Add(Cb_Aviao);
            checkBoxes.Add(Cb_Carro);
            checkBoxes.Add(Cb_Navio);
            checkBoxes.Add(Cb_Onibus);
        }

        private void btn_TransportesMarcados_Click(object sender, EventArgs e)
        {   // criando a variavel de exibição
            string txt="";
            // criando meu loop pra checar os selecionados
            foreach (CheckBox t in checkBoxes)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
               
            }
            MessageBox.Show(txt);
        }
        // criando evento de exibir ao clicar
        private void Cb_Patinete_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Patinete");
        }
        // Abrindo a lista checkbox
        private void btn_FilhoCheckBox_Click(object sender, EventArgs e)
        {
            // instanciar objeto
            F_FilhoCheckBox f_FilhoCheckBox = new F_FilhoCheckBox();
            f_FilhoCheckBox.ShowDialog();
        }
    }
}
