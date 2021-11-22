using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciNotHesaplama
{
    public partial class Form1 : Form
    {
       public static double sinav1, sinav2, proje, ortalama;
        public  int sinav1oran, sinav2oran, projeorani, gecmenotugiris;
        public static string ad, soyad;
        public static string durum;
        public int i = 1;

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                hesapla_btn_Click(this,new EventArgs());
            }
        }

        public Form1()
        {
            InitializeComponent();

        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void hesapla_btn_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || sinavoran1.Value== 0
                || sinavoran2.Value == 0 || projenotortalamasi.Value == 0 || gecmenotu.Value == 0)
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz!");

              
            }
            else
            {

            
            ad = textBox1.Text.ToString();
            soyad = textBox2.Text.ToString();
            sinav1 = Convert.ToDouble(textBox3.Text);
            sinav2 = Convert.ToDouble(textBox4.Text);
            proje = Convert.ToDouble(textBox5.Text);
                sinav1oran = Convert.ToInt32(sinavoran1.Value);
                sinav2oran = Convert.ToInt32(sinavoran2.Value);
                projeorani = Convert.ToInt32(projenotortalamasi.Value);
                gecmenotugiris = Convert.ToInt32(gecmenotu.Value);

                ortalama = (sinav1*sinav1oran)/100 + (sinav2*sinav2oran)/100 + (proje*projeorani)/100 ;

                ortalama = Math.Round(ortalama, 2);

                if (ortalama>=gecmenotugiris)
            {
                 durum = "✓ Başarılı";
            }
            else
            {
                 durum = "X Başarısız";

            }
            listBox1.Items.Add(i +"." +ad+"\t"+soyad+ "\t" + ortalama + "\t" + durum);
             textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
                i++;
            }
        }

       
    }
}
