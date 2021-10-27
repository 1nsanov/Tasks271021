using System;

namespace Task1
{
    class Point
    {
        private int PointX { get; set; }
        private int PointY { get; set; }
        private static int OneQuarterCount { get; set; } = 0;
        private static int TwoQuarterCount { get; set; } = 0;
        private static int ThreeQuarterCount { get; set; } = 0;
        private static int FourQuarterCount { get; set; } = 0;
        private static int PointCount { get; set; } = 0;

        public Point(int x, int y)
        {
            PointX = x;
            PointY = y;
            GetQuarter();
        }

        public static void OutputCountsPoints()
        {
            Console.WriteLine($"Кол-во точек 1-й координатной четверти: {OneQuarterCount}");
            Console.WriteLine($"Кол-во точек 2-й координатной четверти: {TwoQuarterCount}");
            Console.WriteLine($"Кол-во точек 3-й координатной четверти: {ThreeQuarterCount}");
            Console.WriteLine($"Кол-во точек 4-й координатной четверти: {FourQuarterCount}");
            Console.WriteLine($"Общее кол-во точек: {PointCount}");
        }

        private void GetQuarter()
        {
            if (PointX > 0 && PointY > 0)
            {
                OneQuarterCount++;
                PointCount++;

            }
            else if (PointX > 0 && PointY < 0)
            {
                TwoQuarterCount++;
                PointCount++;
            }
            else if (PointX < 0 && PointY < 0)
            {
                ThreeQuarterCount++;
                PointCount++;
            }
            else if (PointX < 0 && PointY > 0)
            {
                FourQuarterCount++;
                PointCount++;
            }
            else
            {
                PointCount++;
            }
        }

        public override string ToString()
        {
            return $"({PointX};{PointY})";
        }

    }
}
