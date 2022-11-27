using System;

namespace CA_HomeWork_5._72_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int days = 20;
            double start= 10;
            double percent = 10;

            Console.WriteLine("Сколько суммарно лыжник пробежит за 20 дней ?");

            while(sum<days)
            {
                sum = start*percent/100.0;             
                start++;
            }
            Console.WriteLine($"Лыжник за {days} дней пробежит {start} км.");
        }
    }
}
