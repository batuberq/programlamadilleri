using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesnesınavs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            int ebob = 0;

            for (int i = 1; i < sayi1; i++)
            {
                if (sayi1 % i == 0 && sayi2 % i == 0)
                {
                    ebob = i;
                }
            }
            label5.Text = ebob.ToString();

            int max = sayi1 * sayi2;
            int ekok = 0;

            for (int i = max; i > 0; i--)
            {
                if (i % sayi1 == 0 && i % sayi2 == 0)
                {
                    ekok = i;
                }
            }
            label6.Text = ekok.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);
            int b = Convert.ToInt32(textBox4.Text);
            int c = Convert.ToInt32(textBox5.Text);

            double d = (b * b) - (4 * a * c);
            if (d > 0)
            {
                double x1 = Math.Round(((-b - Math.Sqrt(d)) / (2 * a)), 2);
                double x2 = Math.Round(((-b + Math.Sqrt(d)) / (2 * a)), 2);
                label11.Text = "Denklemin İki Kökü Vardır = " + x1.ToString() + " - " + x2.ToString();
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                label11.Text = "Denklemin Bir Kökü Vardır = " + x.ToString();
            }
            else
            {
                label11.Text = "Sanal Kök Vardır";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox6.Text);
            int b = Convert.ToInt32(textBox7.Text);
            double c;
            c = Convert.ToDouble(Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2))));

            label16.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = 5;
            double pay = Math.Pow(10, n) - 22;
            double payda = 3;
            double sonuc = 44;

            double cozum = pay / payda;
            double cozumBirler = cozum % 10;
            double cozumOnlar = ((cozum % 100) - cozumBirler) / 10;
            double toplam = cozumBirler + cozumOnlar;
            sonuc = sonuc - toplam;
            double cevap = (sonuc / 3) + 2;
            label21.Text = "n yerine 5 yazarsak eğer " + cozum + "=44 olur \nburadan eşitliğin sol tarafındaki sayının birler ve onlar basamağı\nalınır " + cozumBirler + "-" + cozumOnlar + "\nEşitliğin sağ tarafına atılır 3x=" + sonuc + "olur\n buradan x 12 olur birler ve onlar basamağınıda eklersek\ncevapta=" + cevap + " olur";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a;
            double r, g;
            double pi = 3.14;
            a = Convert.ToInt32(textBox8.Text);
            r = Math.Round((a * pi / 180),2);
            g = (a * 200 / 180);            label23.Text = r.ToString();
            label25.Text = Math.Round(g,2).ToString();
        }
    }
}
