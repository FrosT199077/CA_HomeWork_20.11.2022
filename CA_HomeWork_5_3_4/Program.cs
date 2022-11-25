using System;

namespace CA_HomeWork_5_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Введите число А:");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите число Б:");
            b = int.Parse(Console.ReadLine());

            while (a <= b)
            {
                Console.WriteLine($"{a}");
                a++;
            }
        }
    }
}
