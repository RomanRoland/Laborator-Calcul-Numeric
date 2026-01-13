using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_calcul_numeric_6
{
    internal class Program
    {
        static double Phi1(double x, double y)
        {
            //Ex 1
            /*
            return Math.Sqrt((x * (y + 5) - 1) / 2.0);
            */
            //Ex 2
            return Math.Sqrt(5.0 - y * y);
            //return (1 + y * y) / 10.0;
        }

        static double Phi2(double x, double y)
        {
            //Ex 1
            /*
            return Math.Sqrt(x + 3.0 * Math.Log10(x));
            */
            //Ex 2
            return 2.0 / x;
            //return Math.Sqrt(10 - x);
        }

        static void Main()
        {
            // Ex 1
            /*
            double x = 1.0, y = 2.0;
            double eps = 1e-5;
            int maxIter = 100;
            int k = 0;
            */
            // Ex 2
            double x = 2.0, y = 1.0;
            double eps = 1e-4;
            int maxIter = 100;
            int k = 0;

            Console.WriteLine("Iteratii metoda aproximatiilor succesive:");
            Console.WriteLine("k\t x\t\t y");

            while (k < maxIter)
            {
                double xNext = Phi1(x, y);
                double yNext = Phi2(x, y);

                Console.WriteLine($"{k + 1}\t {xNext:F6}\t {yNext:F6}");

                if (Math.Abs(xNext - x) < eps && Math.Abs(yNext - y) < eps)
                    break;

                x = xNext;
                y = yNext;
                k++;
            }

            Console.WriteLine($"\nSolutia aproximativa: x = {x:F6}, y = {y:F6}");
            Console.WriteLine($"Numar de iteratii: {k}");
        }
    }
}
