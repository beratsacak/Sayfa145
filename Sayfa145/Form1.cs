using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa145
{
    public partial class Form1 : Form
    {
        class Ogrenciler
        {
            public int Numara { get; set; }
            public string AdSoyad { get; set; }
        }
        List<int> numaralarList = new List<int>();
        List<string> adsoyadList = new List<string>();
        List<Ogrenciler> ogrencilerList = new List<Ogrenciler>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numaralarList.Add(int.Parse(numara.Text));
            Numaralar.Items.Clear();
            foreach (var item in numaralarList)
            {
                Numaralar.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adsoyadList.Add(adSoyad.Text);
            AdSoyadlar.Items.Clear();
            foreach (var item in adsoyadList)
            {
                AdSoyadlar.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = int.Parse(Numaram.Text);
            ogrenci.AdSoyad = adSoyadN.Text;
            ogrencilerList.Add(ogrenci);
            Nesneler.Items.Clear();
            foreach (var item in ogrencilerList)
            {
                Nesneler.Items.Add(item.AdSoyad+" " +item.Numara + " ");
            }
        }
    }
}
