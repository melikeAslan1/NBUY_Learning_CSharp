using System;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  Type a = typeof(int);

                Console.Write(a);  */

            //  akış kontrol mekanizmaları

            /*    int a = 5, b = 7;

                if (a < b)
                {
                    Console.Write("a b'den küçük");
                    Console.Write(a);
                }

                else
                {
                    Console.Write("a b'den büyük");
                    Console.Write(b);
                }   */

            /*    Console.Write("Cinsiyetinizi giriniz(e,k): ");
                  char cins = Convert.ToChar(Console.ReadLine());

                  if (cins == 'e')
                      Console.Write("erkeksiniz");
                  else if (cins == 'k')
                      Console.Write("kızsınız");
                  else
                      Console.Write("lütfen cinsiyetinizi doğru giriniz.");       */

            //Console.Write("birinci notunuzu giriniz: ");
            //   double not1 = Convert.ToDouble(Console.ReadLine());

            //   Console.Write("ikinci notunuzu giriniz: ");
            //   double not2 = Convert.ToDouble(Console.Read());

            //   double ortalama = (not1 + not2) / 2;

            //   if(ortalama>50)
            //   {
            //       Console.Write("geçtiniz");
            //   }
            //   else
            //   {
            //       Console.WriteLine("kaldınız");
            //   }


            /* String kullaniciAdi;
               String sifre;

               Console.Write("kullanici adini giriniz");
               kullaniciAdi = Console.ReadLine();

               Console.Write("sifre giriniz");
               sifre = Console.ReadLine();

               if (kullaniciAdi == "melike" & sifre == "66")
               {
                   Console.Write("Giriş Başarılı");

               }

               else
               { 
                   Console.WriteLine("girdiğiniz kullanıcı adı veya sifre hatalı");
               }    */


            /*    Console.Write("ürün fiyatı giriniz: ");

                int fiyat =Convert.ToInt32(Console.ReadLine());

                if(fiyat>=100)

                    Console.WriteLine("ödenmesi gereken tutar {0} TL'dir", fiyat);


                else

                    fiyat=fiyat + 5;


                    Console.WriteLine("ödenmesi gereken tutar {0} TL'dir", fiyat);  */


            /*   Console.Write("sayi giriniz: ");
               int sayi = Convert.ToInt32(Console.ReadLine());

               if (sayi > 0)
                   Console.WriteLine("sayi pozitiftir.");

               else if (sayi < 0)
                   Console.WriteLine("sayi negatiftir");
               else
               {
                   Console.WriteLine("sayi 0 a eşittir.");
               }
            */


            /*    Console.Write("birinci Sayıyı giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İkinci Sayıyı giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İşlem türünü belirleyiniz (toplama,cıkarma,carpma,bölme)");
                String tür = Console.ReadLine();

                double sonuc=0;


                if (tür == "toplama")
                    sonuc = sayi1 + sayi2;

                else if (tür == "cıkarma")

                    sonuc = sayi1 - sayi2;

                else if (tür == "carpma")
                    sonuc = sayi1 * sayi2;

                else if (tür == "bölme")
                    sonuc = sayi1 / sayi2;
                else
                    Console.WriteLine("yanlış işlem seçtiniz");



                Console.WriteLine(sonuc);   */


            /*   Console.Write("birinci ürün fiyatı giriniz: ");
               double fiyat1 = Convert.ToDouble(Console.ReadLine());

               Console.Write("ikinci ürün fiyatı giriniz: ");
               double fiyat2 = Convert.ToDouble(Console.ReadLine());

               double toplam = fiyat1 + fiyat2;
               double OdenecekTutar = toplam;

               if(toplam>200)
               {
                   if(fiyat1>fiyat2)
                   {
                      fiyat2 = fiyat2 - fiyat2 * 0.25;
                       OdenecekTutar = fiyat2 + fiyat1;
                   }

                   else
                   {
                       fiyat1 = fiyat1 - fiyat1 * 0.25;
                       OdenecekTutar = fiyat2 + fiyat1;
                   }

               }

               Console.WriteLine("Ödenecek tutar: " + OdenecekTutar);   */

            //switch case yapısı

            //bilgisayarlarımızın tarih bilgisini alarak hangi günde olduğumuzu bulan program

            /*  int gun = (int) DateTime.Now.DayOfWeek;

               Console.Write("Bugün günlerden: ");

               switch (gun)
               {

                   case 1:
                       Console.Write("Pazartesi");
                       break;

                   case 2:
                       Console.Write("Salı");
                       break;

                   case 3:
                       Console.Write("Çarşamba");
                       break;

                   case 4:
                       Console.Write("Perşembe");
                       break;

                   case 5:
                       Console.Write("Cuma");
                       break;

                   case 6:
                       Console.Write("Cumartesi");
                       break;

                   case 7:
                       Console.Write("Pazar");
                       break;

                   default:
                      Console.Write("Gun bilgisi yanlış");
                        break;

            */


            //kullanıcıya kacıncı ayda olduğunu sorarak, hangi mevsimde bulunduğunu gösteren program.


            /* Console.Write("Kacıncı ayda olduğunuzu giriniz: ");

            int ay = Convert.ToInt32(Console.ReadLine());

            switch (ay)
            {
                case 12: 
                case 1:
                case 2:
                    Console.Write("Kış Mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.Write("İlkbahar Mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("yaz Mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.Write("Sonbahar Mevsimi");
                    break;

                default:
                    Console.Write("ay bilgisi yanlış");
                    break;

            }
            */

            /*  Console.WriteLine("Mevsim: ");
                String mevsim = Console.ReadLine();

                switch(mevsim)
                {

                    case "ilkbahar":
                        Console.WriteLine("mart, nisan, mayıs");
                        break;

                    case "sonbahar":
                        Console.WriteLine("eylül, ekim, kasım");
                        break;

                    case "kış":
                        Console.WriteLine("aralık, ocak, şubat");
                        break;

                    case "yaz":
                        Console.WriteLine("haziran, temmuz, ağustos");
                        break;

                    default:
                        Console.WriteLine("olmayan mevsim");
                        break;
                }    */


            /* Console.WriteLine("trafik lambası rengi: ");

              string renk = Console.ReadLine();

              switch(renk)
              {
                  case "sarı":
                      Console.WriteLine("Hazırlan");
                      break;

                  case "yeşil":
                      Console.WriteLine("Geç");
                      break;

                  case "kırmızı":
                      Console.WriteLine("Bekle");
                      break;

                  default:
                      Console.WriteLine("yanlış renk girdiniz");
                      break;    
              }

                                                      */

            /*   Console.WriteLine("Birinci sayiyi giriniz");
                 double sayi1 = Convert.ToDouble(Console.ReadLine());

                 Console.WriteLine("İkinci sayiyi giriniz");
                 double sayi2 = Convert.ToDouble(Console.ReadLine());

                 double sonuc = 0;

                 Console.WriteLine("işlemi giriniz(+,-,*,/)");

                 char islem = Convert.ToChar(Console.ReadLine());


                 switch(islem)
                 {
                     case '+':
                         sonuc = sayi1 + sayi2;
                         break;

                     case '-':
                         sonuc = sayi1 - sayi2;
                         break;

                     case '*':
                         sonuc = sayi1 * sayi2;
                         break;

                     case '/':
                         if(sayi2==0)
                         {
                             Console.WriteLine("ikici sayi 0 olamaz");
                             sayi2 = Convert.ToDouble(Console.ReadLine());
                             sonuc = sayi1 / sayi2;

                         }
                         else
                         {
                           sonuc = sayi1 / sayi2;
                         }

                         break;

                     default:
                         Console.WriteLine("olmayan işlemi girdiniz");
                         break;


                 }

                 Console.WriteLine("sonuc:" + sonuc);              */

        /*    Console.WriteLine("harf giriniz: ");

            char harf = Convert.ToChar(Console.ReadLine());

            switch(harf)
            {
                case 'a':
                case 'e':
                case 'ı':
                case 'i':
                case 'o':
                case 'ö':
                case 'u':
                case 'ü':

                    Console.WriteLine("girdiğiniz harf seslidir");
                    break;

                default:
                    Console.WriteLine("girdiğiniz harf sessizdir.");
                    break;


            }   */









           


           
            














        }














        }
            





















        }
    

