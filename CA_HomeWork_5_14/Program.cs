using System;

namespace CA_HomeWork_5_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum;

            Console.WriteLine("Таблица умножения ;)");

            while (i <= 9)
            {
                sum = i * 9;
                Console.WriteLine($"9*{i}={sum}");
                i++;
            }
        }
    }
}
