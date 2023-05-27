
namespace Componentes_Revisao_2._0
{
    partial class F_LinkLabel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.ll_MultiplosLinks = new System.Windows.Forms.LinkLabel();
            this.ll_Calculadora = new System.Windows.Forms.LinkLabel();
            this.ll_Canal = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Digite seu nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(12, 33);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(152, 22);
            this.txt_Nome.TabIndex = 8;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            // 
            // ll_MultiplosLinks
            // 
            this.ll_MultiplosLinks.AutoSize = true;
            this.ll_MultiplosLinks.Location = new System.Drawing.Point(44, 194);
            this.ll_MultiplosLinks.Name = "ll_MultiplosLinks";
            this.ll_MultiplosLinks.Size = new System.Drawing.Size(169, 17);
            this.ll_MultiplosLinks.TabIndex = 7;
            this.ll_MultiplosLinks.TabStop = true;
            this.ll_MultiplosLinks.Text = "Google - Canal - Youtube";
            this.ll_MultiplosLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_MultiplosLinks_LinkClicked);
            // 
            // ll_Calculadora
            // 
            this.ll_Calculadora.AutoSize = true;
            this.ll_Calculadora.Location = new System.Drawing.Point(164, 105);
            this.ll_Calculadora.Name = "ll_Calculadora";
            this.ll_Calculadora.Size = new System.Drawing.Size(83, 17);
            this.ll_Calculadora.TabIndex = 6;
            this.ll_Calculadora.TabStop = true;
            this.ll_Calculadora.Text = "Calculadora";
            this.ll_Calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Calculadora_LinkClicked);
            // 
            // ll_Canal
            // 
            this.ll_Canal.AutoSize = true;
            this.ll_Canal.Location = new System.Drawing.Point(44, 105);
            this.ll_Canal.Name = "ll_Canal";
            this.ll_Canal.Size = new System.Drawing.Size(44, 17);
            this.ll_Canal.TabIndex = 5;
            this.ll_Canal.TabStop = true;
            this.ll_Canal.Text = "Canal";
            this.ll_Canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Canal_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.ll_MultiplosLinks);
            this.Controls.Add(this.ll_Calculadora);
            this.Controls.Add(this.ll_Canal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_LinkLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.LinkLabel ll_MultiplosLinks;
        private System.Windows.Forms.LinkLabel ll_Calculadora;
        private System.Windows.Forms.LinkLabel ll_Canal;
    }
}