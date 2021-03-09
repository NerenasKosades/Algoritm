using System;

namespace Task_3_with_recursion_
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
            if (number == 0)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                return Fibonachi(number - 1) + Fibonachi(number - 2);
            }
        }
    }
}
