using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form

        
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Araba arabaNesnesi = new Araba();
            //arabaNesnesi.ID = 1;
            //arabaNesnesi.Marka = "Mazda";
            //arabaNesnesi.Model = "6.0";
            //arabaNesnesi.BilgiYaz();

            //Araba araba2 = new Araba(2, "Mercedes", "S500");

            Ogrenci o = new Ogrenci();
            //o.TcKimlikNo = 3456;
            //o.Ad = "Melike";
            //o.Soyad = "Aslan";
            //o.SinifOgretmeni = "Veysel";
            //o.OkulNo = "2312";

            //o.BilgiYaz();

            Ogretmen ogretmen = new Ogretmen();

            ogretmen.OgrenciListele();


        }

        
    }
}
