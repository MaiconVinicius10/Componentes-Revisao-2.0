﻿using System;
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
    public partial class F_PictureBox : Form
    {
        public F_PictureBox()
        {
            InitializeComponent();
        }

        private void F_PictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.EndereçoCanal;
            label2.Text = Properties.Resources.NomeCanal;
        }

        private void btn_AmentedoPro_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._2;
        }

        private void btn_Rabisco_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Rabisco;
        }
    }
}
