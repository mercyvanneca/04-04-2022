using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_04_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Hasil_Click(object sender, EventArgs e)
        {
            Label2_Hasil.Text = "";
            Label2_Hasil.Text.ToUpper();
        }

        private void Button_Konversi_Click(object sender, EventArgs e)
        {
            Label2_Hasil.Text = TextBox_InputKalimat.Text;
        }

        private void TextBox_InputKalimat_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox_MasukkanHuruf_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void TextBox_Menjadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
