using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_calcul_numeric_7._3
{
    internal class Program
    {
        static double eps = 1e-4;
        static void NewtonClassic(double x0, double y0)
        {
            double x = x0, y = y0;
            int k = 0;
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
                if (Math.Max(Math.Abs(dx), Math.Abs(dy)) < eps)
                    break;
            }
            Console.WriteLine("Metoda Newton clasica:");
            Console.WriteLine($"Solutie: x={x:F6}, y={y:F6}");
            Console.WriteLine($"Iteratii: {k}\n");
        }
        static void NewtonModified(double x0, double y0)
        {
            double x = x0, y = y0;
            int k = 0;
            double Fx0 = 2 * x0;
            double Fy0 = 2 * y0;
            double Gx0 = 1.0 / (2 * Math.Sqrt(x0 + y0));
            double Gy0 = Gx0;
            double det0 = Fx0 * Gy0 - Fy0 * Gx0;
            while (true)
            {
                double F = x * x + y * y - 10;
                double G = Math.Sqrt(x + y) - 2;
                double dx = (-F * Gy0 + Fy0 * G) / det0;
                double dy = (-Fx0 * G + Gx0 * F) / det0;
                x += dx;
                y += dy;
                k++;
                if (Math.Max(Math.Abs(dx), Math.Abs(dy)) < eps)
                    break;
            }
            Console.WriteLine("Metoda Newton modificata:");
            Console.WriteLine($"Solutie: x={x:F6}, y={y:F6}");
            Console.WriteLine($"Iteratii: {k}\n");
        }
        static void Main(string[] args)
        {
            double x0 = 0.9;
            double y0 = 3.1;
            Console.WriteLine("Comparatie Newton vs Newton modificat");
            Console.WriteLine("ε = 10^-4\n");
            NewtonClassic(x0, y0);
            NewtonModified(x0, y0);
            Console.WriteLine("Solutia exacta: (1, 3)");
        }
    }
}
