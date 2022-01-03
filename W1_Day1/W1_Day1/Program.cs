using System;

namespace W1_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -45;
            a = 75;
            Console.WriteLine(a);


            // cw + 2 kere tab

            int sayi = int.MinValue;
            Console.WriteLine($"int min: {sayi}");

            decimal decimalSayiMax = decimal.MaxValue;
            Console.WriteLine("decimal tipinin alabileceği en büyük değer: "+ decimalSayiMax);


            char ab = 'b';
            Console.WriteLine(ab.GetType());

            var k = 33;
            Console.WriteLine(k.GetType());

            Int32 i32 = 99;
            Int16 i16 = 88;

            Console.WriteLine("i32 tipi: "+ i32.GetType());
            Console.WriteLine("i16 tipi: " + i16.GetType());

            Int32 int32maxValue = Int32.MaxValue;
            Int16 int16maxValue = Int16.MaxValue;

            Console.WriteLine("int32 tipinin alabileceği en büyük değer: "+int32maxValue);
            Console.WriteLine("int16 tipinin alabileceği en büyük değer: " + int16maxValue);











        }
    }
}
