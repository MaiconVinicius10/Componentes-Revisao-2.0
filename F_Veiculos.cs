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
    public partial class F_Veiculos : Form
    {   // criando a variavel globall menu 
        Menu menu1;
        public F_Veiculos(string v,Menu menu)
        {
            InitializeComponent();
            
            // ao entrar trocamos o valor da tabela anterior de num
            menu.num = 10;

            // adicionando dados na lista
            tb_ListaVeiculos.Text = v;
            // global menu recebendo o menu normal
            menu1 = menu;
            
        }
        // criando evento fechar e setar os dados atualizados
        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu1.tb_ListaVeiculos.Text = tb_ListaVeiculos.Text;
        }
    }
}
