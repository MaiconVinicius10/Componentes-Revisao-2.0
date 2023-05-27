
namespace Componentes_Revisao_2._0
{
    partial class F_PictureBox
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_AmentedoPro = new System.Windows.Forms.Button();
            this.btn_Rabisco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Componentes_Revisao_2._0.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_AmentedoPro
            // 
            this.btn_AmentedoPro.Location = new System.Drawing.Point(323, 109);
            this.btn_AmentedoPro.Name = "btn_AmentedoPro";
            this.btn_AmentedoPro.Size = new System.Drawing.Size(143, 23);
            this.btn_AmentedoPro.TabIndex = 3;
            this.btn_AmentedoPro.Text = "A Mente Do Pro";
            this.btn_AmentedoPro.UseVisualStyleBackColor = true;
            this.btn_AmentedoPro.Click += new System.EventHandler(this.btn_AmentedoPro_Click);
            // 
            // btn_Rabisco
            // 
            this.btn_Rabisco.Location = new System.Drawing.Point(323, 168);
            this.btn_Rabisco.Name = "btn_Rabisco";
            this.btn_Rabisco.Size = new System.Drawing.Size(143, 23);
            this.btn_Rabisco.TabIndex = 4;
            this.btn_Rabisco.Text = "Rabisco";
            this.btn_Rabisco.UseVisualStyleBackColor = true;
            this.btn_Rabisco.Click += new System.EventHandler(this.btn_Rabisco_Click);
            // 
            // F_PictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 435);
            this.Controls.Add(this.btn_Rabisco);
            this.Controls.Add(this.btn_AmentedoPro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_PictureBox";
            this.Text = "F_PictureBox";
            this.Load += new System.EventHandler(this.F_PictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_AmentedoPro;
        private System.Windows.Forms.Button btn_Rabisco;
    }
}