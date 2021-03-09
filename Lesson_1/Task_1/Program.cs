using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число ");
            int n = Convert.ToInt32(Console.ReadLine());

            int d = 0;
            int i = 0;

            while (i < n)
            {
                while (n % i == 0)
                {
                    d++;
                }
                i++;
            }

            if (d == 0)
                Console.WriteLine("Простое");
            else
                Console.WriteLine("Не простое");
        }
    }
}
