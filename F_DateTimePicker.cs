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
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }
        // botao obterData
        private void btn_ObterData_Click(object sender, EventArgs e)
        {   // obter forma normal
            txt_Data.Text = dtp_Data.Text;
            // obtendo a data
            t_Dia.Text = dtp_Data.Value.Day.ToString();
            txt_Mes.Text = dtp_Data.Value.Month.ToString();
            txt_Ano.Text = dtp_Data.Value.Year.ToString();
        }
        // botao setar Data
        private void btn_SetarData_Click(object sender, EventArgs e)
        {
            
            // criando variaveis
            int d, m, a;
            // convertando variaveis
            d = Int32.Parse(t_Dia.Text);
            m = Int32.Parse(txt_Mes.Text);
            a = Int32.Parse(txt_Ano.Text);

            // crinado objeto
            DateTime date = new DateTime(a,m,d);

            dtp_Data.Value = date;


        }
        // botao data de hoje
        private void btn_Hoje_Click(object sender, EventArgs e)
        {
            dtp_Data.Value = DateTime.Today;
        }

        private void F_DateTimePicker_Load(object sender, EventArgs e)
        {

        }
    }
}
