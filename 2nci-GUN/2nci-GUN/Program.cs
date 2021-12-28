using System;

namespace _2nci_GUN
{
    class Program
    {
        static void Main(string[] args)
        {
            //tür dönüşümleri

            /*

            byte a = 5;

            short b = 10;

            sbyte c = 30;
            int d = a + b + c;

            string e = "deneme;";

            char f = 'k';

            object g = e + f + d;

            long h = d;

            float i = h;

            double j = i;

            double k = 12.5f;

            Console.WriteLine(j + k);

            Console.WriteLine(g);   */


            /* char a = 'h';

            int b = a;

            Console.WriteLine(b);  */

            /*  byte a = 5, b = 10;

              short d = 2, e = 9;

               int  f = a + b; //byte f idi.

              int g = d + e; // short g idi.

              Console.WriteLine(f + g);     */

            /* int a = 5;
             byte b = (byte)a;
             Console.WriteLine(b);   */

            /*  byte b = (byte)12.5f;
              Console.WriteLine(b); */



            /*  //büyükten küçüğe tür dönüşümü;

              int a = 256;   // int a=5; idi.   bir değişken kaybolmuş oldu.

              byte b = (byte)a;     //int b=a; idi.

              Console.WriteLine(b);  */


            //  int i=256;

            //  byte b;

            //checked{

            //  b=(byte)i;
            //}

            //  Console.WriteLine(b);


            /*  int i = 255;

              int a=300;

              byte b, c;

              checked  //varsa hata program durur calışmaz.
              {

                  b = (byte)i;
                  unchecked
                  {

                      c = (byte)a;
                  }
              }

              Console.WriteLine(b);
              Console.WriteLine(c);  */

            /*     object a = '5';

                 string b = "4";   //int b=4; idi.

                 Console.WriteLine(a + b);  */


            /* object a = 'c';

             char b = (char)a;

             int c = (int)b;  // byte c=(byte)b;  de olabilir.

             Console.WriteLine(c);  */

            /*

            //x.ToString()

            string b = 3.ToString();

            Console.WriteLine(b);   */

            /* int a = 6;
             string b = a.ToString();
             Console.WriteLine(b);   */

            /*  string b = 12.5f.ToString();

              Console.WriteLine(b);  */

            /* string b = 'k'.ToString();

             Console.WriteLine(b);   */

            /*  string b = 5 + "deneme" +'k' + 12.5f;

              Console.WriteLine(b);  */

            /*     int a = 5;

                 char b = 'k';

                 string r = "deneme";

                 float f = 12.5f;

                 string c = a + b + r + f; //string c=a+r+b+f;

                 Console.WriteLine(c);   */

            /* //convert - büyükten küçüğe yada küçükten büyüğe

             string s1, s2;

             int sayi1, sayi2;
             int toplam;

             Console.Write("birinci sayıyı giriniz: ");

             s1 = Console.ReadLine();

             Console.Write("ikinci sayıyı giriniz:");

             s2 = Console.ReadLine();

             sayi1 = Convert.ToInt32(s1);

             sayi2 = Convert.ToInt32(s2);

             toplam = sayi1 + sayi2;

             Console.Write("TOPLAM= " + toplam);  */



            // operatörler


            /* int i = 3 * 5 / 7;

             Console.Write(i);  */

            /* double i = 3d * (5 / 7);
             Console.Write(i);   */

            /*   int i = 5 % 2;
               Console.Write(i);  */

            /*  float i = 5 / 2f;

              Console.Write(i);   */

            /*  float i = 2 / 5 / 2f;  //float i=2/2f/5;


              Console.Write(i);   */


            // bir artırma ve bir eksiltme operatörleri

            /*  int a = 5;
              int i = ++a;
              Console.Write(i + " " + a);  */

            /*  int a = 5;
              int i = ++a;
              Console.Write(i + " " + a);  */


            /*   int a = 5;
               int i = a++; //i=5; a=6;
               int b = i--; b = 5; i = 4;
               int c = 10;
               int d = --c; //d=9;

               Console.Write("{0}\n{1}\n{2}\n{3}", a, i, b, d);  */


            //karşılaştırma operatörleri
            //==esittir. != esit değildir.

            /*   bool a = 4 < 6;
               bool b = 6 > 5;
               bool c = 7 <= 7;
               bool d = 9 >= 12;
               bool e = 10 == 12;
               bool f = 1 != 8;
               Console.Write($"{a}\n{b}\n{c}\n{d}\n{e}\n{f}\n"); */

            /* object i = "50";

             string s = i as string;

             Console.Write(s);  */

            /* int i = 50;

            bool b1 = i is int;

            bool b2 = i is double;

            bool b3 = 12 is byte;

            bool b4 = 'c' is string;

            bool b5 = 12f + 7 is int;

            Console.Write($"{b1}\n,{b2}\n,{b3}\n{b4}\n{b5}\n");  */

            //mantıksal operatörler
            // && ve     || veya    ! değil

            /*  bool b1 = 35 > 10 && 10 == 50;

              bool b2 = 35 > 10 && 10 != 50;

              bool b3 = 5 is int || 12 * 3 == 200;

              bool b4= 5<4 || 45 / 5 == 9;

              bool b5 = !(5 > 4);

              Console.Write(b1 + " " + b2 + " " + b3 + " " + b4 + " " + b5);  */



            //bitsel operatörler

            /* byte a = 5 & 3; //00000101 & 00000011  -->     00000001

             Console.Write(a);

             byte b = 5 | 3;    // 00000101 | 00000011  -->  00000111  */



            /*  byte d = 5;
              byte e = (byte)~d;   // 00000101  --> 11111010 -->250 */

            /*    byte b = 100;  //01100100
                byte c = (byte)(b << 1);  //11001000 -> 200

                byte d = 50;  //00110010

                byte e = (byte)(d >> 2);  //00001100 ->12

                Console.Write(c + " " + e);   */


            /*  byte b = 7, a = 1, c;

              c = a = b;  //atama operatörü sağdan sola gider. sağdan sola şekilde bakk.

              Console.Write(a + " " + b + " " + c);  */


            /*  int a, b;

              a = 5;

              b = 6;

              a = a + b;   //a+=b;

              Console.WriteLine(a); */


            //  koşul ? operatörü  
            // koşul? doğruysa_değer: yanlışsa_değer

            /*  Console.Write("Yazılımı seviyor musunuz? (e,h): ");

              string durum = Console.ReadLine();

              Console.Write(durum == "e" ? "Teşekkürler!!" : "Sağlık olsun..");   */




            //SORU

            /*  Console.Write("vize notunuzu giriniz.");
                double vize = Convert.ToDouble(Console.ReadLine());

                Console.Write("final notunuzu giriniz.");
                double final = Convert.ToDouble(Console.ReadLine());

                double genel = (vize * 0.4) + (final * 0.6);

                Console.Write("genel notunuz: " + genel);     */


            /*    Console.Write("Fahrenayt değerini giriniz.");
                double fahrenayt = Convert.ToDouble(Console.ReadLine());

                double celsius = (fahrenayt - 32) / 1.8;
                celsius = Math.Round(celsius, 2);  
               Console.Write(fahrenayt + " Fahrenayt =>" + celsius + " derecedir.");
             */

            /*    Console.Write("birinci sayi giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("ikinci sayi giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("birinci sayi giriniz: ");
                double sayi3 = Convert.ToDouble(Console.ReadLine());

                double toplam = sayi1 + sayi2 + sayi3;

                Console.WriteLine("TOPLAM: " + toplam);  */


            /*   Console.Write("taban uzunluğu giriniz: ");
               double taban = Convert.ToDouble(Console.ReadLine());

               Console.Write("yükseklik uzunluğu giriniz: ");
               double yükseklik = Convert.ToDouble(Console.ReadLine());

               double alan = (taban * yükseklik) / 2;

               Console.Write("ALAN: " + alan);   */

            /*   bool b1 = 7 > 99 && 2*5 == 10;
               Console.WriteLine(b1);   */

           /* Console.Write("değer giriniz: ");

            int deger = Console.Read();

            Console.Write(deger%2 == 0 ? "Sayi çift" : "Sayi tek");    */































































































































































































        }
    }
}
