
namespace Componentes_Revisao_2._0
{
    partial class F_ListBox
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
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Obter = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Carro = new System.Windows.Forms.TextBox();
            this.lb_Carros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(183, 156);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 13;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Obter
            // 
            this.btn_Obter.Location = new System.Drawing.Point(183, 127);
            this.btn_Obter.Name = "btn_Obter";
            this.btn_Obter.Size = new System.Drawing.Size(75, 23);
            this.btn_Obter.TabIndex = 12;
            this.btn_Obter.Text = "Obter";
            this.btn_Obter.UseVisualStyleBackColor = true;
            this.btn_Obter.Click += new System.EventHandler(this.btn_Obter_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(183, 98);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(75, 23);
            this.btn_Remover.TabIndex = 11;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(183, 69);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 10;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Carro:";
            // 
            // txt_Carro
            // 
            this.txt_Carro.Location = new System.Drawing.Point(183, 41);
            this.txt_Carro.Name = "txt_Carro";
            this.txt_Carro.Size = new System.Drawing.Size(100, 22);
            this.txt_Carro.TabIndex = 8;
            // 
            // lb_Carros
            // 
            this.lb_Carros.FormattingEnabled = true;
            this.lb_Carros.ItemHeight = 16;
            this.lb_Carros.Location = new System.Drawing.Point(12, 12);
            this.lb_Carros.Name = "lb_Carros";
            this.lb_Carros.Size = new System.Drawing.Size(162, 180);
            this.lb_Carros.TabIndex = 7;
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 342);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Obter);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Carro);
            this.Controls.Add(this.lb_Carros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListBox";
            this.Load += new System.EventHandler(this.F_ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Obter;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Carro;
        private System.Windows.Forms.ListBox lb_Carros;
    }
}