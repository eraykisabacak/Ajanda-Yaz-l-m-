using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjandaYazilimi
{
    public partial class FormKayit : Form
    {
        public FormKayit()
        {
            InitializeComponent();

            Personel personel = new Personel("Eray","Kısabacak");

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            DateTime dogumtarihi = dateTimePicker1.Value;
            string meslek = textBox3.Text;
            string cinsiyet, medeni_durum;

            

            string maas= numericUpDown1.Value.ToString(),
                istel = textBox6.Text, 
                gsm = textBox5.Text, 
                email = textBox4.Text, 
                adres = textBox7.Text;

            if (radioButton1.Checked)
            {
                cinsiyet = "ERKEK";
            }
            else
            {
                cinsiyet = "KADIN";
            }

            if (radioButton3.Checked)
            {
                medeni_durum = "EVLİ";
            }
            else
            {
                medeni_durum = "BEKAR";
            }
            Personel personel = new Personel("Eray", "Kısabacak", dogumtarihi);
            personel.DosyayaYaz(ad,soyad,meslek,cinsiyet,medeni_durum,maas,email,adres,personel.ajanda(istel,gsm));
            MessageBox.Show(personel.Yas + " Yaşında");
            MessageBox.Show(personel.KalanGünSayısı());
        }

        public void ara(string ad,string soyad, string dogumtarihi, string meslek, string cinsiyet,string medeni_durum,string maas)
        {
            textBox1.Text = ad;
            textBox2.Text = soyad;
            dateTimePicker1.Value = DateTime.Parse(dogumtarihi);
            textBox3.Text = meslek;
            if(cinsiyet == "ERKEK")
            {
                radioButton1.Select();
            }
            else
            {
                radioButton2.Select();
            }

            if (medeni_durum == "BEKAR")
            {
                radioButton4.Select();
            }
            else
            {
                radioButton3.Select();
            }

            numericUpDown1.Value = int.Parse(maas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            numericUpDown1.Value = 0;
            dateTimePicker1.Value = DateTime.Parse("12.12.2012");
        }
    }
}
