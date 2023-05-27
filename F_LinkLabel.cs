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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            // adicionando meus links no multiplos
            ll_MultiplosLinks.Links.Add(0,6, "https://www.google.com.br/");
            ll_MultiplosLinks.Links.Add(9,5, "https://www.youtube.com/@cfbcursos");
            ll_MultiplosLinks.Links.Add(17,7, "https://www.youtube.com/?hl=pt&gl=BR");
        }
        // botao link canal
        private void ll_Canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@cfbcursos");
        }
        //botao calculadora
        private void ll_Calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            e.Link.Visited = true;
        }
        //botao multiplos
        private void ll_MultiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
