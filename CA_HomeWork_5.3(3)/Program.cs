using System;

namespace CA_HomeWork_5_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum;

            Console.Write("Введите число не больше 50 для возведения в третью степень: ");
            i = int.Parse(Console.ReadLine());

            while (i <= 50)
            {
                sum = (int)Math.Pow(i, 3);
                Console.WriteLine($"Число {i} в третьей степени = {sum}");
                i++;
            }

        }
    }
}
