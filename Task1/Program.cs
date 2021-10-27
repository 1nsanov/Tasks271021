using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        private static Random rnd = new Random();
        private static List<Point> ListPoints = new List<Point>();
        static void Main(string[] args)
        {
            GeneratePoints(10);
            OutputPoints(ListPoints);

            Console.ReadLine();
        }


        private static void GeneratePoints(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var x = rnd.Next(-10, 10);
                var y = rnd.Next(-10, 10);
                ListPoints.Add(new Point(x, y));
            }
        }

        private static void OutputPoints(List<Point> list)
        {
            foreach (var point in list)
            {
                Console.WriteLine($"Точка {point}");
            }
            Console.WriteLine();
            Point.OutputCountsPoints();
        }
    }
}
