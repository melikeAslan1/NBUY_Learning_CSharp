using System;
using System.Linq;

namespace W2_Day1
{
    class Program
    {
        static void Main(string[] args)
        {

            ////tip [] diziAdı=new tip[boyut];
            ////tip [] sayilar=new int[10];
            //int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            ////int rakamlar = new int[10];

            ////int[] sayilar=new int[10];
            ////indis numaraları 0 dan baslar, birer birer artarak devam eder.

            //string isim1 = "Ahmet";
            //string isim2 = "Ali";
            //string isim3 = "Ayşe";
            //string isim4 = "Veli";
            //string isim5 = "Eda";

            //string[] isimler = new string[5];

            //isimler[0] = "Ahmet";
            //isimler[1] = "Ali";
            //isimler[2] = "Ayşe";


            //rakamlar[1] = 100;  //ikinci elemana 100 atar.
            //rakamlar.SetValue(130, 0);      //birinci elemana 130 atar.

            //Console.WriteLine("rakamlar.GetValue(1)= "+rakamlar.GetValue(1));
            //Console.WriteLine("rakamlar[1]= "+ rakamlar[1]);

            //Console.WriteLine("rakamlar.GetType()= "+ rakamlar.GetType());
            //Console.WriteLine("rakamlar.Length()= " + rakamlar.Length);

            //for(int i=0; i<isimler.Length; i++)
            //{
            //    Console.WriteLine("isimler["+i+"]="+isimler[i]);

            //}

            //Console.WriteLine("------------------------------------------------------------");
            //for (int i = 0; i < isimler.Length; i++)
            //    Console.WriteLine("isimler[" + i + "]=" + isimler[i]);

            //string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya" };

            ////for + iki kere tab     for u kısa yoldan getirir.

            //for (int i = 0; i < isimler.Length; i++)
            //                     Console.WriteLine("isimler[" + i + "]=" + isimler[i]);
            //Console.WriteLine("-------------------------------------------------------------");

            //int k = 0;

            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine("Sehirler["+k+"]="+item);
            //    k++;
            //}

            ////iki array olusturalim.

            //string[] mySourceArray = new string[10];

            //mySourceArray[0] = "yuvalarında";
            //mySourceArray[1] = "uyuyan";
            //mySourceArray[2] = "üç";
            //mySourceArray[3] = "uykulu";
            //mySourceArray[4] = "tavuğun";
            //mySourceArray[5] = "5";
            //mySourceArray[6] = "6";
            //mySourceArray[7] = "7";
            //mySourceArray[8] = "8";
            //mySourceArray[9] = "9";

            //string[] myTargetArray = new string[15];
            //myTargetArray[0] = "Çevik";
            //myTargetArray[1] = "kahverengi";
            //myTargetArray[2] = "tilki";
            //myTargetArray[3] = "atladı";
            //myTargetArray[4] = "üstüne";
            //myTargetArray[5] = "tembel";
            //myTargetArray[6] = "köpeğin";

            //foreach (var item in myTargetArray)
            //{
            //    Console.WriteLine(item);
            //}
            //mySourceArray.CopyTo(myTargetArray, 5);
            //Console.WriteLine("--------------------------------------------");

            //for (int i = 0; i < mySourceArray.Length; i++)
            //{
            //    Console.WriteLine(i + " " + mySourceArray[i]);
            //}
            //Console.WriteLine("--------------------------------------------");
            //foreach (var item in myTargetArray)
            //{
            //    Console.WriteLine(item);
            //}


            /*    string[] isimler = new string[10];

                for(int i=0; i<isimler.Length; i++)
                {
                    Console.WriteLine("isim "+ (i+1) + " giriniz: ");
                    isimler[i]=Console.ReadLine();
                }

                Console.WriteLine("sonuclar: ");
                foreach (var item in isimler)
                {
                    Console.WriteLine(item);
                }                                        */

            /*      int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30, 90 };

                   Console.WriteLine("puanlar.Length= "+ puanlar.Length);                   

                // index of degerin ilk bulunan indisini getirir.
                int indis = Array.IndexOf(puanlar, 10);   // 0 gelir.
                indis = Array.IndexOf(puanlar, 10, 5);     // 6 gelir.

                Console.WriteLine("indis: "+ indis);

             //   Array.Sort(puanlar);  //kücükten büyüge sıralama

               Array.Reverse(puanlar);  //ters cevirir.

              foreach (var item in puanlar)
                {
                    Console.WriteLine(item);

                }                                              */


            /*     object[] karisikDizi = new object[10];

                 karisikDizi[0] = 10;
                 karisikDizi[1] = "Ayşe";
                 karisikDizi[2] = 15.4f;
                 karisikDizi[3] = 16.123D;

                 foreach (var item in karisikDizi)
                 {
                     Console.WriteLine(item);
                 }
                 object eleman = "Ayşe";

                 int indis = Array.IndexOf(karisikDizi, eleman);
                 Console.WriteLine("indis= "+indis);                               

             int[] ar = new int[10];
             ar[0] = 123;
             ar[9] = 124;

             foreach (var item in ar)
             {
                 Console.WriteLine(item);
             }

             Console.WriteLine("Index of= "+Array.IndexOf(ar,0,3));

             eleman = 15.4f;
             indis = Array.IndexOf(karisikDizi, eleman);
             Console.WriteLine(indis);
             Console.WriteLine("ındex of: "+ Array.IndexOf(ar,0));


             int[] dizi = new int[1000];

             Random r = new Random();

             for (int i = 0; i < dizi.Length; i++)
             {
                 dizi[i] = r.Next(0, 11);  // 0,10 verirsek 0dan 9  kadar cıkar.
             }

             int sayac = 0;
             foreach (var item in dizi)
             {
                 Console.Write(item +" ");
                 sayac++;

                 if(sayac%10==0)
                     Console.WriteLine("");
             }

             Console.WriteLine("dizi.Count()= "+ dizi.Count(sayi => sayi==7));



                 //dizideki 10 değerlerinin indeks numaralarını ekrana yazdırın. for ile.

                 int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30, 90 };
                 int startIndex = 0;
                 int adet10 = puanlar.Count(sayi => sayi == 10);
                 for (int i = 0; i < adet10; i++)
                 {
                     startIndex = Array.IndexOf(puanlar, 10, startIndex);//puanlar içinde
                     // 10 değerini arattır, startIndex ten başla. 
                     Console.WriteLine("10 değeri " + startIndex + ". indexte var");
                     startIndex += 1;
                 }

             Console.WriteLine("--------------------------------");
             for (int i = 0; i < puanlar.Length; i++)
             {
                 if (puanlar[i] == 10)
                     Console.WriteLine("10 değeri " + i + ". indexte var");
             }                                                                     */

            /*  // Arraydeki çift sayıların ve tek sayıların adedi.
              int[] sayilar = { 1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 4 };

              int ciftSayiAdet = sayilar.Count(c => c % 2 == 0);
              Console.WriteLine("cift Sayilarin adedi= " + ciftSayiAdet);

              int tekSayiAdet = sayilar.Count(c => c % 2 != 0);

              Console.WriteLine("tek sayiların adedi"+tekSayiAdet);                             */



            //   //copy to metodu
            //   int[] dizi1 = { 11, 41, 21, 32, 43, 54, 65, 66, 77, 86 };
            ////   int[] dizi2 = new int[dizi1.Length+5];

            //   //dizi1.CopyTo(dizi2, 0);  // dizi2 ye dizi1 in 0. elemanından baslayarak atama yap.

            //   dizi1.CopyTo(dizi2, 5);  // dizi 1 deki elemanları dizi 2 nin 5. indisin

            //   foreach (var item in dizi2)
            //   {
            //       Console.WriteLine(item);
            // }

            int[] dizi = new int[20];
            Random r = new Random();
            int sayi = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = r.Next(1, 21);  // 1 dahil 21 hariç.
            }
            for(int i=0; i<dizi.Length; i++) { 
            
                Console.WriteLine(i+". indisteki sayi="+ dizi[i]);
                sayi = dizi[i] % 5;
                for (int y = 0; y < sayi; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }



















































        }
    }
}
