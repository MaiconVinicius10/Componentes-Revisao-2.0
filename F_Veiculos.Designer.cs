
namespace Componentes_Revisao_2._0
{
    partial class F_Veiculos
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
            this.tb_ListaVeiculos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_ListaVeiculos
            // 
            this.tb_ListaVeiculos.Location = new System.Drawing.Point(12, 12);
            this.tb_ListaVeiculos.Multiline = true;
            this.tb_ListaVeiculos.Name = "tb_ListaVeiculos";
            this.tb_ListaVeiculos.Size = new System.Drawing.Size(450, 335);
            this.tb_ListaVeiculos.TabIndex = 1;
            // 
            // F_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 364);
            this.Controls.Add(this.tb_ListaVeiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_Veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Veiculos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Veiculos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ListaVeiculos;
    }
}