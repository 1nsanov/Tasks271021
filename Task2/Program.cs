using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        private static Random rnd = new Random();
        private static List<RectParallelepiped> ListRect = new List<RectParallelepiped>();
        static void Main(string[] args)
        {
            GenerateRects(5);
            OutputRects(ListRect);

            Console.ReadLine();
        }


        private static void GenerateRects(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var a = rnd.Next(2, 8);
                var b = rnd.Next(2, 8);
                var h = rnd.Next(2, 8);
                ListRect.Add(new RectParallelepiped(a, b, h));
            }
        }

        private static void OutputRects(List<RectParallelepiped> list)
        {
            foreach (var rect in list)
            {
                Console.WriteLine(rect);
            }
            Console.WriteLine();
            RectParallelepiped.OutputCountsShapes();
        }
    }
}
