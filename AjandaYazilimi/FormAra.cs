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
    public partial class FormAra : Form
    {
        public FormAra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string personeladi = textBox1.Text;
            List<Personel> personeller = new List<Personel>();
            string dosya_yolu = @"C:\Users\nefre\source\repos\AjandaYazilimi\data.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();

            while (yazi != null)
            {
                char ayrac = '|';
                string[] bilgiler = yazi.Split(ayrac);
                if (bilgiler[0] == personeladi)
                {
                    FormKayit araFormKayit = new FormKayit();
                    araFormKayit.Show();
                    araFormKayit.ara(bilgiler[0], bilgiler[1], bilgiler[2], bilgiler[3], bilgiler[4], bilgiler[5], bilgiler[6]);
                    break;
                }
                else
                {
                    yazi = sw.ReadLine();
                }
            }
        }
    }
}
