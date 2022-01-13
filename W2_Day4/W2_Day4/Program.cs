using System;
using System.Collections.Generic;

namespace W2_Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   //sayı tahmin oyunu
               Random r = new Random();
               int sayi = r.Next(1, 1001);
               List<int> tahminler = new List<int>();



               for (int i = 1; i <= 10; i++)
               {
               Console.WriteLine("tahmin yapınız: ");
               int tahmin = Convert.ToInt32(Console.ReadLine());


                   if (tahmin < sayi)
                   {
                       Console.WriteLine("tahmininiz küçük");
                       tahminler.Add(tahmin);

                   }
                   else if(tahmin>sayi)
                   {
                       Console.WriteLine("tahmininiz büyük");
                       tahminler.Add(tahmin);
                   }
                   else 
                   {
                       Console.WriteLine("Tebrikler tutturdunuz.");
                       break;
                   }
               }
               Console.WriteLine("tutturamadınız sayi "+sayi+" idi.");
               Console.WriteLine(" ");
               Console.WriteLine("basarısız tahminleriniz: ");

               foreach (var item in tahminler)
               {
                   Console.WriteLine(item+" ");
               }                                                       */


            /* // tamamını  yaz.

             List<int> Liste1 = new List<int>();
             List<int> Liste2 = new List<int>();
             List<int> Liste3 = new List<int>();

             Random r = new Random();

             for (int i = 1; i <= 10; i++)
             {
                 Liste1.Add(r.Next(1, 21));
                 Liste2.Add(r.Next(1, 21));
             }

             for (int i = 0; i < 10; i++)
             {

                 if (Liste1[i] != Liste2[i])
                 {

                     Liste3.Add(Liste1[i]);
                 }
             }

             Console.Write("Liste1= ");
             foreach (var item in Liste1)
             {
                 Console.Write(item + " ");
             }
             Console.WriteLine("Liste2: ");
             foreach (var item in Liste2)
             {
                 Console.Write(item + " ");
             }
             Console.WriteLine("Liste3: ");
             foreach (var item in Liste3)
             {
                 Console.Write(item + " ");
             }                                     */



            /*   // liste içinde liste

               List<object> listem = new List <object>();

               List<int> sayilarim1 = new List<int> { 23, 34, 45 };

               List<int> sayilarim2 = new List<int> { 65, 54, 21 };


               listem.Add(sayilarim1);   */


            //Basit bir Personel Bilgi Sistemi:
            // TC(long), adSoyad string, adres string, telefon string için birer tane liste
            // tanımlayınız. PersonelIndexGetir(tc),PersonelEkleGuncelle(başarılı ise true döndür)
            // PersonelAra: (TC veya adSoyad ile arama yapacak) tüm bilgileri tek string olarak döndür.
            //PersonelSil(tc): Remove edecek. 
            //
            //Ödev: PersonelEkleGuncelle yi PersonelGuncelle ve PersonelEkle olarak yazınız. 

            int index = PersonelIndexGetir(67309105720);
            Console.WriteLine("index=" + index);
            bool basarili = PersonelEkleGuncelle(tc: 67309105720,
                                 adSoyad: "Veysel Perü",
                                 adres: "SahrayıCedit/Kadıköy...",
                                 telefon: "05327741763");
            basarili = PersonelEkleGuncelle(tc: 1111,
                               adSoyad: "Ezgi",
                               adres: "Bostancı...",
                               telefon: "05321111111");
            basarili = PersonelEkleGuncelle(tc: 22222222222,
                               adSoyad: "Şükrü",
                               adres: "Sarıgazi...",
                               telefon: "05322222222");
            basarili = PersonelEkleGuncelle(tc: 3333333333,
                               adSoyad: "Uğur Okan",
                               adres: "Bağcılar...",
                               telefon: "05323333333");
            basarili = PersonelEkleGuncelle(tc: 44444444444,
                               adSoyad: "Melike",
                               adres: "Beşiktaş...",
                               telefon: "05324444444");
            index = PersonelIndexGetir(67309105720);
            Console.WriteLine("index=" + index);

            basarili = PersonelEkleGuncelle(tc: 67309105720,
                                 telefon: "0555 5555555");
            for (int i = 0; i < TCler.Count; i++)
            {
                Console.WriteLine(TCler[i]);
                Console.WriteLine(adSoyadlar[i]);
                Console.WriteLine(adresler[i]);
                Console.WriteLine(telefonlar[i]);
            }
            Console.ReadLine();
        } // Main sonu 

        static int PersonelIndexGetir(long tc)
        {
            int personelIndex = -1;
            if (TCler.Contains(tc))
            {
                personelIndex = TCler.IndexOf(tc);
            }
            return personelIndex;
        }

        private static bool PersonelEkleGuncelle(long tc = 0, string adSoyad = "", string adres = "", string telefon = "")
        {
            int personelIndex = -1;
            if (tc < 10000000000 || tc > 99999999999)
            {
                Console.WriteLine("TC formatı yanlış. (" + tc + ")  Entera basınız.");
                Console.ReadLine();
                return false;
            }
            if (tc == 0)
            {
                Console.WriteLine("TC sıfır olamaz. Entera basınız.");
                Console.ReadLine();
                return false;
            }
            else
            {
                personelIndex = PersonelIndexGetir(tc);
                if (personelIndex == -1)       // Personel yok, o zaman ekleyeceğiz.
                {
                    if (adSoyad == "")
                    {
                        Console.WriteLine("Ad Soyad boş olamaz. Entera basınız.");
                        Console.ReadLine();
                        return false;
                    }
                    TCler.Add(tc);
                    adSoyadlar.Add(adSoyad);
                    adresler.Add(adres);
                    telefonlar.Add(telefon);
                }
                else   // TC var, o zaman güncelle!
                {
                    if (adSoyad != "") adSoyadlar[personelIndex] = adSoyad;
                    if (adres != "") adresler[personelIndex] = adres;
                    if (telefon != "") telefonlar[personelIndex] = telefon;
                }
            }
            return true;













        }  //main sonu
           //Kendisine gönderilen double dizisini float dizisine ceviren MakeItFloat isimli metodu yazınız.

        private static bool PersonelEkleGuncelle(long tc=0, )


    }
}
