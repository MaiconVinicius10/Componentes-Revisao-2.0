
namespace Componentes_Revisao_2._0
{
    partial class F_NumericUpDown
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.btn_DifinirValor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(12, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(127, 11);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(96, 22);
            this.txt_Valor.TabIndex = 1;
            this.txt_Valor.Text = "0";
            // 
            // btn_DifinirValor
            // 
            this.btn_DifinirValor.Location = new System.Drawing.Point(256, 10);
            this.btn_DifinirValor.Name = "btn_DifinirValor";
            this.btn_DifinirValor.Size = new System.Drawing.Size(113, 23);
            this.btn_DifinirValor.TabIndex = 2;
            this.btn_DifinirValor.Text = "Difinir Valor";
            this.btn_DifinirValor.UseVisualStyleBackColor = true;
            this.btn_DifinirValor.Click += new System.EventHandler(this.btn_DifinirValor_Click);
            // 
            // F_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 446);
            this.Controls.Add(this.btn_DifinirValor);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.numericUpDown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_NumericUpDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumericUpDown";
            this.Load += new System.EventHandler(this.F_NumericUpDown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Button btn_DifinirValor;
    }
}