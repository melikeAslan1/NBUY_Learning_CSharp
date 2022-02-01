using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class Araba
    {

        public int ID;
        public string Marka;
        public string Model;

        public Araba()
        {
            MessageBox.Show("Yapıcı metot çalıştı");

            /* YAPICI METOTLAR: CONSTRUCTOR
             * Metot adı sınıf adı ile aynı olmalıdır. Public olmalıdır.
             * Tanımlanmasa da boş hali arka planda çalışır.
             */

        }

        public Araba(int ID, string marka, string model)
        {
            MessageBox.Show("3 parametreli yapıcı metot çalıştı");
            this.ID = ID;
            Marka = marka;
            Model = model;
        }


        public void BilgiYaz()
        {
            MessageBox.Show("Marka: " + this.Marka);
            MessageBox.Show("Model: " + this.Model);

            //this kullanılıyorsa property belirtilmiştir.
        }

    }
}
