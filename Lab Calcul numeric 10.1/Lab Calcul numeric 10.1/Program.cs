using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Calcul_numeric_10._1
{
    internal class Program
    {
        static double f(double x)
        {
            return x * x;
        }

        static double Bernstein3(double x)
        {
            int m = 3;
            double result = 0.0;

            for (int k = 0; k <= m; k++)
            {
                double binomial = Binomial(m, k);
                double p = binomial * Math.Pow(x, k) * Math.Pow(1 - x, m - k);
                result += p * f((double)k / m);
            }

            return result;
        }

        static double Binomial(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        static double Factorial(int n)
        {
            double f = 1;
            for (int i = 2; i <= n; i++)
                f *= i;
            return f;
        }
        static void Main(string[] args)
        {
             double x = 0.5;
             Console.WriteLine($"B3({x}) = {Bernstein3(x)}");
             Console.WriteLine($"f({x})  = {f(x)}");
             Console.ReadKey();
        }
    }
}
