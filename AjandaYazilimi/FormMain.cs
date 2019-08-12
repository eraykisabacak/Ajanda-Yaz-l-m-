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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKayit formKayit = new FormKayit();
            formKayit.Show();
        }

        private void personelAramaEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAra formAra = new FormAra();
            formAra.Show();
        }
    }
}
