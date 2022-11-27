using System;

namespace CA_HomeWork_5._72_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int startDays = 0;
            int finishDays = 10;
            double firstDist = 10;
            double lastDist = firstDist;
            double percent = 10;

            Console.WriteLine("Таблица пробега лыжника за 10 дней !");

            while (startDays < finishDays)
            {
                firstDist += firstDist * percent / 100.0;
                lastDist += firstDist;
                startDays++;
                Console.WriteLine($"День: {startDays} == Км.: {firstDist}");
            }
            Console.WriteLine($"Сумма пробега за : {startDays} дней == {lastDist} Км.");
        }
    }
}
