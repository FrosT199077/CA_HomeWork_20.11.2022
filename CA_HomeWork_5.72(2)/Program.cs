using System;

namespace CA_HomeWork_5._72_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int firstDay = 9;
            int sum = 0;

            Console.WriteLine("Сколько километров пробежит лыжник за 20 дней ?");

            while(i<=20)
            {
                sum = i+firstDay;
                Console.WriteLine($" {i} дней {sum} км.");
                i++;
            }
            Console.WriteLine($" Лыжник за 20 дней пробежит {sum} км.");
        }
    }
}
