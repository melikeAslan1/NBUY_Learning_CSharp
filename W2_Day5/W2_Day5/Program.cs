using System;
using System.Collections.Generic;

namespace W2_Day5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Topla("1","2","3","4"));
            //Console.WriteLine(Topla("Korkma","sönmez","bu"));
            //Console.ReadLine();

            ////referans tipi parametreler
            //int s1;
            //int s2;
            //DegerDegistir(ref s1, ref s2);

            //Console.WriteLine("s1= "+ s1);
            //Console.WriteLine("s2=" + s2);

            //Console.ReadLine();


            /*   int mutlak7 = Math.Abs(-7);
               Console.WriteLine(mutlak7);

               double cos45 = Math.Cos(45);

               Console.WriteLine(cos45);

               Console.WriteLine(Math.Sin(45));

               Console.WriteLine(Math.Tan(45));

               Console.WriteLine(Math.Max(4,5));

               Console.WriteLine(Math.Min(4,5));

               Console.WriteLine(Math.Pow(2,8));

               Console.WriteLine(Math.Sqrt(36));

               Console.WriteLine(Math.Log(100));

               Console.WriteLine(Math.Exp(4));

               Console.WriteLine(Math.Log10(5));

               Console.WriteLine(Math.Log(16,2));

               Console.ReadLine();                           */


            //string birlesim = String.Concat("Network", "Akademi", "303Sabah", 2022);

            //Console.WriteLine(birlesim);

            //Console.ReadLine();


            //string[] dizi = { "Korkma", "sönmez", "bu", "Safaklarda" };

            //birlesim = string.Concat(dizi);

            //Console.WriteLine(birlesim);


            //int[] intDizi = { 1, 2, 3, 4, 5 };

            //birlesim = String.Concat(intDizi);

            //Console.WriteLine(birlesim);

            //Console.ReadLine();


            //string s1 = "Adana";
            //string s2 = "Adana";

            //int comp = String.Compare(s1, s2);

            //Console.WriteLine("comp= " + comp);

            //if (comp == 1)
            //    Console.WriteLine(s1);

            //else
            //    Console.WriteLine(s2);
            //Console.ReadLine();

            //for (int i = 0; i < 10; i++)
            //{

            //Console.Write("String 1: ");
            //string st1 = Console.ReadLine();

            //Console.Write("String 2: ");
            //string st2 = Console.ReadLine();


            //int a = string.Compare(st1, 0,st2,0,100,true);

            //if (a == -1)
            //    Console.WriteLine("önce gelen" + st1);

            //else if (comp == 0)
            //    Console.WriteLine("Aynı sırada: " + st2.ToUpper());
            //else
            //    Console.WriteLine("önce gelen" + st2);
            //Console.ReadLine();
            //}


            //string metin = "BEŞİKTAŞ";
            //Console.WriteLine(metin.IndexOf("Ş"));
            //Console.WriteLine(metin.LastIndexOf("Ş"));
            //Console.WriteLine(metin.StartsWith("BEŞ"));
            //Console.WriteLine(metin.StartsWith("Beş"));
            //Console.WriteLine(metin.EndsWith("TAŞ"));

            //metin = "       ____FENERBAHÇE____   ";
            //Console.WriteLine(metin.Trim('_', ' ', 'E');

            //metin = "Merhaba Dünya";
            //Console.WriteLine(metin.PadLeft(20,'.'));
            //Console.WriteLine(metin.PadRight(20,'.'));

            /*   string youtubeStr = "https://www.youtube.com/watch?v=4WYBWi0-D3o";
               string[] adres = youtubeStr.Split('/');

               Console.WriteLine("adres[0]= "+ adres[0]);
               Console.WriteLine("adres[1]= " + adres[1]);
               Console.WriteLine("adres[2]= " + adres[2]);

               string cumle = "Merhaba arkadaşlar bugün hava çok güzel";

               string[] kelimeler = cumle.Split(' ');

               foreach (var kelime in kelimeler)
               {
                   Console.WriteLine(kelime);
               }

               string yeniCumle = string.Join("/", kelimeler);

               yeniCumle = yeniCumle.ToUpper();
               Console.WriteLine(yeniCumle);

               yeniCumle = yeniCumle.ToLower();
               Console.WriteLine(yeniCumle);           

               yeniCumle = yeniCumle.Remove(3, 1);
               Console.WriteLine(yeniCumle);


               Console.WriteLine(yeniCumle.Insert(6,"123"));
               Console.WriteLine(yeniCumle.Replace("arkadaşlar","gençler"));                   */


            reverse("tugba");




           



            



        } //MAIN SONU

        
        private static void reverse(string metin)
        {
            int length = metin.Length;
            string yeniMetin = "";

            for (int i = length-1; i >= 0; i--)
            {
                yeniMetin += metin[i];
            }

            Console.WriteLine(yeniMetin);


        }
        private static int KelimeSay(string yeniCumle)
        {
            string[] dizi = yeniCumle.Split(' ');

            return dizi.Length;

        }










           
        

        private static void DegerDegistir(ref int s1, ref int s2)
        {
            s1 = s1 * 10;

        }

        static string Topla(params string[] sayilar)
        {
            string cumle = "";
            foreach (string kelime in sayilar)
            {
                cumle += kelime + " ";
            }

            return cumle;
        }

        //private static string PuanTopla(string isim, int yas, params string puanlar)
        //{
        //    int toplamPuan = "";
        //    foreach (int puan in puanlar)
        //    {
        //        toplamPuan += puan;   
        //    }
        //    return isim + " " + yas + " " + toplamPuan;
        //}

        static int faktoriyel (int sayi)
        {
            if (sayi <= 1)
                return 1;
            else
            {
                Console.WriteLine("Şu anda" + sayi + "Faktoriyel(" + (sayi-1)+") cağırılıyor ");
                return sayi * faktoriyel(sayi - 1);
            }
        }

       

          
        }

    }
