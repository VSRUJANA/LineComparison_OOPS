using System;
namespace Line_Comparison_OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.Write("The coordinates of end points of Line 1 are ");
            double lengthOfLine1 = LengthOfLine();
            Console.WriteLine("Length of line 1: " + lengthOfLine1);
            Console.Write("The coordinates of end points of Line 2 are ");
            double lengthOfLine2 = LengthOfLine();
            Console.WriteLine("Length of line 2: " + lengthOfLine2);
            double result = lengthOfLine1.CompareTo(lengthOfLine2);
            if (result > 0)
                Console.WriteLine("line 1 is greater than line 2");
            else if (result < 0)
                Console.WriteLine("line 1 is smaller than line 2");
            else
                Console.WriteLine("Both the lines are equal");
        }
        static double LengthOfLine()
        {
            double[] x = new double[2];
            double[] y = new double[2];
            Random random = new Random();

            for (int index = 0; index < 2; index++)
            {
                x[index] = random.Next(-100, 100);
                y[index] = random.Next(-100, 100);
            }
            Console.WriteLine(" ({0}, {1}) & ({2}, {3})", x[0], y[0], x[1], y[1]);
            double length = Math.Sqrt(Math.Pow((x[1] - x[0]), 2) + Math.Pow((y[1] - y[0]), 2));
            return Math.Round(length, 2);
        }
    }
}
