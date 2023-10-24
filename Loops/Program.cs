using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Döngüler veri kümesinin içerisinde dolaşmak için kullandığımız yapılardır.
            // for(başlangıç değeri,şart,artış)

            //for (int i = 100; i >= 0; i-=2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Finished!");


            // While Döngüsü: Belli bir şart sağlanana kadar döngü çalışır.
            int number = 100;
            while (number>=0)
            {
                Console.WriteLine(number);
                number--;
                // Sonsuz döngü olmaması için döngünün içerisinde şarta müdahale etmek gerekir.
            }

            Console.ReadLine();
        }
    }
}
