using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_calcul_numeric_10
{
    internal class Program
    {
        static double f(double x)
        {
            return Math.Exp(x);
        }
        static double df(double x)
        {
            return Math.Exp(x);
        }
        static double Hermite(double x)
        {
            double a = 0;
            double b = 1;
            double fa = f(a);  
            double fb = f(b);  
            double dfa = df(a);
            double dfb = df(b);
            double h1 = (1 - x) * (1 - x) * (1 + 2 * x);
            double h2 = x * x * (3 - 2 * x);
            double h3 = x * (1 - x) * (1 - x);
            double h4 = x * x * (x - 1);
            return fa * h1 + fb * h2 + dfa * h3 + dfb * h4;
        }
        static void Main()
        {
                double x = 0.25;
                double approx = Hermite(x);
                double exact = f(x);
                double error = Math.Abs(exact - approx);
                Console.WriteLine("Interpolare Hermite pentru f(x) = e^x");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"P(x) ≈ {approx:F6}");
                Console.WriteLine($"e^x  = {exact:F6}");
                Console.WriteLine($"Eroare = {error:E}");
                Console.ReadKey();
        }
    }
}
