using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjandaYazilimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;
            string dosya_yolu = @"C:\Users\nefre\source\repos\AjandaYazilimi\users.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            char[] ayrici = { '-' };
            string[] dizi = yazi.Split(ayrici);
            for(int a = 0; a < dizi.Length; a++)
            {
                if(dizi[a] == kullaniciadi && dizi[a+1] == sifre)
                {
                    FormMain ChildForm = new FormMain();
                    this.Hide();
                    ChildForm.Show();
                }
                
            }        
            sw.Close();
            fs.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
