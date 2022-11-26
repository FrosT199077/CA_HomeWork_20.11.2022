using System;

namespace CA_HomeWork_5._72_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int b = 9;
            int sum = 0;

            Console.WriteLine("Таблица пробега лыжника за 10 дней !");

            while (i <= 10)
            {
                sum = i + b;
                Console.WriteLine($"День: {i} == Км.: {sum}");
                i++;
            }
        }
    }
}
