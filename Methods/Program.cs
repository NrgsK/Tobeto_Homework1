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
            //Add();
            //Add();
            //Add();

            //var result = Add2(20);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(number1,number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1); // number1=20
            // metoda yalnızca değişkendeki değeri gönderiyoruz.

            //Console.WriteLine(result);
            Console.ReadLine();
        }

        // metotlar kod tekrarının önüne geçmemize yardımcı olur
        // Don't repeat yourself prensibi
        static void Add() 
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2=30)
            //(parametre)
        {
            var result=number1+ number2;
            return result;

            // return number1 + number2;

            // burada bir işlem yapıldığı için void kullanmamız doğru değil
            // metodun dönüş tipine göre metot tipini belirliyoruz.

            // default parametre eğer parametre değeri verilmezse belirlediğimiz default değer kullanılır.

            // default değerler her zaman metotdun en sonundaki parametrede olması gerekir.(birden fazla default değer verilebilir.)

        }

        // Challenge

        static int Add3(int number1,int number2)
        {
            number1 = 30;
            return number1+ number2;
        }



    }
}
