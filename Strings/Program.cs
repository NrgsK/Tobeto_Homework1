﻿using System;
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

            string city = "Ankara";

            // stringler aslında char dizisidir.
            // Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);

            }

            string city2 = "İstanbul";
            //string result = city + city2;

            Console.WriteLine(String.Format("{0} {1}",city,city2));


            Console.ReadLine();
        }
    }
}