namespace _04_04_2022
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_InputKalimat = new System.Windows.Forms.Label();
            this.TextBox_InputKalimat = new System.Windows.Forms.TextBox();
            this.Label_MasukkanHuruf = new System.Windows.Forms.Label();
            this.TextBox_MasukkanHuruf = new System.Windows.Forms.TextBox();
            this.Label_Menjadi = new System.Windows.Forms.Label();
            this.TextBox_Menjadi = new System.Windows.Forms.TextBox();
            this.Button_Konversi = new System.Windows.Forms.Button();
            this.Label_Hasil = new System.Windows.Forms.Label();
            this.Label2_Hasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_InputKalimat
            // 
            this.Label_InputKalimat.AutoSize = true;
            this.Label_InputKalimat.Location = new System.Drawing.Point(12, 9);
            this.Label_InputKalimat.Name = "Label_InputKalimat";
            this.Label_InputKalimat.Size = new System.Drawing.Size(101, 15);
            this.Label_InputKalimat.TabIndex = 0;
            this.Label_InputKalimat.Text = "Masukan Kalimat ";
            // 
            // TextBox_InputKalimat
            // 
            this.TextBox_InputKalimat.Location = new System.Drawing.Point(119, 6);
            this.TextBox_InputKalimat.Name = "TextBox_InputKalimat";
            this.TextBox_InputKalimat.Size = new System.Drawing.Size(274, 23);
            this.TextBox_InputKalimat.TabIndex = 1;
            this.TextBox_InputKalimat.TextChanged += new System.EventHandler(this.TextBox_InputKalimat_TextChanged);
            // 
            // Label_MasukkanHuruf
            // 
            this.Label_MasukkanHuruf.AutoSize = true;
            this.Label_MasukkanHuruf.Location = new System.Drawing.Point(12, 46);
            this.Label_MasukkanHuruf.Name = "Label_MasukkanHuruf";
            this.Label_MasukkanHuruf.Size = new System.Drawing.Size(95, 15);
            this.Label_MasukkanHuruf.TabIndex = 2;
            this.Label_MasukkanHuruf.Text = "Masukkan Huruf";
            // 
            // TextBox_MasukkanHuruf
            // 
            this.TextBox_MasukkanHuruf.Location = new System.Drawing.Point(119, 43);
            this.TextBox_MasukkanHuruf.Name = "TextBox_MasukkanHuruf";
            this.TextBox_MasukkanHuruf.Size = new System.Drawing.Size(58, 23);
            this.TextBox_MasukkanHuruf.TabIndex = 3;
            this.TextBox_MasukkanHuruf.TextChanged += new System.EventHandler(this.TextBox_MasukkanHuruf_TextChanged);
            // 
            // Label_Menjadi
            // 
            this.Label_Menjadi.AutoSize = true;
            this.Label_Menjadi.Location = new System.Drawing.Point(276, 46);
            this.Label_Menjadi.Name = "Label_Menjadi";
            this.Label_Menjadi.Size = new System.Drawing.Size(53, 15);
            this.Label_Menjadi.TabIndex = 4;
            this.Label_Menjadi.Text = "Menjadi ";
            // 
            // TextBox_Menjadi
            // 
            this.TextBox_Menjadi.Location = new System.Drawing.Point(335, 43);
            this.TextBox_Menjadi.Name = "TextBox_Menjadi";
            this.TextBox_Menjadi.Size = new System.Drawing.Size(58, 23);
            this.TextBox_Menjadi.TabIndex = 5;
            this.TextBox_Menjadi.TextChanged += new System.EventHandler(this.TextBox_Menjadi_TextChanged);
            // 
            // Button_Konversi
            // 
            this.Button_Konversi.Location = new System.Drawing.Point(119, 90);
            this.Button_Konversi.Name = "Button_Konversi";
            this.Button_Konversi.Size = new System.Drawing.Size(274, 23);
            this.Button_Konversi.TabIndex = 6;
            this.Button_Konversi.Text = "Konversi";
            this.Button_Konversi.UseVisualStyleBackColor = true;
            this.Button_Konversi.Click += new System.EventHandler(this.Button_Konversi_Click);
            // 
            // Label_Hasil
            // 
            this.Label_Hasil.AutoSize = true;
            this.Label_Hasil.Location = new System.Drawing.Point(12, 135);
            this.Label_Hasil.Name = "Label_Hasil";
            this.Label_Hasil.Size = new System.Drawing.Size(33, 15);
            this.Label_Hasil.TabIndex = 7;
            this.Label_Hasil.Text = "Hasil";
            // 
            // Label2_Hasil
            // 
            this.Label2_Hasil.AutoSize = true;
            this.Label2_Hasil.Location = new System.Drawing.Point(119, 135);
            this.Label2_Hasil.Name = "Label2_Hasil";
            this.Label2_Hasil.Size = new System.Drawing.Size(52, 15);
            this.Label2_Hasil.TabIndex = 8;
            this.Label2_Hasil.Text = "[EMPTY]";
            this.Label2_Hasil.Click += new System.EventHandler(this.Label2_Hasil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 227);
            this.Controls.Add(this.Label2_Hasil);
            this.Controls.Add(this.Label_Hasil);
            this.Controls.Add(this.Button_Konversi);
            this.Controls.Add(this.TextBox_Menjadi);
            this.Controls.Add(this.Label_Menjadi);
            this.Controls.Add(this.TextBox_MasukkanHuruf);
            this.Controls.Add(this.Label_MasukkanHuruf);
            this.Controls.Add(this.TextBox_InputKalimat);
            this.Controls.Add(this.Label_InputKalimat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_InputKalimat;
        private System.Windows.Forms.TextBox TextBox_InputKalimat;
        private System.Windows.Forms.Label Label_MasukkanHuruf;
        private System.Windows.Forms.TextBox TextBox_MasukkanHuruf;
        private System.Windows.Forms.Label Label_Menjadi;
        private System.Windows.Forms.TextBox TextBox_Menjadi;
        private System.Windows.Forms.Button Button_Konversi;
        private System.Windows.Forms.Label Label_Hasil;
        private System.Windows.Forms.Label Label2_Hasil;
    }
}
