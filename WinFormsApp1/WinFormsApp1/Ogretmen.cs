﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class Ogretmen
    {
        // ID, Ad, Soyad, ogrenciler (List of Ogrenci)
        //BilgiYaz (Ad Soyad)
        //OgrenciListele

        public int ID;
        public string Ad;
        public string Soyad;
        public List<Ogrenci> ogrenciler;


        public Ogretmen(){

            // Nesne oluşturulduğu anda RAM'de Liste için alan açılır. Liste oluşturulur.
            this.ogrenciler = new List<Ogrenci>();


            }

        public void OgrenciListele()
        {
            MessageBox.Show("***" + Ad + " " + Soyad + "öğretmenin öğrencileri");
            foreach(var item in this.ogrenciler)
            {
                MessageBox.Show(item.Ad + " " + item.Soyad);
            }
            MessageBox.Show("****************************************************");

        }




    }
}
