using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_calcul_numeric_7._2
{
    internal class Program
    {
        static double eps = 1e-4;

        static void Newton(double x0, double y0, double xExact, double yExact)
        {
            double x = x0;
            double y = y0;
            int k = 0;
            Console.WriteLine($"\nPornire din (x0, y0) = ({x0}, {y0})");
            while (true)
            {
                double F = x * x + y * y - 10;
                double G = Math.Sqrt(x + y) - 2;
                double Fx = 2 * x;
                double Fy = 2 * y;
                double Gx = 1.0 / (2 * Math.Sqrt(x + y));
                double Gy = Gx;
                double det = Fx * Gy - Fy * Gx;
                double dx = (-F * Gy + Fy * G) / det;
                double dy = (-Fx * G + Gx * F) / det;
                x += dx;
                y += dy;
                k++;
                Console.WriteLine($"Iter {k}: x={x:F6}, y={y:F6}");
                if (Math.Max(Math.Abs(dx), Math.Abs(dy)) < eps)
                    break;
            }
            Console.WriteLine("Solutie aproximata:");
            Console.WriteLine($"x ≈ {x:F6}, y ≈ {y:F6}");
            Console.WriteLine("Solutie exacta:");
            Console.WriteLine($"x = {xExact}, y = {yExact}");
            Console.WriteLine("Eroare:");
            Console.WriteLine($"|x - x_exact| = {Math.Abs(x - xExact):E}");
            Console.WriteLine($"|y - y_exact| = {Math.Abs(y - yExact):E}");
        }
        static void Main()
        {
            Console.WriteLine("Metoda lui Newton pentru sisteme neliniare");
            Console.WriteLine("ε = 10^-4");
            Newton(0.9, 3.1, 1, 3);
            Newton(2.9, 1.1, 3, 1);
        }
    }
}
