using System;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("aracın kalacağı saati yazınız(0-12): ");

               int saat = Convert.ToInt32(Console.ReadLine());

               int ücret = 0;

               if (0 < saat && saat < 3)

               {
                   ücret += saat * 4;
               }

               else if (3 <= saat & saat < 7)
                   ücret = saat * 3;

               else if(7<=saat & saat < 12)
               {
                   ücret = saat * 2;
               }

               Console.WriteLine("ödeyeceğiniz ücret: " + ücret);    */

//Döngüler

/* int toplam = 0;

  for(int i=1; i<=3; i++)
  {
      toplam += i;
  }  */



/*  Console.WriteLine("sayi giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    int sonuc = 1;

    for(int i=1; i<=sayi; i++)
    {
        sonuc *= i;
    }
    Console.WriteLine("faktöriyel: " + sonuc);   */


/*
float s;
int si, f;
bool a = true;
for (; a;)
{
    Console.Write("Lütfen Faktöriyelinin alınmasını istediğiniz sayıyı giriniz: ");
    s = Convert.ToSingle(Console.ReadLine());
    si = (int)s;
    if (si != s || s < 1)
    {

        Console.WriteLine("Lütfen pozitif tam sayı giriniz:");
        a = true;
    }
    else
    {
        a = false;
        for (f = 1; si > 1; si--)
            f *= si; // f=f*si
        Console.Write("Faktöriyeli {0}", f);

    }

    */

/*  Console.WriteLine("baslangıc degeri giriniz: ");
    int baslangıc = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("bitis degeri giriniz: ");
    int bitis = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("değerler : ");

    for (int i=baslangıc; i<=bitis; i++)
    {

        Console.WriteLine(i);
    }                                         */


//char i;
//Console.WriteLine("Alfabe: ");

//for (i = 'a'; i <= 'z'; i++)
//    Console.WriteLine(i);


/*  Console.WriteLine("3 e ve 5 e bölünenler:");
  for(int i=1; i<=100; i++)
  {

      if(i%3==0 & i%5==0)
      {
          Console.WriteLine(i);

      }
  }                                 */

//int buyuk = 0, kucuk = 0, sayi;
//for (int i = 1; i <= 10; i++)
//{
//    Console.Write("{0}. sayıyı giriniz. ", i);
//    sayi = Convert.ToInt32(Console.ReadLine());
//    if (i == 1)
//    {
//        buyuk = sayi;
//        kucuk = sayi;
//    }
//    if (kucuk > sayi)
//    {
//        kucuk = sayi;
//    }
//    if (buyuk < sayi)
//    {
//        buyuk = sayi;
//    }
//}
//Console.WriteLine("En büyük sayı{0}", buyuk);
//Console.WriteLine("En küçük sayı{0}", kucuk);

/* float s;
   int si, f;
   bool a = true;
   for (; a;)
   {
       Console.Write("Lütfen Faktöriyelinin alınmasını istediğiniz sayıyı giriniz: ");
       s = Convert.ToSingle(Console.ReadLine());
       si = (int)s;
       if (si != s || s < 1)
       {

           Console.WriteLine("Lütfen pozitif tam sayı giriniz:");
           a = true;
       }
       else
       {
           a = false;
           for (f = 1; si > 1; si--)
               f *= si; // f=f*si
           Console.Write("Faktöriyeli {0}", f);

       }                             */

/*int toplam = 0;

 for(int i=1; i<=100; i++)
 {
     toplam +=i;
 }
 Console.WriteLine(toplam);    */

/*   Console.WriteLine("sayi1: ");
   int sayi1 = Convert.ToInt32(Console.ReadLine());

   Console.WriteLine("sayi2: ");
   int sayi2 = Convert.ToInt32(Console.ReadLine());

   int toplam = 0;

   int i;
   if(sayi2>sayi1)
   {
       for(i=sayi1; i<=sayi2; i++)
       {
           toplam += i;


       }

   }

   else if(sayi1>sayi2)
   {
       for(i=sayi2; i<=sayi1; i++)
       {
           toplam += i;
       }

   }
   else
   {
       Console.WriteLine("iki sayi esit olamaz.");
   }
   Console.WriteLine("toplam: " + toplam);                              */


/*    for (int i = 0; i <= 100; i++)
       if(i%2 != 0)
            Console.WriteLine(i);                             */

// While döngüsü

//int toplam = 0;
//int sayi = 0;
//Console.WriteLine("sayılar: ");

//for(int i=1; i<=1000; i++)
//{
//    if(i%5==0 & i%7!=0)
//    {
//        Console.WriteLine(i);
//    }


//}

/* 1'den 1000'e(sınırlar dâhil) kadar olan sayılar içerisinde 5'e tam bölünen, ancak 7'ye 
tam bölünemeyen sayıları alt alta listeleyen, bu sayıların kaç tane olduğunu ve toplamını yazan
bir program yazınız.
*/

/* int toplam = 0, sayi = 0;
for (int i = 5; i < 1001; i += 5)
{
    if (i % 35 == 0)
        continue;
    sayi++;
    toplam += i;
    Console.WriteLine(i);
}
Console.WriteLine("Sayısı: " + sayi);
Console.WriteLine("Toplam: " + toplam);                 */


/* string ad;
   Console.Write("isim bilgisini giriniz. ");

   ad = Console.ReadLine();

   int i = 0;

   while(i<100) {

       Console.WriteLine("{0}, {1}", (i + 1), ad);
       i++;
   }                                                  */

/*   string ad;
   Console.Write("isim bilgisi giriniz :");
   ad = Console.ReadLine();
   int i = 0;
   do
   {
       Console.WriteLine("{0}.{1}", (i + 1), ad);
       i++;
   } while (i < 100);            */


