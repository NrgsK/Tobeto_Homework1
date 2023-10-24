using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();

            var result = Add2(20,30);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        // metotlar kod tekrarının önüne geçmemize yardımcı olur
        // Don't repeat yourself prensibi
        static void Add() 
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
            //(parametre)
        {
            var result=number1+ number2;
            return result;

           // return number1 + number2;

            // burada bir işlem yapıldığı için void kullanmamız doğru değil
            // metodun dönüş tipine göre metot tipini belirliyoruz.
           
        }

    }
}
