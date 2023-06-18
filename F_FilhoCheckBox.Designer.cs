
namespace Componentes_Revisao_2._0
{
    partial class F_FilhoCheckBox
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
            this.Cb_Onibus = new System.Windows.Forms.CheckBox();
            this.Cb_Navio = new System.Windows.Forms.CheckBox();
            this.Cb_Aviao = new System.Windows.Forms.CheckBox();
            this.Cb_Carro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Cb_Onibus
            // 
            this.Cb_Onibus.AutoSize = true;
            this.Cb_Onibus.Location = new System.Drawing.Point(13, 96);
            this.Cb_Onibus.Name = "Cb_Onibus";
            this.Cb_Onibus.Size = new System.Drawing.Size(75, 21);
            this.Cb_Onibus.TabIndex = 11;
            this.Cb_Onibus.Text = "Ônibus";
            this.Cb_Onibus.UseVisualStyleBackColor = true;
            this.Cb_Onibus.CheckedChanged += new System.EventHandler(this.Cb_Onibus_CheckedChanged);
            // 
            // Cb_Navio
            // 
            this.Cb_Navio.AutoSize = true;
            this.Cb_Navio.Location = new System.Drawing.Point(12, 69);
            this.Cb_Navio.Name = "Cb_Navio";
            this.Cb_Navio.Size = new System.Drawing.Size(66, 21);
            this.Cb_Navio.TabIndex = 10;
            this.Cb_Navio.Text = "Navio";
            this.Cb_Navio.UseVisualStyleBackColor = true;
            this.Cb_Navio.CheckedChanged += new System.EventHandler(this.Cb_Navio_CheckedChanged);
            // 
            // Cb_Aviao
            // 
            this.Cb_Aviao.AutoSize = true;
            this.Cb_Aviao.Location = new System.Drawing.Point(13, 42);
            this.Cb_Aviao.Name = "Cb_Aviao";
            this.Cb_Aviao.Size = new System.Drawing.Size(65, 21);
            this.Cb_Aviao.TabIndex = 9;
            this.Cb_Aviao.Text = "Avião";
            this.Cb_Aviao.UseVisualStyleBackColor = true;
            this.Cb_Aviao.CheckedChanged += new System.EventHandler(this.Cb_Aviao_CheckedChanged);
            // 
            // Cb_Carro
            // 
            this.Cb_Carro.AutoSize = true;
            this.Cb_Carro.Location = new System.Drawing.Point(13, 15);
            this.Cb_Carro.Name = "Cb_Carro";
            this.Cb_Carro.Size = new System.Drawing.Size(65, 21);
            this.Cb_Carro.TabIndex = 8;
            this.Cb_Carro.Text = "Carro";
            this.Cb_Carro.UseVisualStyleBackColor = true;
            this.Cb_Carro.CheckedChanged += new System.EventHandler(this.Cb_Carro_CheckedChanged);
            // 
            // F_FilhoCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 450);
            this.Controls.Add(this.Cb_Onibus);
            this.Controls.Add(this.Cb_Navio);
            this.Controls.Add(this.Cb_Aviao);
            this.Controls.Add(this.Cb_Carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_FilhoCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_FilhoCheckBox";
            this.Load += new System.EventHandler(this.F_FilhoCheckBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Cb_Onibus;
        private System.Windows.Forms.CheckBox Cb_Navio;
        private System.Windows.Forms.CheckBox Cb_Aviao;
        public System.Windows.Forms.CheckBox Cb_Carro;
    }
}