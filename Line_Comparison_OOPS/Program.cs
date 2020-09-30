using System;

namespace Line_Comparison_OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Program! ");
            double[] x = new double[2];
            double[] y = new double[2];
            Random random = new Random();
            for (int index = 0; index < 2; index++)
            {
                x[index] = random.Next(-100, 100);
                y[index] = random.Next(-100, 100);
            }
            Console.WriteLine("Coordinates of two end points of the line : ({0}, {1}) & ({2}, {3})", x[0], y[0], x[1], y[1]);
            double length = Math.Sqrt(Math.Pow((x[1] - x[0]), 2) + Math.Pow((y[1] - y[0]), 2));
            Console.WriteLine("Length of the line: " + Math.Round(length, 2));
        }
    }
}
