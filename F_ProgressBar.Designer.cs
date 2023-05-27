
namespace Componentes_Revisao_2._0
{
    partial class F_ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Definir = new System.Windows.Forms.Button();
            this.btn_Preencher = new System.Windows.Forms.Button();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.txt_Maximo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 252);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(563, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btn_Definir
            // 
            this.btn_Definir.AutoSize = true;
            this.btn_Definir.Location = new System.Drawing.Point(83, 128);
            this.btn_Definir.Name = "btn_Definir";
            this.btn_Definir.Size = new System.Drawing.Size(96, 27);
            this.btn_Definir.TabIndex = 1;
            this.btn_Definir.Text = "Definir Valor";
            this.btn_Definir.UseVisualStyleBackColor = true;
            this.btn_Definir.Click += new System.EventHandler(this.btn_Definir_Click);
            // 
            // btn_Preencher
            // 
            this.btn_Preencher.AutoSize = true;
            this.btn_Preencher.Location = new System.Drawing.Point(83, 197);
            this.btn_Preencher.Name = "btn_Preencher";
            this.btn_Preencher.Size = new System.Drawing.Size(84, 27);
            this.btn_Preencher.TabIndex = 2;
            this.btn_Preencher.Text = "Preencher";
            this.btn_Preencher.UseVisualStyleBackColor = true;
            this.btn_Preencher.Click += new System.EventHandler(this.btn_Preencher_Click);
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(83, 77);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(100, 22);
            this.txt_Valor.TabIndex = 3;
            this.txt_Valor.Text = "0";
            // 
            // txt_Maximo
            // 
            this.txt_Maximo.Location = new System.Drawing.Point(245, 77);
            this.txt_Maximo.Name = "txt_Maximo";
            this.txt_Maximo.Size = new System.Drawing.Size(100, 22);
            this.txt_Maximo.TabIndex = 4;
            this.txt_Maximo.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // F_ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Maximo);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.btn_Preencher);
            this.Controls.Add(this.btn_Definir);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_ProgressBar";
            this.Text = "ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_Definir;
        private System.Windows.Forms.Button btn_Preencher;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.TextBox txt_Maximo;
        private System.Windows.Forms.Label label1;
    }
}