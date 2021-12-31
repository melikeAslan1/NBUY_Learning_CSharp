using System;

namespace Day_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int sayi = Convert.ToInt32(Console.ReadLine());
               int basamak = 0;
               while (sayi > 0)
               {
                   basamak++;
                   sayi = sayi / 10;
               }
               Console.WriteLine("Girdiğiniz sayı" + basamak + "basamaklıdır.");                               */

            //rastgele sayı üretme:    Random rnd=new Random();

            //int [] yas;
            // double [] para;
            // dizi oluşturup uzunluk vermek:  int [] array1=new int {1,3,5,7,9};

            // string [] gunler= { 

            /* int[] array1 = new int[] { 1, 3, 5, 7, 9 };
               for (int i = 0; i < array1.Length; i++)
               {
                   Console.WriteLine(array1[i]);
               }                                                                                   */


            /*        int[] intArray;
                      intArray = new int[5];
                      intArray[0] = 10;

                      // dizinin ikinci dizinine değer ataa
                      intArray[1] = 20;

                      // sonraki dizinlerine değer ataa
                      intArray[2] = 30;
                      intArray[3] = 40;
                      intArray[4] = 50;

                      Console.Write("For Döngüsü :");
                      for (int i = 0; i < intArray.Length; i++)
                          Console.Write(" " + intArray[i]);

                      Console.WriteLine("");                            */


            /*     int[] intArray;
                   intArray = new int[5];
                   intArray[0] = 10;

                   // dizinin ikinci dizinine değer ataa
                   intArray[1] = 20;

                   // sonraki dizinlerine değer ataa
                   intArray[2] = 30;
                   intArray[3] = 40;
                   intArray[4] = 50;

                   Console.Write("Foreach :");
                   foreach (int i in intArray)
                       Console.Write(" " + i);              */

            /*      int[] intArray;
                    intArray = new int[5];
                    intArray[0] = 10;

                    // dizinin ikinci dizinine değer ataa
                    intArray[1] = 20;

                    // sonraki dizinlerine değer ataa
                    intArray[2] = 30;
                    intArray[3] = 40;
                    intArray[4] = 50;

                    int j = 0;
                    while (j < intArray.Length)
                    {
                        Console.Write(" " + intArray[j]);
                        j++;
                    }                                                 */

            /* int [] dizi= new int[] {10,20,15,5,7,3,4,12,8,39,2};
               int toplam = 0;

               foreach(int i in dizi)
               {
                    toplam += i;
               }
               Console.WriteLine("toplam: " + toplam);            */

            /*       int[] dizi = { 10, 20, 15, 5, 7, 3, 4, 12, 8, 39, 2 };
                   int enbuyuk = dizi[0];
                   int enkucuk = dizi[0];
                   for (int i = 0; i < dizi.Length; i++)
                   {
                       if (dizi[i] > enbuyuk)
                           enbuyuk = dizi[i];

                       if (dizi[i] < enkucuk)
                           enkucuk = dizi[i];
                   }
                   Console.WriteLine("En küçük :{0}", enkucuk);
                   Console.WriteLine("En büyük :{0}", enbuyuk);                */

            /*     int gecerNot = 50;
                 int[] dizi = { 40, 60, 50, 70, 30, 34, 60, 20, 80, 100 };
                 int kalan = 0;
                 int gecen = 0;

                 for(int i = 0; i <dizi.Length; i++)
                 {
                     if(dizi[i]>=gecerNot)
                     {
                         gecen++;
                     }
                     if (dizi[i] < gecerNot)
                     {
                         kalan++;
                     }
                 }
                 Console.WriteLine("kalan sayısı: " + kalan + "\n gecen sayısı: " + gecen);         */

            /*      String [] günler = { "pazartesi", "sali", "carsamba", "persembe", "cuma" };

                  Console.WriteLine("gün giriniz: ");
                  String gun = Console.ReadLine();


                  for(int i=0; i<günler.Length; i++)
                  {
                     if(gun==günler[i])
                      {
                          Console.WriteLine(i + 1 + " . gündür.");
                      }
                  }                                                    */

            //Console.WriteLine("isim soyisim giriniz: ");
            //string isimSoyisim = Console.ReadLine();


            /*       Console.WriteLine("sınıf mevcudu giriniz: ");
                   int mevcut = Convert.ToInt32(Console.ReadLine());
                   string isim;
                   string[] ögrenciler = new string[mevcut];

                   for(int i=0; i<mevcut; i++)
                   {
                       Console.WriteLine(i +1 + ". öğrenci isim giriniz: ");
                       isim= Console.ReadLine();
                       ögrenciler[i] = isim;

                   }

                   Console.WriteLine("sınıf listesi: ");

                   for(int i=0; i<ögrenciler.Length; i++)
                       Console.WriteLine(i + 1 + ". öğrenci: " + ögrenciler[i]);                    */

            /*    // do while ile döngüyü yazdırma

                int k = 0;
                do
                {
                    Console.Write(" " + intArray[k]);
                    k++;
                } while (k < intArray.Length);   */

            /*       int[] dizi = new int[20];

                     Random rnd = new Random();
                     int sayi;
                     int pozitif = 0;
                     int negatif = 0;
                     int isaretsiz = 0;

                    for(int i=0; i<dizi.Length; i++)
                     {
                         dizi[i]=rnd.Next(-100, 100);
                     }

                     foreach(int i in dizi)
                     {
                         Console.WriteLine(i);
                         if (i < 0)
                             negatif++;
                         else if (i > 0)
                             pozitif++;
                         else
                             isaretsiz++;

                     }
                     Console.WriteLine("pozitif: " + pozitif + "\n negatif: " + negatif + "\n isaretsiz: " + isaretsiz);     */

      /*    int[] dizi = { 10, 15, 20, 33, 98, 56, 22, 45, 98,99 };
            int sayi = 0;
            Console.WriteLine("tek sayılar: ");

            foreach(int i in dizi)
            {
                if (i % 2 != 0) { 
                    Console.WriteLine(i);
                sayi++;
                                        }

            }
            Console.WriteLine("tek sayı adedi: " + sayi);   */

            //YENİ BİR SATİR EKLEDİMM..












































        }
    }
}
