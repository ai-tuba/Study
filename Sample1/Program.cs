using System;

namespace Sample
{
    class Point2D
    {
        public int x { get; set; }

        public int y { get; set; }

        public override string ToString()
        {
            return string.Format("({0}, {1})", x, y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p = new Point2D { x = 5, y = 6 };
            Console.WriteLine(p);
        }
    }
}