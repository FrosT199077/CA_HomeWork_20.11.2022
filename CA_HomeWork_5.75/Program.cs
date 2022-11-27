using System;

namespace CA_HomeWork_5._75
{
    class Program
    {
        static void Main(string[] args)
        {
            int step= 2;
            int sum = 0;

            while(step<=10)
            {
                sum += (int)Math.Pow(2, step);
                step++; 
            }
            Console.WriteLine($"Сумма возведения числа 2 от 1 до 10 степени == {sum}");
        }
    }
}