//Console.WriteLine("metin giriniz: ");

//string metin = Console.ReadLine();

//Console.WriteLine("sayi giriniz: ");

//int sayi = Convert.ToInt32(Console.ReadLine());

//int i = 1;

//do
//{
//    Console.WriteLine(i + ". " + metin);
//    i++;
//} while (i <= sayi);


/*  Console.WriteLine("metin giriniz: ");

  string metin = Console.ReadLine();

  Console.WriteLine("sayi giriniz: ");

  int sayi = Convert.ToInt32(Console.ReadLine());

  int i = 1;

  while(i<=sayi)
  { 
      Console.WriteLine(i + ". " + metin);
      i++;

  }                 */


/*       double toplam = 0, sayi = 0;
       int i = 0, adet = 0;
       for (i = 0; i < 6; i++)
       {
           Console.Write((i + 1) + ". sayıyı giriniz:");
           sayi = Convert.ToDouble(Console.ReadLine());
           if (sayi > 0)
           {
               toplam += sayi;
               adet++;
           }
       }
       double ortalama = toplam / adet;
       Console.WriteLine("Pozitif sayıların Ortalaması={0}", ortalama);   */

/*  double toplam = 0, sayi = 0;
    int i = 0, adet = 0;
    while (i < 6)
    {
        Console.Write((i + 1) + ". sayıyı giriniz:");
        sayi = Convert.ToDouble(Console.ReadLine());
        if (sayi > 0)
        {
            toplam += sayi;
            adet++;
        }
        i++;
    }
    double ortalama = toplam / adet;
    Console.WriteLine("Pozitif sayıların Ortalaması={0}", ortalama);   */

/* double toplam = 0;
   int i = 0, adet = 0;

   do
   {
       Console.Write((i + 1) + ". sayıyı giriniz:");
       double x = Convert.ToDouble(Console.ReadLine());
       if (x > 0)
       {
           toplam += x;
           adet++;
       }
       i++;
   } while (i < 6);
   Console.WriteLine("Pozitif sayıların Ortalaması={0}", (toplam / adet));    */

// While döngüsü

//int toplam = 0;
//int sayi = 0;
//Console.WriteLine("sayılar: ");

//for(int i=1; i<=1000; i++)
//{
//    if(i%5==0 & i%7!=0)
//    {
//        Console.WriteLine(i);
//    }


//}

/* 1'den 1000'e(sınırlar dâhil) kadar olan sayılar içerisinde 5'e tam bölünen, ancak 7'ye 
tam bölünemeyen sayıları alt alta listeleyen, bu sayıların kaç tane olduğunu ve toplamını yazan
bir program yazınız.
*/

/* int toplam = 0, sayi = 0;
for (int i = 5; i < 1001; i += 5)
{
    if (i % 35 == 0)
        continue;
    sayi++;
    toplam += i;
    Console.WriteLine(i);
}
Console.WriteLine("Sayısı: " + sayi);
Console.WriteLine("Toplam: " + toplam);                 */


/* string ad;
   Console.Write("isim bilgisini giriniz. ");

   ad = Console.ReadLine();

   int i = 0;

   while(i<100) {

       Console.WriteLine("{0}, {1}", (i + 1), ad);
       i++;
   }                                                  */

/*   string ad;
   Console.Write("isim bilgisi giriniz :");
   ad = Console.ReadLine();
   int i = 0;
   do
   {
       Console.WriteLine("{0}.{1}", (i + 1), ad);
       i++;
   } while (i < 100);            */


//Console.WriteLine("metin giriniz: ");

//string metin = Console.ReadLine();

//Console.WriteLine("sayi giriniz: ");

//int sayi = Convert.ToInt32(Console.ReadLine());

//int i = 1;

//do
//{
//    Console.WriteLine(i + ". " + metin);
//    i++;
//} while (i <= sayi);


/*  Console.WriteLine("metin giriniz: ");

  string metin = Console.ReadLine();

  Console.WriteLine("sayi giriniz: ");

  int sayi = Convert.ToInt32(Console.ReadLine());

  int i = 1;

  while(i<=sayi)
  { 
      Console.WriteLine(i + ". " + metin);
      i++;

  }                 */


/*       double toplam = 0, sayi = 0;
       int i = 0, adet = 0;
       for (i = 0; i < 6; i++)
       {
           Console.Write((i + 1) + ". sayıyı giriniz:");
           sayi = Convert.ToDouble(Console.ReadLine());
           if (sayi > 0)
           {
               toplam += sayi;
               adet++;
           }
       }
       double ortalama = toplam / adet;
       Console.WriteLine("Pozitif sayıların Ortalaması={0}", ortalama);   */

/*  double toplam = 0, sayi = 0;
    int i = 0, adet = 0;
    while (i < 6)
    {
        Console.Write((i + 1) + ". sayıyı giriniz:");
        sayi = Convert.ToDouble(Console.ReadLine());
        if (sayi > 0)
        {
            toplam += sayi;
            adet++;
        }
        i++;
    }
    double ortalama = toplam / adet;
    Console.WriteLine("Pozitif sayıların Ortalaması={0}", ortalama);   */

/* double toplam = 0;
   int i = 0, adet = 0;

   do
   {
       Console.Write((i + 1) + ". sayıyı giriniz:");
       double x = Convert.ToDouble(Console.ReadLine());
       if (x > 0)
       {
           toplam += x;
           adet++;
       }
       i++;
   } while (i < 6);
   Console.WriteLine("Pozitif sayıların Ortalaması={0}", (toplam / adet));   */
}
}
}
