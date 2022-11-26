using System;

namespace CA_HomeWork_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int number;

            Console.Write("Введите число :");
            number = int.Parse(Console.ReadLine());

            while (i < 10)
            {
                Console.Write($"{number} ");
                i++;
            }
        }
    }
}
