using System;

namespace CA_HomeWork_5._72_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int firstDay = 9;
            int sum = 0;

            Console.WriteLine("За сколько дней пробег лыжника превысит 20 км ? ");

            while(i<=12)
            {
               
                sum = firstDay + i;
                Console.WriteLine($"Лыжник пробежит за {i} дней == {sum} км.");  
                i++;
            }
            Console.WriteLine("Лыжник превысит 20 км - на 12 день .");
        }
    }
}
