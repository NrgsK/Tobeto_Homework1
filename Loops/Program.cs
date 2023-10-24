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

            for (int i = 100; i >= 0; i-=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");



            Console.ReadLine();
        }
    }
}
