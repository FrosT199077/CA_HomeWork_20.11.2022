using System;

namespace CA_HomeWork_5._72_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysStart = 0;
            int daysFinish = 20;
            double startDist= 10;
            double finishDist = startDist;
            double percent = 10;

            Console.WriteLine("Сколько суммарно лыжник пробежит за 20 дней ?");

            while(daysStart<daysFinish)
            {
                startDist += startDist*percent/100.0;   
                finishDist += startDist;
                daysStart++;
            }
            Console.WriteLine($"Лыжник за {daysStart} дней пробежит {finishDist} км.");
        }
    }
}
