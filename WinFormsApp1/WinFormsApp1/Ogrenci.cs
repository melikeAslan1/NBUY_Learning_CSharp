using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    /* Ogrenci sınıfını asagıdaki özellik ve metotları tanımlayınız.
        properties: TcKimlikNo, OkulNo, Ad, Soyad, SinifOgretmeni
        Methods: SinifOgretmeniDegistir(string ogretmen)
        Methods: BilgiYaz(), ogrencinin tüm bilgilerni ekrana yazılsın
        Methods: Parametreli yapıcı metot ekleyin.
    */



    /*  Access Modifiers; Erişim Belirleyici
     *  
        1- Private: Özel anlamındadır. Sadece bulunduğu yapı içinden erişilebilir. Başak yerden erişilemez.

        2- Internal: Bulunduğu proje içinde her yerde erişimi sağlar.

        3- Protected: Miras alınan sınıflar içerisinden erişime izin verir.

        4- Protected Internal: Hem Miras alınan sınıflar içerisinden hem de bulunduğu proje içinde her yerden erişime izin verir. 

        5-Public: Umumi, kamu malıdır. Her yerden erişime izin verir. 
                                                                   */



    public class Ogrenci
    {
        public long TcKimlikNo;
        public string OkulNo;
        public string Ad;
        public string Soyad;
        public Ogretmen SinifOgretmeni;

        public Ogrenci(long tcKimlikNo, string okulNo, string ad, string soyad, string sinifOgretmeni)
        {
            TcKimlikNo = tcKimlikNo;
            OkulNo = okulNo;
            Ad = ad;
            Soyad = soyad;
            SinifOgretmeni = sinifOgretmeni;
        }

        public Ogrenci(){

            }

   public void SinifOgretmeniDegistir(String ogretmen) {
            this.SinifOgretmeni = ogretmen;

        }




        public void BilgiYaz()
        {
          
        }


    }

}



