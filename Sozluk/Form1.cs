using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sozluk
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> kelimeler = new Dictionary<string, string>();
        public Form1()
       {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach(var kelime in kelimeler)
            {
                if(kelime.Key==textBox1.Text)
                {
                    textBox2.Text = kelime.Value;
                    break;
                }
                else
                {
                    textBox2.Text = "kelime bulunamadı";
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kelimeler.Add(textBox1.Text, textBox2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kelimeler.Add("cat", "kedi");
            kelimeler.Add("car", "araba");
            kelimeler.Add("dog", "köpek");
            kelimeler.Add("black", "siyah");

        }

        private void btnDegiştir_Click(object sender, EventArgs e)
        {

        }
    }
}

    