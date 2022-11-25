using System;

namespace CA_HomeWork_5_27_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int sum = 0;

            Console.WriteLine("Узнайте сумму введёных чисел где А < Б !");
            Console.Write("Введите число А:");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите число Б:");
            b = int.Parse(Console.ReadLine());

            while (a <= b)
            {
                sum += a;
                a++;
            }

            Console.WriteLine($"Сумма ваших введёных чисел = {sum}");
        }
    }
}
