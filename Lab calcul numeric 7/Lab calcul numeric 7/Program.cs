using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_calcul_numeric_7
{
    internal class Program
    {
        static void Main()
        {
            double eps = 1e-4;
            double x = 1.2;
            double y = 1.7;
            int iter = 0;
            while (true)
            {
                double f1 = 2 * x * x * x - y * y - 1;
                double f2 = x * y * y * y - y - 4;
                double j11 = 6 * x * x;
                double j12 = -2 * y;
                double j21 = y * y * y;
                double j22 = 3 * x * y * y - 1;
                double det = j11 * j22 - j12 * j21;
                double dx = (-f1 * j22 + f2 * j12) / det;
                double dy = (-j11 * f2 + j21 * f1) / det;
                x += dx;
                y += dy;
                iter++;
                Console.WriteLine($"Iter {iter}: x={x:F6}, y={y:F6}");
                if (Math.Max(Math.Abs(dx), Math.Abs(dy)) < eps)
                    break;
            }
            Console.WriteLine("\nSolutia finala:");
            Console.WriteLine($"x = {x:F6}");
            Console.WriteLine($"y = {y:F6}");
        }
    }
}
