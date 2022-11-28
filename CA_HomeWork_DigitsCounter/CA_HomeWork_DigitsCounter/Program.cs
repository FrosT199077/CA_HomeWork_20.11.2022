using System;

namespace CA_HomeWork_DigitsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int num = 0;
            int count5 = 0;
            int count7 = 0;

            while (i < 10)
            {
                Console.WriteLine("Введите числа в рандомном порядке , проверим чего больше 5 или 7 :");
                num = int.Parse(Console.ReadLine());
                if (num == 7)
                {
                    count7++;
                }
                if (num == 5)
                {
                    count5++;
                }
                i++;
            }

            if (count5 < count7)
            {
                Console.WriteLine("Чисел 7 больше ! ");
            }
            else if (count5 > count7)
            {
                Console.WriteLine("Чисел 5 больше ! ");
            }
            else if (count5 == count7)
            {
                Console.WriteLine("Чисел 5 и 7 равное количество !");
            }
        }
    }
}
