using System;

namespace CA_HomeWork_5._75_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int step = 2;
            int sum = 0;
            int num = 4;

            while (step <= 10)
            {
                sum += num;
                num*=2;
                step++;
            }
            Console.WriteLine($"Сумма возведения числа 2 от 1 до 10 степени == {sum}");
        }
    }
}
