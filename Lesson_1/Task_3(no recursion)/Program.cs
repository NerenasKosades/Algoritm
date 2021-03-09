using System;

namespace Task_3_no_recursion_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonachi(num));

        }

        static int Fibonachi(int number)
        {
            int x = 0;
            int y = 1;
            int pr;

            for (int i = 0; i < number; i++)
            {
                pr = x;
                x = y;
                y += pr;
            }

            return x;
        }
    }
}
