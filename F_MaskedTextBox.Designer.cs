
namespace Componentes_Revisao_2._0
{
    partial class F_MaskedTextBox
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
            this.mtb_Senha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtb_Senha
            // 
            this.mtb_Senha.Location = new System.Drawing.Point(12, 29);
            this.mtb_Senha.Name = "mtb_Senha";
            this.mtb_Senha.PasswordChar = '*';
            this.mtb_Senha.Size = new System.Drawing.Size(224, 22);
            this.mtb_Senha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 90);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(224, 22);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(252, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Somente Numeros";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(405, 89);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(83, 23);
            this.btn_Confirmar.TabIndex = 4;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 434);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_Senha);
            this.Name = "F_MaskedTextBox";
            this.Text = "F_MaskedTextBox";
            this.Load += new System.EventHandler(this.F_MaskedTextBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_Confirmar;
    }
}