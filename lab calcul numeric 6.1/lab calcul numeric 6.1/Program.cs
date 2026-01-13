using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_calcul_numeric_6._1
{
    internal class Program
    {
        static double Phi1(double x, double y, double z)
        {
            double val = 0.5 * (y * z + 5.0 * x - 1.0);
            return Math.Sqrt(val);
        }

        static double Phi2(double x, double y, double z)
        {
            double val = 2.0 * x + Math.Log(z);
            return Math.Sqrt(val);
        }

        static double Phi3(double x, double y, double z)
        {
            double val = x * y + 2.0 * z + 8.0;
            return Math.Sqrt(val);
        }

        static void Main()
        {
            double x = 10.0, y = 10.0, z = 10.0;
            double eps = 0.001;
            int maxIter = 1000;
            int k = 0;

            Console.WriteLine("Iteratii metoda Gauss–Seidel (Slide 7):");
            Console.WriteLine("k\t x\t\t y\t\t z");

            while (k < maxIter)
            {
                double xNext = Phi1(x, y, z);
                double yNext = Phi2(xNext, y, z);
                double zNext = Phi3(xNext, yNext, z);

                Console.WriteLine($"{k + 1}\t {xNext:F6}\t {yNext:F6}\t {zNext:F6}");

                if (Math.Abs(xNext - x) < eps &&
                    Math.Abs(yNext - y) < eps &&
                    Math.Abs(zNext - z) < eps)
                    break;

                x = xNext;
                y = yNext;
                z = zNext;
                k++;
            }

            Console.WriteLine($"\nSolutia aproximativa:");
            Console.WriteLine($"x = {x:F6}, y = {y:F6}, z = {z:F6}");
            Console.WriteLine($"Numar de iteratii: {k}");
        }
    }
}
