using System;

namespace W1_Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   //carpım tablosu yapınız.

                for(int i=1; i<=9; i++)
                {

                    Console.WriteLine(i+"' ler: ");

                    for(int y=0; y<=9; y++)
                    {
                        Console.WriteLine(i +"*"+ y  + "=" + (i*y));

                        // tab aynı sütunda toplar.

                    }
                    Console.WriteLine();
                }                                                                          */


            /*  int toplam, sayi = 0;
              Console.WriteLine("sayi, giriniz: ");
              string str = Console.ReadLine();
              bool dogru = int.TryParse(str, out sayi);

              Console.WriteLine(dogru);                              */


            /*    int sayi1, sayi2;
                  string str;

                  Console.WriteLine("sayi1 giriniz: ");
                  str = Console.ReadLine();
                  bool a=int.TryParse(str, out sayi1);

                  if (a == false)
                  {
                      Console.WriteLine("nümerik bir değer giriniz");
                  }

                  Console.WriteLine("sayi2 giriniz: ");
                  str = Console.ReadLine();
                  int.TryParse(str, out sayi2);

                  int kucuk = sayi1;
                  int buyuk = sayi2;

                  if (sayi1 > sayi2)
                  {
                  kucuk = sayi2;
                  buyuk = sayi1;
                  }
                  Console.WriteLine("sonuc: " );  

                  for(int i=kucuk; i<=buyuk; i++)
                      Console.WriteLine(i);                                                      */


            /*   double fiyat, toplam=0, kdvLiFiyat;
               string str;
               for(int i=1; i<=5; i++)
               {

                   Console.WriteLine(i+". ürünün fiyatını giriniz: ");

                   str = Console.ReadLine();
                   Double.TryParse(str, out fiyat);
                   kdvLiFiyat =Math.Round(( fiyat * 1.18),2);
                   Console.WriteLine("kdv li fiyat: "+ kdvLiFiyat);

                   toplam += kdvLiFiyat;

               }
               Console.WriteLine("toplam fiyat: "+toplam);               */


            /*  int araToplam;
              int toplam=0;
              for(int i=1; i<=10; i++)
              {
                  araToplam = 1;

                  for(int y=1; y<=i; y++)
                  {
                      araToplam *= y;

                  }
                  toplam += araToplam;
                  Console.WriteLine(i + "faktöriyeli: "+ araToplam);
              }
              Console.WriteLine("toplam: "+toplam);                */



            string yildiz = "**********************************************************************";
            string a = "";
            for(int i=1; i<=10; i++)
            {
                a=yildiz.Substring(0,i);
                Console.WriteLine(a);
            }














        }
    }
}
