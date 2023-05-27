
namespace Componentes_Revisao_2._0
{
    partial class F_CheckListBox
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
            this.txt_TransporteNovo = new System.Windows.Forms.TextBox();
            this.btn_NovoTransporte = new System.Windows.Forms.Button();
            this.btn_RestarLista = new System.Windows.Forms.Button();
            this.btn_LimparLista = new System.Windows.Forms.Button();
            this.btn_MostrarSelecionados = new System.Windows.Forms.Button();
            this.Clb_Tranportes = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Digite um novo Transporte:";
            // 
            // txt_TransporteNovo
            // 
            this.txt_TransporteNovo.Location = new System.Drawing.Point(164, 171);
            this.txt_TransporteNovo.Name = "txt_TransporteNovo";
            this.txt_TransporteNovo.Size = new System.Drawing.Size(192, 22);
            this.txt_TransporteNovo.TabIndex = 12;
            // 
            // btn_NovoTransporte
            // 
            this.btn_NovoTransporte.Location = new System.Drawing.Point(164, 199);
            this.btn_NovoTransporte.Name = "btn_NovoTransporte";
            this.btn_NovoTransporte.Size = new System.Drawing.Size(192, 23);
            this.btn_NovoTransporte.TabIndex = 11;
            this.btn_NovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_NovoTransporte.UseVisualStyleBackColor = true;
            this.btn_NovoTransporte.Click += new System.EventHandler(this.btn_NovoTransporte_Click);
            // 
            // btn_RestarLista
            // 
            this.btn_RestarLista.Location = new System.Drawing.Point(164, 70);
            this.btn_RestarLista.Name = "btn_RestarLista";
            this.btn_RestarLista.Size = new System.Drawing.Size(192, 23);
            this.btn_RestarLista.TabIndex = 10;
            this.btn_RestarLista.Text = "Resetar Lista";
            this.btn_RestarLista.UseVisualStyleBackColor = true;
            this.btn_RestarLista.Click += new System.EventHandler(this.btn_RestarLista_Click);
            // 
            // btn_LimparLista
            // 
            this.btn_LimparLista.Location = new System.Drawing.Point(164, 41);
            this.btn_LimparLista.Name = "btn_LimparLista";
            this.btn_LimparLista.Size = new System.Drawing.Size(192, 23);
            this.btn_LimparLista.TabIndex = 9;
            this.btn_LimparLista.Text = "Limpar Lista";
            this.btn_LimparLista.UseVisualStyleBackColor = true;
            this.btn_LimparLista.Click += new System.EventHandler(this.btn_LimparLista_Click);
            // 
            // btn_MostrarSelecionados
            // 
            this.btn_MostrarSelecionados.Location = new System.Drawing.Point(164, 12);
            this.btn_MostrarSelecionados.Name = "btn_MostrarSelecionados";
            this.btn_MostrarSelecionados.Size = new System.Drawing.Size(192, 23);
            this.btn_MostrarSelecionados.TabIndex = 8;
            this.btn_MostrarSelecionados.Text = "Mostrar Selecionados";
            this.btn_MostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_MostrarSelecionados.Click += new System.EventHandler(this.btn_MostrarSelecionados_Click);
            // 
            // Clb_Tranportes
            // 
            this.Clb_Tranportes.FormattingEnabled = true;
            this.Clb_Tranportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.Clb_Tranportes.Location = new System.Drawing.Point(12, 12);
            this.Clb_Tranportes.Name = "Clb_Tranportes";
            this.Clb_Tranportes.Size = new System.Drawing.Size(120, 412);
            this.Clb_Tranportes.TabIndex = 7;
            // 
            // F_CheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TransporteNovo);
            this.Controls.Add(this.btn_NovoTransporte);
            this.Controls.Add(this.btn_RestarLista);
            this.Controls.Add(this.btn_LimparLista);
            this.Controls.Add(this.btn_MostrarSelecionados);
            this.Controls.Add(this.Clb_Tranportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "labe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TransporteNovo;
        private System.Windows.Forms.Button btn_NovoTransporte;
        private System.Windows.Forms.Button btn_RestarLista;
        private System.Windows.Forms.Button btn_LimparLista;
        private System.Windows.Forms.Button btn_MostrarSelecionados;
        private System.Windows.Forms.CheckedListBox Clb_Tranportes;
    }
}