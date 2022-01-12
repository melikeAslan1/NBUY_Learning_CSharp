using System;

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

            Console.WriteLine(faktöriyel());
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
    }
}
