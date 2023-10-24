using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";

            string[] students2 = { "Engin", "Derin", "Salih" };
            // array sınırlarına dikkat etmelisin.


            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }


            // Çok Boyutlu Diziler [satır, sütun]
            string[,] regions = new string[5, 3]
                {
                    {"İstanbul","İzmit","Balıkesir" },
                    {"Ankara","Konya","Kırıkkale" },
                    {"Antalya","Adana","Mersin" },
                    {"Rize","Trabzon","Samsun" },
                    {"İzmir","Muğla","Manisa" },
                };


            Console.ReadLine();

            // array ler ile aynı tipteki değişkenleri tek bir yerde kontrol edebiliriz.


        }
    }
}
