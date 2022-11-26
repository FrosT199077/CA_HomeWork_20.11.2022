using System;

namespace CA_HomeWork_5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int kurs;
            int sum;

            Console.Write("Введите курс доллара:");
            kurs = int.Parse(Console.ReadLine());

            while (i <= 20)
            {

                sum = i * kurs;
                Console.WriteLine($"Количество долларов {i} по курсу {kurs} = {sum}");
                i++;
            }
        }
    }
}
