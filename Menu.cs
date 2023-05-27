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

    public partial class Menu : Form
    {
        public int num = 0;
        public Menu()
        {
            InitializeComponent();
            // inicializando com foco no textbox
            tb_Veiculos.Focus();
        }
        // Abrir ComboBox
        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instanciar e chamar o objeto
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }
        // Abrir CheckListBox
        private void checkListboxToolStripMenuItem_Click(object sender, EventArgs e)
        {   //instanciar e chamar o objeto
            F_CheckListBox f_CheckListBox = new F_CheckListBox();
            f_CheckListBox.ShowDialog();
        }
        // abrir ComboBox
        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciar e chamar objeto
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }
        // abrir DateTimePicker
        private void dataTimePikerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciar e chamar objeto
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
            f_DateTimePicker.ShowDialog();
        }
        // Abrir LinkLabel
        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciar e chamar objeto
            F_LinkLabel f_LinkLabel = new F_LinkLabel();
            f_LinkLabel.ShowDialog();
        }
        // Abrir ListBox
        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }
        // Abrir ListView
        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.ShowDialog();
        }
        // botao  Adicionar
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {   //verificando se nao esta vazio
            if (tb_Veiculos.Text == "")
            {
                MessageBox.Show("Campo de veiculos esta vazio.","Atenção");
                tb_Veiculos.Focus();
            }
            else
            {
                tb_ListaVeiculos.Text += tb_Veiculos.Text + ", ";
                tb_Veiculos.Clear();
                tb_Veiculos.Focus();
            }
        }
        // Botao mostrar Lista de veiculos
        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_ListaVeiculos.Text, this);
            f_Veiculos.Show();
        }
        // botao mostrar Valor de Num
        private void btn_ValNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valor de num é:" + num);
        }
        // bota Limpar
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tb_ListaVeiculos.Clear();
            tb_Veiculos.Clear();
            tb_Veiculos.Focus();
        }
        // Botao Sair
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void componentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // Abrir O MaskedTextBox
        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();
            f_MaskedTextBox.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MonthCalendar f_MonthCalendar = new F_MonthCalendar();
            f_MonthCalendar.ShowDialog();
        }

        private void MenuNotificacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "tsmi_Fechar")
            {
                this.Close();
            } else if (e.ClickedItem.Name.ToString() == "tsmi_Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }else if (e.ClickedItem.Name.ToString() == "tsmi_Mensagem")
            {
                MessageBox.Show("Aow Bunitão");
            }
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpDown f_NumericUpDown = new F_NumericUpDown();
            f_NumericUpDown.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox f_PictureBox = new F_PictureBox();
            f_PictureBox.ShowDialog();

        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ProgressBar f_ProgressBar = new F_ProgressBar();
            f_ProgressBar.ShowDialog();
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_RadioButton f_RadioButton = new F_RadioButton();
            f_RadioButton.ShowDialog();
        }
    }
}
