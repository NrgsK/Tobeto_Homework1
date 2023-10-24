using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string metinsel verileri tutmak için kullanılan değişken tipidir.

            //string city = "Ankara";

            // stringler aslında char dizisidir.
            // Console.WriteLine(city[0]);

            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);

            //}

            //string city2 = "İstanbul";
            //string result = city + city2;

            //Console.WriteLine(String.Format("{0} {1}",city,city2));

            string sentence = "My name is Nergis Ketenci";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            // Yeni bir referans oluşturduk.
            sentence = "My name is Rukiye Ketenci";

            bool result3 = sentence.EndsWith("g");
            bool result4 = sentence.StartsWith("g");

            var result5 = sentence.IndexOf("name");
            // IndexOf bir string değişkende belli bir karakteri yada ifadeyi aramak için kullanılır. Aranan karakter bulunamazsa "-1" değeri döner.



            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.ReadLine();
        }
    }
}
