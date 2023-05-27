
namespace Componentes_Revisao_2._0
{
    partial class F_DateTimePicker
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
            this.txt_Dia = new System.Windows.Forms.TextBox();
            this.btn_Hoje = new System.Windows.Forms.Button();
            this.btn_SetarData = new System.Windows.Forms.Button();
            this.txt_Ano = new System.Windows.Forms.TextBox();
            this.txt_Mes = new System.Windows.Forms.TextBox();
            this.t_Dia = new System.Windows.Forms.TextBox();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.btn_ObterData = new System.Windows.Forms.Button();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_Dia
            // 
            this.txt_Dia.Location = new System.Drawing.Point(-141, 276);
            this.txt_Dia.Name = "txt_Dia";
            this.txt_Dia.Size = new System.Drawing.Size(140, 22);
            this.txt_Dia.TabIndex = 14;
            // 
            // btn_Hoje
            // 
            this.btn_Hoje.Location = new System.Drawing.Point(509, 67);
            this.btn_Hoje.Name = "btn_Hoje";
            this.btn_Hoje.Size = new System.Drawing.Size(292, 23);
            this.btn_Hoje.TabIndex = 22;
            this.btn_Hoje.Text = "Hoje";
            this.btn_Hoje.UseVisualStyleBackColor = true;
            this.btn_Hoje.Click += new System.EventHandler(this.btn_Hoje_Click);
            // 
            // btn_SetarData
            // 
            this.btn_SetarData.Location = new System.Drawing.Point(509, 38);
            this.btn_SetarData.Name = "btn_SetarData";
            this.btn_SetarData.Size = new System.Drawing.Size(292, 23);
            this.btn_SetarData.TabIndex = 21;
            this.btn_SetarData.Text = "Setar Data";
            this.btn_SetarData.UseVisualStyleBackColor = true;
            this.btn_SetarData.Click += new System.EventHandler(this.btn_SetarData_Click);
            // 
            // txt_Ano
            // 
            this.txt_Ano.Location = new System.Drawing.Point(334, 68);
            this.txt_Ano.Name = "txt_Ano";
            this.txt_Ano.Size = new System.Drawing.Size(170, 22);
            this.txt_Ano.TabIndex = 20;
            // 
            // txt_Mes
            // 
            this.txt_Mes.Location = new System.Drawing.Point(158, 68);
            this.txt_Mes.Name = "txt_Mes";
            this.txt_Mes.Size = new System.Drawing.Size(170, 22);
            this.txt_Mes.TabIndex = 19;
            // 
            // t_Dia
            // 
            this.t_Dia.Location = new System.Drawing.Point(12, 68);
            this.t_Dia.Name = "t_Dia";
            this.t_Dia.Size = new System.Drawing.Size(140, 22);
            this.t_Dia.TabIndex = 18;
            // 
            // txt_Data
            // 
            this.txt_Data.Location = new System.Drawing.Point(12, 40);
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.Size = new System.Drawing.Size(492, 22);
            this.txt_Data.TabIndex = 17;
            // 
            // btn_ObterData
            // 
            this.btn_ObterData.Location = new System.Drawing.Point(510, 11);
            this.btn_ObterData.Name = "btn_ObterData";
            this.btn_ObterData.Size = new System.Drawing.Size(292, 23);
            this.btn_ObterData.TabIndex = 16;
            this.btn_ObterData.Text = "Obter Data";
            this.btn_ObterData.UseVisualStyleBackColor = true;
            this.btn_ObterData.Click += new System.EventHandler(this.btn_ObterData_Click);
            // 
            // dtp_Data
            // 
            this.dtp_Data.Location = new System.Drawing.Point(12, 12);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(492, 22);
            this.dtp_Data.TabIndex = 15;
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 537);
            this.Controls.Add(this.btn_Hoje);
            this.Controls.Add(this.btn_SetarData);
            this.Controls.Add(this.txt_Ano);
            this.Controls.Add(this.txt_Mes);
            this.Controls.Add(this.t_Dia);
            this.Controls.Add(this.txt_Data);
            this.Controls.Add(this.btn_ObterData);
            this.Controls.Add(this.dtp_Data);
            this.Controls.Add(this.txt_Dia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_DateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_DateTimePicker";
            this.Load += new System.EventHandler(this.F_DateTimePicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Dia;
        private System.Windows.Forms.Button btn_Hoje;
        private System.Windows.Forms.Button btn_SetarData;
        private System.Windows.Forms.TextBox txt_Ano;
        private System.Windows.Forms.TextBox txt_Mes;
        private System.Windows.Forms.TextBox t_Dia;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.Button btn_ObterData;
        private System.Windows.Forms.DateTimePicker dtp_Data;
    }
}