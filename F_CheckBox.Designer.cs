
namespace Componentes_Revisao_2._0
{
    partial class F_CheckBox
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
            this.btn_FilhoCheckBox = new System.Windows.Forms.Button();
            this.Cb_Patinete = new System.Windows.Forms.CheckBox();
            this.btn_TransportesMarcados = new System.Windows.Forms.Button();
            this.Cb_Onibus = new System.Windows.Forms.CheckBox();
            this.Cb_Navio = new System.Windows.Forms.CheckBox();
            this.Cb_Aviao = new System.Windows.Forms.CheckBox();
            this.Cb_Carro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_FilhoCheckBox
            // 
            this.btn_FilhoCheckBox.Location = new System.Drawing.Point(195, 37);
            this.btn_FilhoCheckBox.Name = "btn_FilhoCheckBox";
            this.btn_FilhoCheckBox.Size = new System.Drawing.Size(210, 23);
            this.btn_FilhoCheckBox.TabIndex = 13;
            this.btn_FilhoCheckBox.Text = "Aletar Check Box";
            this.btn_FilhoCheckBox.UseVisualStyleBackColor = true;
            this.btn_FilhoCheckBox.Click += new System.EventHandler(this.btn_FilhoCheckBox_Click);
            // 
            // Cb_Patinete
            // 
            this.Cb_Patinete.AutoSize = true;
            this.Cb_Patinete.Location = new System.Drawing.Point(11, 184);
            this.Cb_Patinete.Name = "Cb_Patinete";
            this.Cb_Patinete.Size = new System.Drawing.Size(82, 21);
            this.Cb_Patinete.TabIndex = 12;
            this.Cb_Patinete.Text = "Patinete";
            this.Cb_Patinete.UseVisualStyleBackColor = true;
            this.Cb_Patinete.CheckedChanged += new System.EventHandler(this.Cb_Patinete_CheckedChanged);
            // 
            // btn_TransportesMarcados
            // 
            this.btn_TransportesMarcados.Location = new System.Drawing.Point(195, 8);
            this.btn_TransportesMarcados.Name = "btn_TransportesMarcados";
            this.btn_TransportesMarcados.Size = new System.Drawing.Size(210, 23);
            this.btn_TransportesMarcados.TabIndex = 11;
            this.btn_TransportesMarcados.Text = "Transportes Marcados";
            this.btn_TransportesMarcados.UseVisualStyleBackColor = true;
            this.btn_TransportesMarcados.Click += new System.EventHandler(this.btn_TransportesMarcados_Click);
            // 
            // Cb_Onibus
            // 
            this.Cb_Onibus.AutoSize = true;
            this.Cb_Onibus.Location = new System.Drawing.Point(12, 89);
            this.Cb_Onibus.Name = "Cb_Onibus";
            this.Cb_Onibus.Size = new System.Drawing.Size(75, 21);
            this.Cb_Onibus.TabIndex = 10;
            this.Cb_Onibus.Text = "Ônibus";
            this.Cb_Onibus.UseVisualStyleBackColor = true;
            // 
            // Cb_Navio
            // 
            this.Cb_Navio.AutoSize = true;
            this.Cb_Navio.Location = new System.Drawing.Point(11, 62);
            this.Cb_Navio.Name = "Cb_Navio";
            this.Cb_Navio.Size = new System.Drawing.Size(66, 21);
            this.Cb_Navio.TabIndex = 9;
            this.Cb_Navio.Text = "Navio";
            this.Cb_Navio.UseVisualStyleBackColor = true;
            // 
            // Cb_Aviao
            // 
            this.Cb_Aviao.AutoSize = true;
            this.Cb_Aviao.Location = new System.Drawing.Point(12, 35);
            this.Cb_Aviao.Name = "Cb_Aviao";
            this.Cb_Aviao.Size = new System.Drawing.Size(65, 21);
            this.Cb_Aviao.TabIndex = 8;
            this.Cb_Aviao.Text = "Avião";
            this.Cb_Aviao.UseVisualStyleBackColor = true;
            // 
            // Cb_Carro
            // 
            this.Cb_Carro.AutoSize = true;
            this.Cb_Carro.Location = new System.Drawing.Point(12, 8);
            this.Cb_Carro.Name = "Cb_Carro";
            this.Cb_Carro.Size = new System.Drawing.Size(65, 21);
            this.Cb_Carro.TabIndex = 7;
            this.Cb_Carro.Text = "Carro";
            this.Cb_Carro.UseVisualStyleBackColor = true;
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 384);
            this.Controls.Add(this.btn_FilhoCheckBox);
            this.Controls.Add(this.Cb_Patinete);
            this.Controls.Add(this.btn_TransportesMarcados);
            this.Controls.Add(this.Cb_Onibus);
            this.Controls.Add(this.Cb_Navio);
            this.Controls.Add(this.Cb_Aviao);
            this.Controls.Add(this.Cb_Carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_FilhoCheckBox;
        private System.Windows.Forms.CheckBox Cb_Patinete;
        private System.Windows.Forms.Button btn_TransportesMarcados;
        public System.Windows.Forms.CheckBox Cb_Onibus;
        public System.Windows.Forms.CheckBox Cb_Navio;
        public System.Windows.Forms.CheckBox Cb_Aviao;
        public System.Windows.Forms.CheckBox Cb_Carro;
    }
}