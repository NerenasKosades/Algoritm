using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }

        public class BechmarkClass
        {

            public static float PointDistance(PointStruct pointOne, PointStruct pointTwo)
            {
                float x = pointOne.X - pointTwo.X;
                float y = pointOne.Y - pointTwo.Y;
                return MathF.Sqrt((x * x) + (y * y));
            }

            public static float PointDistanceShort(PointStruct pointOne, PointStruct pointTwo)
            {
                float x = pointOne.X - pointTwo.X;
                float y = pointOne.Y - pointTwo.Y;
                return (x * x) + (y * y);
            }

            public static double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
            {
                double x = pointOne.X - pointTwo.X;
                double y = pointOne.Y - pointTwo.Y;
                return Math.Sqrt((x * x) + (y * y));
            }
                  



            [Benchmark]
            public void PointDistance()
            {
                PointDistance(11, 32);
            }

            [Benchmark]
            public void PointDistanceShort()
            {
                object x = 99;
                PointDistanceShort(26, 67);
            }

            [Benchmark]
            public void PointDistanceDouble()
            {
                object x = 99;
                PointDistanceDouble(26, 67);
            }
        }

    }
}
