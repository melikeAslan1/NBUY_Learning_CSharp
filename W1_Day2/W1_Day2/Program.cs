using System;

namespace W1_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   int a, b, c, d, sonuc1, sonuc2,sonuc3;

               a = 5;
               b = 10;
               c = 20;
               d = 30;

               sonuc1 = a * b / c+d;

               Console.WriteLine("Sonuc= "+ sonuc1.ToString());

               sonuc2 = a * b / (c + d);

               Console.WriteLine("Sonuc= " + sonuc2.ToString());                     */

            /*   byte minikSayı = 76;

                 minikSayı++;
                 ++minikSayı;
                 Console.WriteLine(minikSayı);

                 byte ikinciSayı = minikSayı++;            // önce bir artırıyor sonra atama işlemi yapıyor.
                 ikinciSayı = minikSayı++;               //önce atama sonra artırma yapar.    
                 Console.WriteLine(ikinciSayı);
                 Console.WriteLine(minikSayı);                */

            /*    int deger1 = 8;
                int deger2 = deger1++;
                Console.WriteLine("deger1: "+deger1);
                Console.WriteLine("deger2: "+deger2);                      */

            /* ??    int s1 = 90;
                int s2 = 99;


                if ((s1 > s2))
                    Console.WriteLine("s1 buyuk");

                else if (s2 > s1)
                    Console.WriteLine("s2 buyuk";

                else if (s1 == s2)
                    Console.WriteLine("s1 ve s2 esit");

                s1 = s2;                                               */

            //as is


            /*   object obj = "Veysel";
               string yazi = obj as string;
               //string yazi=obj as string;

               bool intMi = yazi is int;
               Console.WriteLine("intMi=" + intMi);

               bool stringMi = yazi is string;
               Console.WriteLine("stringMi: "+stringMi);   */

            //Mantıksal operatörler

            /*      int sayi = 77;
                  bool notGecerli=100 && sayi > 0;
                  Console.WriteLine("sayiKonttol=" + sayiKonttol);         */


            /*       //Bitsel operatörler

                   byte bSayi = 5;  //0101

                   byte isayi = 1;  //0001

                   int sonuc4 = bSayi & isayi;  // 0001 sonuc4=1

                   Console.WriteLine("sonuc4= "+ sonuc4);    */

            /*    uint a5 = 65;
                uint b5 = ~a5;

                // Console.WriteLine("b5= " + b5.ToString());
                Console.WriteLine(Convert.ToString(b5,toBase: 2));         */


            /*   //Bitsel sağa kaydırma >> 2 ye böler.
               byte bs = 6;   //0110 --->0011
               byte bs2 = (byte) ( bs >> 1) ;

               Console.WriteLine("bs2= " + bs2);                */


            //Tür Dönüşümleri

            ///////////////////////////////////
            /////Bilinçsiz Tür Dönüşümü///////
            /////////////////////////////////


            //Küçük tür büyük türe otomatik olarak dönüştürülür.

            /*   byte byteSayi = 58;
               int intSayi = byteSayi;

               //int ii = 2;
               //byte bb = ii;

               float fSayi = 29.45f;
               double dSayi = fSayi;                    */

            /////////////////////////////////////////////
            ///// Kasıtlı Tür Dönüşümü (Casting ) ///////
            /////////////////////////////////////////////

            /*   checked
               {
               int intSayi6 = 309;

               byte byteSayi6 = (byte) intSayi6;

               Console.WriteLine("byteSayi6= "+byteSayi6);
               }                                                       */

            /////////////////////////////////////////////
            ///// Convert Sınıfı ile Tür Dönüşümü ///////
            /////////////////////////////////////////////


            /*   double ddd = 678.455D;

               string str = Convert.ToString(ddd);

               Console.WriteLine("str: "+str);

               string postaKodu = "34734";

               int postaKoduInt = Convert.ToInt32(postaKodu);

               Console.WriteLine("postaKodu Int: "+postaKodu);      */

            /*     // as is
                 object obj = '5';

                 Console.WriteLine(obj.GetType());
                 char yazi = obj ;
                 //string yazi = obj as string; //

                 Console.WriteLine(yazi.GetType());    */

            /*    // as is 
                object obj = "Veysel";
                string yazi = obj as string;
                //string yazi = obj as string; //

                bool intMi = yazi is int;
                Console.WriteLine("intMi=" + intMi.ToString());

                bool stringMi = yazi is string;
                Console.WriteLine("stringMi=" + stringMi.ToString());            */

            /*   char y = '6';
               object kutu = y;

               object p = 'P';
               // y =  p as char; //hata verir    */


            /*   char karakter1 = 'A';
               int sayi8 = Convert.ToInt32(karakter1);
               Console.WriteLine("sayi8= " + sayi8);   */


            /*   uint a5 = 65;
               Console.WriteLine(Convert.ToString(a5, toBase: 2));
               uint b5 = ~a5;
               Console.WriteLine(Convert.ToString(b5, toBase: 2));     */

            /*  int a = 5;

              int sonuc = (int)Math.Pow(Convert.ToDouble(a),2.0);   */



            //ALIŞTIRMALAR

            /* bakkkkkk   Console.WriteLine("bir sayi giriniz: ");
               int sayi = Convert.ToInt32(Console.ReadLine());
               bool sayiBestenBuyuk = (sayi > 5);

               if (sayiBestenBuyuk)
                   Console.WriteLine("sayı 5ten buyuktur");
               else
                   Console.WriteLine("sayı 5ten kucuk yada esittir. "+Math.Pow(sayi,2));   */

            /*   Console.WriteLine("sayı1: ");
                 int sayi1 = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("sayı2: ");
                 int sayi2 = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("sayı3: ");
                 int sayi3 = Convert.ToInt32(Console.ReadLine());

                 int toplam = 0;

                 if (sayi1 < 100)
                     toplam += sayi1;
                 if (sayi2 < 100)
                     toplam += sayi2;
                 if (sayi3 < 100)
                     toplam += sayi3;

                 Console.WriteLine("toplam: " + toplam);                          */


            /*    Console.WriteLine("not giriniz: ");
                double not = Convert.ToDouble(Console.ReadLine());

                if(50>not & not>0)
                    Console.WriteLine("Harf Notunuz: " + "F");

              else  if(not>=50 & not<= 64)
                    Console.WriteLine("Harf Notunuz: " + "D");

                else if (not >= 65 & not <= 74)
                    Console.WriteLine("Harf Notunuz: " + "C");

                else if (not>=75 & not <= 84)
                    Console.WriteLine("Harf Notunuz: " + "B");

                else if (not>=85 & not <= 100)
                    Console.WriteLine("Harf Notunuz: " + "A");

                else  
                  Console.WriteLine("not hatalı girildi. 0 ve 100 arasında olmalıdır.");                */

            Console.WriteLine("sayi giriniz: ");

            int sayi = Convert.ToInt32(Console.ReadLine());

            if(sayi%2==0)
                Console.WriteLine("sayi çift");

            else if(sayi % 3 == 0)
                    Console.WriteLine("3 ün "+(sayi/3)+ "katı");
            else
                    Console.WriteLine("sayinin 3 e bölümünden kalan: "+(sayi%3));






 





















        }
    }
}
