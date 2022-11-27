using System;

namespace CA_HomeWork_5._75_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int step = 1;
            int num = 2;
            int sum = 0;

            while(step<10)
            {
                num*= 2;
                sum += num;
                step++;     
            }
            Console.WriteLine($"Сумма возведения числа 2 от 1 до 10 степени == {sum}");
        }
    }
}
