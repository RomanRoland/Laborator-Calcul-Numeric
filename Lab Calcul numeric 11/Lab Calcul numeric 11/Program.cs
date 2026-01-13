using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Calcul_numeric_11
{
    internal class Program
    {
        static void Main()
        {
            double[] x = { 1, 3, 4, 6, 8, 9 };
            double[] y = { 1, 2, 4, 4, 5, 3 };
            int n = x.Length;
            double sumX = 0, sumY = 0, sumX2 = 0, sumXY = 0;
            for (int i = 0; i < n; i++)
            {
                sumX += x[i];
                sumY += y[i];
                sumX2 += x[i] * x[i];
                sumXY += x[i] * y[i];
            }
            double a = (n * sumXY - sumX * sumY) /
                       (n * sumX2 - sumX * sumX);
            double b = (sumY - a * sumX) / n;
            Console.WriteLine("Dreapta de regresie:");
            Console.WriteLine($"y = {a:F3}x + {b:F3}");
            Console.ReadKey();
        }
    }
}
