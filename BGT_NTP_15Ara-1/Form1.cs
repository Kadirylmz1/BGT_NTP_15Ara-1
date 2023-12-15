using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGT_NTP_15Ara_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<Ogrenci> ogrenciler = new List<Ogrenci>();
                
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.ADSOYAD = textBox1.Text;
            ogr.OGRNO = Convert.ToInt32(textBox2.Text);

            ogrenciler.Add(ogr);

            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ogrenciler.Count; i++)
            {
                listBox1.Items.Add(ogrenciler[i].ADSOYAD);
            }
        }
    }
}
