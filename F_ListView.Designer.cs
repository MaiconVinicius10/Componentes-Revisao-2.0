
namespace Componentes_Revisao_2._0
{
    partial class F_ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "19,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "39,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "38",
            "500,00"}, -1);
            this.btn_Obter = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Preco = new System.Windows.Forms.TextBox();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.txt_Produto = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_Produtos = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_Obter
            // 
            this.btn_Obter.Location = new System.Drawing.Point(12, 367);
            this.btn_Obter.Name = "btn_Obter";
            this.btn_Obter.Size = new System.Drawing.Size(134, 23);
            this.btn_Obter.TabIndex = 21;
            this.btn_Obter.Text = "Obter";
            this.btn_Obter.UseVisualStyleBackColor = true;
            this.btn_Obter.Click += new System.EventHandler(this.btn_Obter_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(12, 326);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(134, 23);
            this.btn_Remover.TabIndex = 19;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(12, 284);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(134, 23);
            this.btn_Adicionar.TabIndex = 20;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Prdotuo:";
            // 
            // txt_Preco
            // 
            this.txt_Preco.Location = new System.Drawing.Point(384, 235);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(111, 22);
            this.txt_Preco.TabIndex = 15;
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(310, 235);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(68, 22);
            this.txt_Quantidade.TabIndex = 14;
            // 
            // txt_Produto
            // 
            this.txt_Produto.Location = new System.Drawing.Point(64, 235);
            this.txt_Produto.Name = "txt_Produto";
            this.txt_Produto.Size = new System.Drawing.Size(240, 22);
            this.txt_Produto.TabIndex = 13;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(11, 235);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(47, 22);
            this.txt_Id.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID:";
            // 
            // lv_Produtos
            // 
            this.lv_Produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_produto,
            this.col_quantidade,
            this.col_preco});
            this.lv_Produtos.FullRowSelect = true;
            this.lv_Produtos.HideSelection = false;
            this.lv_Produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_Produtos.Location = new System.Drawing.Point(12, 12);
            this.lv_Produtos.MultiSelect = false;
            this.lv_Produtos.Name = "lv_Produtos";
            this.lv_Produtos.Size = new System.Drawing.Size(595, 125);
            this.lv_Produtos.TabIndex = 10;
            this.lv_Produtos.UseCompatibleStateImageBehavior = false;
            this.lv_Produtos.View = System.Windows.Forms.View.Details;
            this.lv_Produtos.SelectedIndexChanged += new System.EventHandler(this.lv_Produtos_SelectedIndexChanged);
            // 
            // col_id
            // 
            this.col_id.Text = "Id";
            this.col_id.Width = 40;
            // 
            // col_produto
            // 
            this.col_produto.Text = "Produto";
            this.col_produto.Width = 250;
            // 
            // col_quantidade
            // 
            this.col_quantidade.Text = "Quantidade";
            this.col_quantidade.Width = 93;
            // 
            // col_preco
            // 
            this.col_preco.Text = "Preço";
            this.col_preco.Width = 147;
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 474);
            this.Controls.Add(this.btn_Obter);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Preco);
            this.Controls.Add(this.txt_Quantidade);
            this.Controls.Add(this.txt_Produto);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_Produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListView";
            this.Load += new System.EventHandler(this.F_ListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Obter;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Preco;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.TextBox txt_Produto;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_Produtos;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_produto;
        private System.Windows.Forms.ColumnHeader col_quantidade;
        private System.Windows.Forms.ColumnHeader col_preco;
    }
}