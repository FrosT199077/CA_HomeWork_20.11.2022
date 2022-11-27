using System;

namespace CA_HomeWork_5._72_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 0;
            double start = 10;
            double finish = 20;
            double percent = 10;

            Console.WriteLine("За сколько дней пробег лыжника превысит 20 км  ?");

            while (start < finish)
            {
                start += start * percent / 100.0;
                days++;
            }
            Console.WriteLine($"Лыжник за {days} дней пробежит {start} км.");
        }
    }
}
