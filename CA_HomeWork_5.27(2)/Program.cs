using System;

namespace CA_HomeWork_5_27_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumb;
            int secondNumb = 500;
            int sum = 0;

            Console.Write("Чтобы узнать сумму чисел от А до 500 --- ");
            Console.Write("Введите число А:");
            firstNumb = int.Parse(Console.ReadLine());

            while(firstNumb<=secondNumb)
            {
                sum += firstNumb;
                firstNumb++;
            }
            Console.WriteLine($"Сумма ваших чисел = {sum}");
        }
    }
}
