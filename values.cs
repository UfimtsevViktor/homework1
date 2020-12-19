using System;

namespace Homework1
{
    class values
    {
        static void Main(string[] args)
        {
            // Задание 1

            int value1 = 3;
            int value2 = 4;
            int value3 = 0;
            value3 = value1;
            value1 = value2;
            value2 = value3;
            value3 = 0;

            Console.WriteLine($"value2 = {value2}, value1 = {value1}");

            // Задание 2

            /* 
            int a = 4;
            int b = 6;
            a = a * 3;
            b = b + 12;
           
            Console.WriteLine($"a={a}, b={b}"); 
            */

            // Задание 3

            int Milkprice = 73;
            int Matchprice = 19;

            int amountofMilk = 2;
            int amountofMatch = 10;

            Console.WriteLine($"Total sum: {(Milkprice*amountofMilk)+(Matchprice*amountofMatch)}");

            // Задание 4

            /* 
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            string c = Console.ReadLine();
            int d = Convert.ToInt32(c);

            Console.WriteLine($" {b + d},{b - d},{b * d}");
            Console.ReadKey();
            */

            //Задание 5

            float q = 17f;
            float w = 29f;
            float div = q / w;
            Console.WriteLine($"{div}");
        }
    }
}
