using System;

namespace Task2
{
    class RectParallelepiped
    {
        private int EdgeA { get; set; }
        private int EdgeB { get; set; }
        private int Height { get; set; }
        private static int CubsCount { get; set; } = 0;
        private static int ParallelepipedCount { get; set; } = 0;

        private int Square { get; set; }
        private int Volume { get; set; }

        public RectParallelepiped(int edgeA, int edgeB, int height)
        {
            EdgeA = edgeA;
            EdgeB = edgeB;
            Height = height;
            Square = GetSquare();
            Volume = GetVolume();
            CountingNumbersShapes();
        }

        public static void OutputCountsShapes()
        {
            Console.WriteLine($"Кол-во кубов: {CubsCount}");
            Console.WriteLine($"Кол-во параллелепипедов: {ParallelepipedCount}");
        }

        private int GetSquare()
        {
            return 2 * (EdgeA * Height) + 2 * (EdgeA * EdgeB) + 2 * (EdgeB * Height);
        }
        private int GetVolume()
        {
            return EdgeA * EdgeB * Height;
        }

        private void CountingNumbersShapes()
        {
            if (EdgeA == EdgeB && EdgeA == Height)
            {
                CubsCount++;
            }
            else
            {
                ParallelepipedCount++;
            }
        }


        public override string ToString()
        {
            return $"Высота: |{Height}| Сторона №1: |{EdgeA}| Сторона №2: |{EdgeB}|\nПлощадь = {Square} | Объем = {Volume}";
        }
    }

}
