using System;

namespace CA_HomeWork_5_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int number;
            int sum;

            Console.Write("Введите число которое больше или равно 10:");
            number = int.Parse(Console.ReadLine());

            while (i <= number)
            {
                sum = (int)Math.Pow(i, 2);
                Console.WriteLine($"Число {i} в квадрате = {sum}");
                i++;
            }
        }
    }
}
