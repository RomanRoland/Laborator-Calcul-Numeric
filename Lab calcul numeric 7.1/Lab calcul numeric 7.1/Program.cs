using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_calcul_numeric_7._1
{
    internal class Program
    {
        static void Main()
        {
            double eps = 1e-4;
            double x = 1.2;
            double y = 1.7;
            int k = 0;
            Console.WriteLine("Metoda lui Newton pentru sisteme neliniare\n");
            while (true)
            {
                double F = 2 * x * x * x - y * y - 1;
                double G = x * y * y * y - y - 4;
                double Fx = 6 * x * x;
                double Fy = -2 * y;
                double Gx = y * y * y;
                double Gy = 3 * x * y * y - 1;
                double det = Fx * Gy - Fy * Gx;
                double dx = (-F * Gy + Fy * G) / det;
                double dy = (-Fx * G + Gx * F) / det;
                x += dx;
                y += dy;
                k++;
                Console.WriteLine($"Iteratia {k}: x = {x:F6}, y = {y:F6}");
                if (Math.Max(Math.Abs(dx), Math.Abs(dy)) < eps)
                    break;
            }
            Console.WriteLine("\nSolutia aproximata:");
            Console.WriteLine($"x ≈ {x:F6}");
            Console.WriteLine($"y ≈ {y:F6}");
        }
    }
}
