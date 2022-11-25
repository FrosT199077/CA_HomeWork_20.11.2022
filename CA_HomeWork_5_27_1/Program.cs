using System;

namespace CA_HomeWork_5_27_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumb = 100;
            int secondNumb = 500;
            int sum = 0;

            Console.WriteLine("Сумма чисел от 100 до 500:");

            while (firstNumb <= secondNumb)
            {
                sum += firstNumb;
                Console.WriteLine($"{firstNumb} Сумма = {sum}");
                firstNumb++;
            }
        }
    }
}
