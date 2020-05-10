using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string islem;
        double sayi1, sayi2;
        int zaman = 2;

        public void Gecersizİslem() // Geçersiz İşlem Geri Sayımı
        {
            label1.Text = "Geçersiz İşlem.";
            if (label1.Text == "Geçersiz İşlem.")
            {
                timer1.Start();
                System.Media.SystemSounds.Beep.Play();
            }
        }
        
        private void button10_Click(object sender, EventArgs e) // 0 rakamı
        {
            if (label1.Text == "0")
            {
                label1.Text = "0";
            }
            else if (label1.Text == Math.PI.ToString())
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = label1.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e) // 1 rakamı
        {
            if (label1.Text == "0")
            {
                label1.Text = "1";
            }
            else if (label1.Text == Math.PI.ToString())
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text = label1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e) // 2 rakamı
        {
            if (label1.Text == "0")
            {
                label1.Text = "2";
            }
            else if (label1.Text == Math.PI.ToString())
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text = label1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e) // 3 rakamı
        {
            if (label1.Text == "0")
            {
                label1.Text = "3";
            }
            else if (label1.Text == Math.PI.ToString())
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text = label1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e) // 4 rakamı
        {
            if (label1.Text == "0")
            {
                label1.Text = "4";
            }
            else if (label1.Text == Math.PI.ToString())
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text = label1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e) // 5 rakamı
        {
            if (label1.Text == "0")
            {
                label1.Text = "5";
            }
            else if (label1.Text == Math.PI.ToString())
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text = label1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e) // 6 rakamı
        {
            if (label1.Text == "0")
            {
                label1.Text = "6";
            }
            else if (label1.Text == Math.PI.ToString())
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text = label1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e) // 7 rakamı
        {
            if (label1.Text == "0")
            {
                label1.Text = "7";
            }
            else if (label1.Text == Math.PI.ToString())
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text = label1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e) // 8 rakamı
        {
            if (label1.Text == "0")
            {
                label1.Text = "8";
            }
            else if (label1.Text == Math.PI.ToString())
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text = label1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e) // 9 rakamı
        {
            if (label1.Text == "0")
            {
                label1.Text = "9";
            }
            else if (label1.Text == Math.PI.ToString())
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text = label1.Text + "9";
            }
        }

        private void Form1_Load(object sender, EventArgs e) // Başlangıç
        {
            islem = " ";
            this.Width = 353;
            this.Height = 505;
            label1.Width = 320;
            button25.Hide();
            button26.Hide();
            button27.Hide();
            button28.Hide();
            button29.Hide();
            button30.Hide();
            button31.Hide();
            button32.Hide();
            button33.Hide();
            button34.Hide();
            button35.Hide();
            button36.Hide();
            button37.Hide();
            button38.Hide();
            button39.Hide();
            button40.Hide();
            button41.Hide();
            button42.Hide();
            button43.Hide();
            button44.Hide();
        }

        private void button13_Click(object sender, EventArgs e) // Çıkarma
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                islem = "-";
                label1.Text = " ";
            }
            catch
            {
                Gecersizİslem();
            }
            button16.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)  // Çarpma
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                islem = "*";
                label1.Text = " ";
            }
            catch
            {
                Gecersizİslem();
            }
            button16.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e) // Bölme
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                islem = "/";
                label1.Text = " ";
            }
            catch
            {
                Gecersizİslem();
            }
            button16.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e) // Toplama
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                islem = "+";
                label1.Text = " ";
            }
            catch
            {
                Gecersizİslem();
            }
            button16.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e) // İşlem
        {
            try
            {
                sayi2 = Convert.ToDouble(label1.Text);
                if (islem == "+")
                {
                    label1.Text = Convert.ToString(sayi1 + sayi2);
                }
                if (islem == "-")
                {
                    label1.Text = Convert.ToString(sayi1 - sayi2);
                }
                if (islem == "*")
                {
                    label1.Text = Convert.ToString(sayi1 * sayi2);
                }
                if (islem == "/")
                {
                    label1.Text = Convert.ToString(sayi1 / sayi2);
                }
                if (islem == "L")
                {
                    label1.Text = Convert.ToString((sayi1 * sayi2) / 100);
                }
                if (islem == "xy")
                {
                    label1.Text = Convert.ToString(Math.Pow(sayi1, sayi2));
                }
                if (islem == "yx")
                {
                }
                if (islem == "Mod")
                {
                    label1.Text = Convert.ToString(sayi1 % sayi2);
                }
                if (islem == "Exp")
                {
                }
                if (islem == "Ave")
                {
                    label1.Text = Convert.ToString((sayi1 + sayi2) / 2);
                }
                button16.Enabled = true;
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button23_Click(object sender, EventArgs e) // Karesini Alma
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                islem = "S";
                if (islem == "S")
                {
                    label1.Text = Convert.ToString(sayi1 * sayi1);
                }
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button21_Click(object sender, EventArgs e) // Küpünü Alma
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                islem = "C";
                if (islem == "C")
                {
                    label1.Text = Convert.ToString(sayi1 * sayi1 * sayi1);
                }
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button22_Click(object sender, EventArgs e) // Karekökünü Alma
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                islem = "R";
                if (islem == "R")
                {
                    label1.Text = Convert.ToString(Math.Sqrt(sayi1));
                }
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button24_Click(object sender, EventArgs e) // 1/x
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                islem = "B";
                if (islem == "B")
                {
                    label1.Text = Convert.ToString(1 / sayi1);
                }
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button20_Click(object sender, EventArgs e) // Yüzde Hesaplama
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                islem = "L";
                label1.Text = " ";
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button18_Click(object sender, EventArgs e) // Geri Alma
        {
            if (label1.Text.Length != 0)
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
                if (label1.Text.Length == 0)
                {
                    label1.Text = "0";
                }
            }
        }

        private void button17_Click(object sender, EventArgs e) // Negatif/Pozitif
        {
            if (label1.Text.StartsWith("-"))
            {
                label1.Text = label1.Text.Replace("-", " ");
            }
            else if (label1.Text.StartsWith(" "))
            {
                label1.Text = label1.Text.Replace(" ", "-");
            }
            else if (label1.Text.StartsWith("0"))
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = "-" + label1.Text;
            }
        }

        private void button16_Click(object sender, EventArgs e) // Virgül Koyma
        {
            if ((label1.Text == "") | (label1.Text.EndsWith(",")))
            {
                label1.Text += "";
            }
            else if (label1.Text == Math.PI.ToString())
            {
                label1.Text = "0,";
            }
            else if (label1.Text == "0")
            {
                label1.Text += ",";
            }
            else
            {
                label1.Text += ",";
            }
            button16.Enabled = false;
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e) // Klavyeyle Yazma
        {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                button10.Select();
                button10.PerformClick();
            }
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                button1.Select();
                button1.PerformClick();
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                button2.Select();
                button2.PerformClick();
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                button3.Select();
                button3.PerformClick();
            }
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                button4.Select();
                button4.PerformClick();
            }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                button5.Select();
                button5.PerformClick();
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                button6.Select();
                button6.PerformClick();
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                button7.Select();
                button7.PerformClick();
            }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                button8.Select();
                button8.PerformClick();
            }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                button9.Select();
                button9.PerformClick();
            }
            if (e.KeyCode == Keys.Add)
            {
                button14.Select();
                button14.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                button13.Select();
                button13.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                button12.Select();
                button12.PerformClick();
            }
            if (e.KeyCode == Keys.Divide)
            {
                button11.Select();
                button11.PerformClick();
            }
            if (e.KeyCode == Keys.Oemcomma)
            {
                button16.Select();
                button16.PerformClick();
            }
        }

        private void label2_Click(object sender, EventArgs e) // Bilimsel Hesaplama / Standart Hesaplama
        {
            if (label2.Text == "Standart")
            {
                label2.Text = "Bilimsel";
                this.Width = 685;
                this.Height = 445;
                label1.Width = 658;
                button25.Show();
                button26.Show();
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                button31.Show();
                button32.Show();
                button33.Show();
                button34.Show();
                button35.Show();
                button36.Show();
                button37.Show();
                button38.Show();
                button39.Show();
                button40.Show();
                button41.Show();
                button42.Show();
                button43.Show();
                button44.Show();
                button45.Location = new Point(584, 348);
                button46.Location = new Point(501, 348);
                button47.Location = new Point(418, 348);
                button48.Location = new Point(335, 348);
            }
            else
            {
                label2.Text = "Standart";
                this.Width = 353;
                this.Height = 505;
                label1.Width = 320;
                button25.Hide();
                button26.Hide();
                button27.Hide();
                button28.Hide();
                button29.Hide();
                button30.Hide();
                button31.Hide();
                button32.Hide();
                button33.Hide();
                button34.Hide();
                button35.Hide();
                button36.Hide();
                button37.Hide();
                button38.Hide();
                button39.Hide();
                button40.Hide();
                button41.Hide();
                button42.Hide();
                button43.Hide();
                button44.Hide();
                button45.Location = new Point(253, 405);
                button46.Location = new Point(170, 405);
                button47.Location = new Point(87, 405);
                button48.Location = new Point(4, 405);
            }
        }

        private void label2_MouseEnter(object sender, EventArgs e) // Beyaz
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e) // Siyah
        {
            label2.ForeColor = Color.Black;
        }

        private void button44_Click(object sender, EventArgs e) // Pi Sayısı
        {
            if (label1.Text != Math.PI.ToString())
            {
                label1.Text = Math.PI.ToString();
            }
            else
            {
                label1.Text = label1.Text + Math.PI.ToString();
            }
        }

        private void button43_Click(object sender, EventArgs e) // Faktöriyel Bulma
        {
            try
            {
                double faktoriyel = 1;
                sayi1 = Convert.ToDouble(label1.Text);
                for (double i = 1; i <= sayi1; i++)
                {
                    faktoriyel *= i;
                }
                label1.Text = faktoriyel.ToString();
            }
            catch
            {
                Gecersizİslem();
            }
            button16.Enabled = true;
        }

        private void button25_Click(object sender, EventArgs e) // x üzeri y
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                islem = "xy";
                label1.Text = " ";
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button26_Click(object sender, EventArgs e) // y kök x
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                islem = "yx";
                label1.Text = " ";
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button27_Click(object sender, EventArgs e) // 10 üzeri x
        {
            try
            {
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button28_Click(object sender, EventArgs e) // e üzeri x
        {
            try
            {
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button32_Click(object sender, EventArgs e) // Sin
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                double sin = Math.Sin(sayi1 * (Math.PI / 180));
                label1.Text = sin.ToString();
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button31_Click(object sender, EventArgs e) // Sinh
        {
            try
            {
                double cosec = double.Parse(Math.Sinh(double.Parse(label1.Text)).ToString());
                label1.Text = cosec.ToString();
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button30_Click(object sender, EventArgs e) // Cos
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                double cos = Math.Cos(sayi1 * (Math.PI / 180));
                label1.Text = cos.ToString();
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button29_Click(object sender, EventArgs e) // Cosh
        {
            try
            {
                double sec = double.Parse(Math.Cosh(double.Parse(label1.Text)).ToString());
                label1.Text = sec.ToString();
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button36_Click(object sender, EventArgs e) // Tan
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                double tan = Math.Tan(sayi1 * (Math.PI / 180));
                label1.Text = tan.ToString();
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button35_Click(object sender, EventArgs e) // Tanh
        {
            try
            {
                double cot = double.Parse(Math.Tanh(double.Parse(label1.Text)).ToString());
                label1.Text = cot.ToString();
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button34_Click(object sender, EventArgs e) // Log
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                double log = Math.Log10(sayi1);
                label1.Text = log.ToString();
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button33_Click(object sender, EventArgs e) // Ln
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                double ln = Math.Log(sayi1);
                label1.Text = ln.ToString();
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button40_Click(object sender, EventArgs e) // İstenilen Sayıda 0 Ekleme
        {
            islem = "Exp";
            if (label1.Text == "0")
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text += ",e+";
            }
        }

        private void button39_Click(object sender, EventArgs e) // Mod Alma
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                islem = "Mod";
                label1.Text = " ";
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button38_Click(object sender, EventArgs e) // Mutlak Değer Bulma
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(Math.Abs(sayi1));
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button37_Click(object sender, EventArgs e) // En Yakın Tam Sayıya Yuvarlama
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(Math.Round(sayi1));
            }
            catch
            {
                Gecersizİslem();
            }
            button16.Enabled = true;
        }

        private void button41_Click(object sender, EventArgs e) // +, - veya 0 Olma Durumu
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(Math.Sign(sayi1));
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void button42_Click(object sender, EventArgs e) // Ortalama Hesaplama
        {
            try
            {
                sayi1 = Convert.ToDouble(label1.Text);
                islem = "Ave";
                label1.Text = " ";
            }
            catch
            {
                Gecersizİslem();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) // Geçersiz İşlem Hatası
        {
            zaman--;
            if (zaman == 0)
            {
                timer1.Stop();
                label1.Text = "0";
                zaman = 2;
            }
        }

        private void button19_Click(object sender, EventArgs e) // Sıfırlama
        {
            sayi1 = 0;
            sayi2 = 0;
            islem = " ";
            label1.Text = "0";
            button16.Enabled = true;
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e) // Bilgi Mesajı
        {
            DialogResult bilgilendirme = MessageBox.Show("Gökay tarafından yapıldı.", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bilgilendirme == DialogResult.OK)
            {
                MessageBox.Show("~ Hesap Makinesi Kullanımı ~\n\n\nx² : Girilen sayının karesini alır.\nx³ : Girilen sayının küpünü alır.\n√ : Girilen sayının karekökünü alır.\n1/x : 1'i girilen sayıya böler.\n% : Yüzde hesaplar.\n+ : Toplama işlemi yapar.\n- : Çıkarma işlemi yapar.\n× : Çarpma işlemi yapar.\n÷ : Bölme işlemi yapar.\n= : İşlemleri yapar.\n± : Negatif/Pozitif çevirimi yapar.\n, : Sayıya virgül ekler.\nx^y : Girilen sayının istenilen dereceden kuvvetini bulur.\ny√x : Girilen sayının istenilen dereceden kökünü bulur.\n10^x : Girilen sayıyı 10'un kuvveti olarak alır.\ne^x : Girilen sayıyı e'nin kuvveti olarak alır.\nsin : Sinüs hesaplar.\nsinh : Hiperbolik sinüs hesaplar.\ncos : Cosinus hesaplar.\ncosh : Hiperbolik cosinus hesaplar.\ntan : Tanjant hesaplar.\ntanh : Hiperbolik tanjant hesaplar.\nlog : 10 tabanında logaritma hesaplar.\nln : Logaritma hesaplar.\nExp : Sayının sonuna istenilen kadar 0 ekler.\nMod : Kalan hesaplar.\nAbs : Mutlak değer hesaplar.\nRnd : En yakın tam sayıya yuvarlar.\nAve : Ortalama hesaplar.\nSign : Negatiflik, pozitiflik durumu belirler.\nn! : Faktöriyel hesaplar.\nπ : Pi sayısını tutar.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}