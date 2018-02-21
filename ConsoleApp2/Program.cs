using System;

namespace ConsoleApp2
{
    struct Point2d
    {
        public int X;
        public int Y;

        public Point2d(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point2d operator +(Point2d point1, Point2d point2)
        {
            return new Point2d(point1.X + point2.X, point1.Y + point2.Y);
        }

        public override string ToString()
        {
            return $"({this.X}, {this.Y})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            object cos = new Object();
            var point1 = new Point2d(1, 3);
            var point2 = new Point2d(2, 4);

            var sum = point1 + point2;

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
