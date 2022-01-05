using System;

namespace W1_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    int say = 0;

            Sayalim:

                Console.WriteLine("sıradaki sayi: " + say);
                say++;
                if (say <= 1000)
                    goto Sayalim;

                Console.WriteLine("Buraya Geldik");                  */


            /*     Console.WriteLine("sayi giriniz: ");
                 int sayi = Convert.ToInt32(Console.ReadLine());

                 int say = 1;
                 int faktöriyel = 1;

             faktöriyel:

                 faktöriyel *= say;

                 say++;

                 if (say <= sayi)
                     goto faktöriyel;

            Console.WriteLine("sayının faktöriyeli: "+ faktöriyel);           */

            //Formül (Math.Pow) kullanmadan:
            //Klavyeden taban ve üs bilgis alın.



            //yapamadım bu soruyu.
            /*     Console.WriteLine("Taban: ");
                 int taban = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("üs: ");
                 int ust = Convert.ToInt32(Console.ReadLine());

                 int usSakla = ust;
                 int sonuc = 1;

             kuvvetHesapla:

                 sonuc *= taban;

                 ust--;

                 if (ust > 0)
                     goto kuvvetHesapla;

                 Console.WriteLine(taban+ "sayısının"+ usSakla+ "kuvveti"+sonuc);                   */


            /*  //go to ile 0 100 arasında 3 sayının ortalamasını bulan program.
              //program eksik copy paste yap.

              double toplam = 0;
              int sayac = 1;

              LabelSayiIste:             */


            ///////////////////
            ///Switch case////
            //////////////////


            /*    //eksik kaLDI KOD tamamla
                Console.WriteLine("sayi1: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("sayi2: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("işlem giriniz (toplama, cikarma, carpma, bölme, cikis) ");
                String islem = Console.ReadLine();

                double sonuc = 0;

                switch(islem)
                {

                    case "toplama":
                        sonuc = sayi1 + sayi2;
                        break;

                    case "cikarma":
                            sonuc = sayi1 - sayi2;
                        break;

                    case "carpma":
                        sonuc = sayi1 * sayi2;
                        break;

                    case "bölme":
                        if (sayi2 != 0)
                        {
                            Console.WriteLine("Bölüm=" + (sayi1/sayi2));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Bölen 0 olamaz");
                            break;
                        }

                    case "cıkıs":
                        break;



                    case "default":
                        Console.WriteLine("Hatalı işlem !");
                        break;


                }                                                          */

            /*    double prim = 6000d;
                  double yilSayisi = 0d;

                  while(prim<7200)
                  {
                      yilSayisi = (7200 - prim) / 360;
                      Console.WriteLine("Emekliliğe daha" + Math.Round(yilSayisi,2) + "yıl var" );
                      Console.ReadLine();
                      prim += 360;

                  }

                  Console.WriteLine("Tebrikler Emekli Oldunuz.");                */


            /*     byte sayi = 1;

                 while(sayi<=10)
                 {
                     Console.WriteLine(sayi);
                     sayi++;
                 }                                     */

            /* Console.WriteLine("sayi giriniz: ");
               int sayi = Convert.ToInt32(Console.ReadLine());
               int i = 1;

               while (i <= sayi)
               {
                   Console.WriteLine(i);
                   i++;

               }                                                                   */

            //debug yapmak için: satırı işaretle F9 bas.
            //F10 ile ilerlet.
            //F5 debug tan cık.
            //F9 debug ı kaldır.


            //bak bu soruya.
            /*    Console.WriteLine("Mesajınızı giriniz (Çıkmak için ÇIK yazınız. )");

                string yazi = Console.ReadLine();

                while(yazi.ToUpper()!="çık")
                {
                    Console.WriteLine(yazi);
                    Console.WriteLine("Mesajınızı yazınız(Çıkmak için ÇIK yazınız. ) ");
                    yazi = Console.ReadLine();

                }

                Console.WriteLine("Program sonlandı!");                                                            */

            // ctrl + k+d        formating yapma düzenleme.


            Console.WriteLine("sayi giriniz");
            string str = Console.ReadLine();
            int toplam = 0;

            while (str != "bitir")
            {
                int sayi = Convert.ToInt32(str);
                toplam += sayi;
                Console.WriteLine("sayi giriniz");
                str = Console.ReadLine();

            }

            Console.WriteLine("program bitti. TOPLAM: " + toplam);





        }

    }
}