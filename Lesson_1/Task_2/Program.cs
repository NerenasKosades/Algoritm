using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
                    /*
                     * Алгоритм содержит три цикла, два из которых вложенные + условное ветвление
                     * Каждый цикл выполняет O(N) шагов, но вложенные циклы выполняются
                     * O(N) раз каждого цикла верхнего порядка.
                     * Соответственно асимптотическая сложность данного алгоритма составит O(N + N * N * N), 
                     * убирая константу и вычисляя степень получаем O(N^3)
                     */
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        int y = 0;

                        if (j != 0)
                        {
                            y = k / j;
                        }

                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }

            return sum;
        }
    }
}
