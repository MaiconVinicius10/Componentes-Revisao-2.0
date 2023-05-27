
namespace Componentes_Revisao_2._0
{
    partial class F_ComboBox
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
            this.btn_AdicionarNovoTransporte = new System.Windows.Forms.Button();
            this.txt_NovoTransporte = new System.Windows.Forms.TextBox();
            this.btn_ResetarElementos = new System.Windows.Forms.Button();
            this.btn_LimparElementos = new System.Windows.Forms.Button();
            this.btn_MostrarSelecionados = new System.Windows.Forms.Button();
            this.cb_Transportes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_AdicionarNovoTransporte
            // 
            this.btn_AdicionarNovoTransporte.Location = new System.Drawing.Point(290, 146);
            this.btn_AdicionarNovoTransporte.Name = "btn_AdicionarNovoTransporte";
            this.btn_AdicionarNovoTransporte.Size = new System.Drawing.Size(199, 23);
            this.btn_AdicionarNovoTransporte.TabIndex = 12;
            this.btn_AdicionarNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_AdicionarNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_AdicionarNovoTransporte.Click += new System.EventHandler(this.btn_AdicionarNovoTransporte_Click);
            // 
            // txt_NovoTransporte
            // 
            this.txt_NovoTransporte.Location = new System.Drawing.Point(290, 118);
            this.txt_NovoTransporte.Name = "txt_NovoTransporte";
            this.txt_NovoTransporte.Size = new System.Drawing.Size(199, 22);
            this.txt_NovoTransporte.TabIndex = 11;
            // 
            // btn_ResetarElementos
            // 
            this.btn_ResetarElementos.Location = new System.Drawing.Point(290, 71);
            this.btn_ResetarElementos.Name = "btn_ResetarElementos";
            this.btn_ResetarElementos.Size = new System.Drawing.Size(199, 23);
            this.btn_ResetarElementos.TabIndex = 10;
            this.btn_ResetarElementos.Text = "Resetar elementos";
            this.btn_ResetarElementos.UseVisualStyleBackColor = true;
            this.btn_ResetarElementos.Click += new System.EventHandler(this.btn_ResetarElementos_Click);
            // 
            // btn_LimparElementos
            // 
            this.btn_LimparElementos.Location = new System.Drawing.Point(290, 42);
            this.btn_LimparElementos.Name = "btn_LimparElementos";
            this.btn_LimparElementos.Size = new System.Drawing.Size(199, 23);
            this.btn_LimparElementos.TabIndex = 9;
            this.btn_LimparElementos.Text = "Limpar Elementos";
            this.btn_LimparElementos.UseVisualStyleBackColor = true;
            this.btn_LimparElementos.Click += new System.EventHandler(this.btn_LimparElementos_Click);
            // 
            // btn_MostrarSelecionados
            // 
            this.btn_MostrarSelecionados.Location = new System.Drawing.Point(290, 13);
            this.btn_MostrarSelecionados.Name = "btn_MostrarSelecionados";
            this.btn_MostrarSelecionados.Size = new System.Drawing.Size(199, 23);
            this.btn_MostrarSelecionados.TabIndex = 8;
            this.btn_MostrarSelecionados.Text = "Mostrar Selecionados";
            this.btn_MostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_MostrarSelecionados.Click += new System.EventHandler(this.btn_MostrarSelecionados_Click);
            // 
            // cb_Transportes
            // 
            this.cb_Transportes.FormattingEnabled = true;
            this.cb_Transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Návio",
            "Ônibus",
            "Trem"});
            this.cb_Transportes.Location = new System.Drawing.Point(12, 12);
            this.cb_Transportes.Name = "cb_Transportes";
            this.cb_Transportes.Size = new System.Drawing.Size(196, 24);
            this.cb_Transportes.TabIndex = 7;
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 532);
            this.Controls.Add(this.btn_AdicionarNovoTransporte);
            this.Controls.Add(this.txt_NovoTransporte);
            this.Controls.Add(this.btn_ResetarElementos);
            this.Controls.Add(this.btn_LimparElementos);
            this.Controls.Add(this.btn_MostrarSelecionados);
            this.Controls.Add(this.cb_Transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ComboBox";
            this.Load += new System.EventHandler(this.F_ComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AdicionarNovoTransporte;
        private System.Windows.Forms.TextBox txt_NovoTransporte;
        private System.Windows.Forms.Button btn_ResetarElementos;
        private System.Windows.Forms.Button btn_LimparElementos;
        private System.Windows.Forms.Button btn_MostrarSelecionados;
        private System.Windows.Forms.ComboBox cb_Transportes;
    }
}