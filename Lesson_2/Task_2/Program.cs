// Линейный и бинарный поиск
using System;
namespace поиск
{
    class Program
    {
        static int[] a = new int[1000];
        static int counter;  // счетчик числа сравнений
        static int n;   // число элементов
        static void Main(string[] args)
        {
            Console.Write("Ввести количество элементов: ");
            n = Convert.ToInt32(Console.ReadLine());
            // Упорядоченный по возрастанию массив       
            Console.WriteLine("\nПоиск в упорядоченном по возрастанию массиве");
            arr1Gen();
            comparison2();
            // Неупорядоченный массив
            Console.WriteLine("\nПоиск в неупорядоченном массиве");
            arr2Gen();
            comparison2();
            Console.ReadKey();
        }
        // Сравнение двух видов поиска
        static void comparison2()
        {
            // Предмет поиска      
            Console.Write("Ввести элемент поиска: ");
            int b = Convert.ToInt32(Console.ReadLine());
            // Линейный поиск
            int k = linePoisk(b);
            Console.WriteLine("Линейный поиск:");
            if (k > -1)
                Console.WriteLine("Номер элемента = {0}, число сравнений внутри цикла = {1}", k, counter);
            else
                Console.WriteLine("нет заданного элемента, число сравнений внутри цикла = {0}", counter);
            // Бинарный поиск        
            k = binPoisk(b);
            Console.WriteLine("Бинарный поиск:");
            if (k > -1)
                Console.WriteLine("Номер элемента = {0}, число сравнений внутри цикла = {1}", k, counter);
            else
                Console.WriteLine("нет заданного элемента, число сравнений внутри цикла = {0}", counter);
        }
        // Генератор упорядоченного по возрастанию массива
        static void arr1Gen()
        {
            Random ran = new Random();
            a[0] = ran.Next(1, 6);
            Console.Write("  {0}", a[0]);
            for (int i = 1; i < n; i++)
            {
                a[i] = a[i - 1] + ran.Next(1, 6);
                Console.Write("  {0}", a[i]);
            }
            Console.WriteLine();
        }
        // Генератор массива случайных чисел
        static void arr2Gen()
        {
            Random ran = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = ran.Next(1, 100);
                Console.Write("  {0}", a[i]);
            }
            Console.WriteLine();
        }
        // Линейный поиск     
        static int linePoisk(int b)
        {
            int k = -1;
            counter = 0;
            for (int i = 0; i < n; i++)
            {
                counter++;
                if (a[i] == b) { k = i; break; };
            }
            return k;
        }
        // Бинарный поиск
        static int binPoisk(int b)
        {
            int k;   // с
            int L = 0;        // левая граница
            int R = n - 1;    // правая граница
            k = (R + L) / 2;
            counter = 0;
            while (L < R - 1)
            {
                counter++;
                k = (R + L) / 2;
                if (a[k] == b)
                    return k; 
                counter++;
                if (a[k] < b)
                    L = k;
                else
                    R = k;
            }
            if (a[k] != b)
            {
                if (a[L] == b)
                    k = L;
                else
                {
                    if (a[R] == b)
                        k = R;
                    else
                        k = -1;
                };
            }
            return k;
        }
    }
}