using System;

namespace Diziler_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort 
            Console.WriteLine("***array sort***");

            int[] sayiDizisi = {23,12,4,86,72,3,11,17};
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            // sort = sıra ile dizme
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //Clear
                Console.WriteLine("***array clear**");
                // sayı dizisi elemanlarını kullanarak 2. indeksten itibaren 2 tane elemanı sıfırlar
                Array.Clear(sayiDizisi,2,2);
                foreach (var sayi in sayiDizisi)
                {
                    Console.WriteLine(sayi);
                }
                //Reverse = sıralamayı ters çevirir
                Console.WriteLine("***array reverse**");
                Array.Reverse(sayiDizisi);
                foreach (var sayi in sayiDizisi)
                {
                    Console.WriteLine(sayi);
                }

                //indexOf = istediğimiz değerin kaçıncı sırada olduğunu gösterir 
                    
                    Console.WriteLine("***array indexOf**");
                    Console.WriteLine(Array.IndexOf(sayiDizisi,23));
                    
                    // Resize 
                    Console.WriteLine("***array Resize**");
                    Array.Resize<int>(ref sayiDizisi,9);
                    sayiDizisi[8] = 99;
                    foreach (var sayi in sayiDizisi)
                {
                    Console.WriteLine(sayi);
                }
        }
    }
}
