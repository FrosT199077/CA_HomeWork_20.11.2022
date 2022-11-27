using System;

namespace CA_HomeWork_5._72_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            double firstDay = 10;  
            double percent = 10;

            Console.WriteLine("Таблица пробега лыжника за 10 дней !");

            while (i <= 10)
            {
                firstDay += firstDay * percent / 100.0;
                Console.WriteLine($"День: {i} == Км.: {firstDay}");
                i++;
            }
        }
    }
}
