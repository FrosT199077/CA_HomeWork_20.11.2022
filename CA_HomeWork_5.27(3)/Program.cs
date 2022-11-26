using System;

namespace CA_HomeWork_5_27_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -10;
            int b;
            int sum = 0;

            Console.Write("Чтобы узнать сумму чисел от -10 до Б --- ");
            Console.Write("Введите число Б:");
            b = int.Parse(Console.ReadLine());

            while (i <= b)
            {
                sum += i;
                i++;
            }

            Console.WriteLine($"Сумма чисел от -10 до Б == {sum}");
        }
    }
}
