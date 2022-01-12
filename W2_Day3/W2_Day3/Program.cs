using System;
using System.Collections.Generic;

namespace W2_Day3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("girdiğiniz sayi: "+ sayiGir());

            //Console.WriteLine("sayi giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("girdiğiniz sayi: " + sayiGir2(sayi));

            //Console.WriteLine(faktöriyel());

            //Console.WriteLine(isPrime(11));

            /* int[] dizi = Random10();

             for (int i = 0; i < dizi.Length; i++)
             {
                 Console.Write(dizi[i] + " ");
             }*/


            /*  int[] dizim = { 1, 3, 56, 78 };

              DiziYaz(dizim);                           */

            /*  int[] a = { 1, 3, 5, 66, 88,77 };
              List<int> b = new List<int>();

              b = tekDizi(a);
              foreach (var item in b)
              {
                  Console.WriteLine(item +" ");
              }                      */


            /*    List<int> a = new List<int>();
                a = sayiGetir10();
                Console.WriteLine("Girilen Sayılar: ");
                foreach (var item in a)
                {
                    Console.WriteLine(item+" ");
                }                                                 */


            /* Console.WriteLine("en giriniz: ");
               double en = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("boy giriniz: ");
               double boy = Convert.ToDouble(Console.ReadLine());
               cevreVealan(en,boy);                                              */


            List<string> gelenYazilar = cokYaz(5);







         }

        

        // liste tipinde aldığı 10 adet sayının karelerini List tipinde döndüren metodu yaz. (2 tane list olacak).

        static List<int> kareleri(List<int> onsayi)
        {
            List<int> diziKareleri = new List<int>();

            foreach (var item in onsayi)
            {
                diziKareleri.Add(onsayi[item] * onsayi[item]);
            }
            return diziKareleri;
        }



            //sayi girisini otomatikleştiren metodu yazınız.  kullanıcıdan alınan int tipindeki sayıyı döndürecek. 

            static int sayiGir()
            {
                Console.WriteLine("sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                return sayi;

            }

            static int sayiGir2(int sayi)
            {
                return sayi;

            }

            //parametre olarak aldığı sayının faktöriyelini alıp döndüren metot.

            static int faktöriyel()
            {
                Console.WriteLine("sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                int toplam = 1;
                for (int i = 2; i <= sayi; i++)
                {
                    toplam *= i;
                }

                return toplam;
            }

            //parametre olarak aldığı sayının asal olup olmadığını döndüren metot.    asal iste true değil ise false döndürsün.

            static bool isPrime(int sayi)
            {

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        return false;
                    }
                }
                return true;

            }

            // 0-100 aralığında rastgele ürettiği 10 sayıyı int tipinde dizi(array) olarak döndüren metot.

            static int[] Random10()
            {
                int[] rastgele10 = new int[10];

                Random r = new Random();

                for (int i = 0; i < 10; i++)
                {
                    rastgele10[i] = r.Next(1, 101);
                }

                return rastgele10;

            }

            //kendisine gönderilen dizideki tek sayıları yine dizi ile döndüren metodu yazınız.    Limit=20 eleman sayısı

        static List <int> tekDizi(int[] dizi)
        {

            List<int> tekDizi = new List<int>();

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 != 0)
                {
                    tekDizi.Add(dizi[i]);
                }
            }

            return tekDizi;
        } 

          
            //diziYaz metodu yazınız parametre olarak int[] dizi alsın.

            static void DiziYaz(int [] dizi)
            {
                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.Write(dizi[i]+ " ");
                }
            }

        static void diziYaz(int[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.WriteLine(item + " ");
            }
        }

        static void DiziYaz(int[] dizi, bool sifirlariYaz)
        {

        }


        //Buyuk2li.   aldığı iki sayıdan buyuk olanı döndüren metodu yazınız.

        static int Buyuk2li(int sayi1,int sayi2)
        {
            int buyuk = sayi1;
            if(sayi2>sayi1)
            {
                buyuk = sayi2;
            }
            return buyuk;
        }
        
        //liste sorusu: kullanıcıdan 10 sayı alıp liste ile döndüren metod.  metod ismi:sayiGetir10

        static List<int> sayiGetir10()
        {
            List<int> sayiGetir = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("sayi "+ (i+1) +"giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayiGetir.Add(sayi);
            }
            return sayiGetir;
        }

        //parametreler(enKucuk, enBuyuk, sayiAdedi)
        //metot: bu parametreleri alıp sayiAdedi kadar enKucuk ile enBuyuk arasında rastgele sayi üretip liste olarak geri dönsün.

        static List<int> SayiUret(int enKucuk, int enBuyuk, int sayiAdedi)
        {
            Random r = new Random();
            List<int> sonucListem = new List<int>();
            for (int i = 0; i < sayiAdedi; i++)
            {
                sonucListem.Add(r.Next(enKucuk, enBuyuk));
            }
            return sonucListem;
        }

        //listeyi tek string yapan metodd

        static string ListToString (List<string> kelimeler)
        {
            string sonuc = "";
            foreach (var item in kelimeler)
            {
                sonuc += item;
            }
            return sonuc;
        }

       

        static void cevreVealan (double en,double boy)
        {
           
            double cevre = (en + boy) * 2;
            double alan = en * boy;

            Console.WriteLine("cevre: " + cevre);
            Console.WriteLine("alan: " + alan);

        }

        // 1.metot: kullanıcıdan veri girişi alan ve girilen stringi geri dönen Yaz() metodu.

        //2.metot: cokYaz(int adet) adet kadar input(Yaz) alacak, List halinde geri döndürecek.
        
        static string Yaz()
        {
            Console.WriteLine("string giriniz: ");

            string sonuc = Console.ReadLine();

            return sonuc;
        }

        static List<string> cokYaz(int adet)
        {
            List<string> yazilar = new List<string>();
            for (int i = 0; i < adet; i++)
            {
                
                yazilar.Add(Yaz());
                
            }
            return yazilar;
        }

        


      







        }
    }

