using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculnumericlab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = 2, dda = 6;
            double eps;
            double x0, x1;
            int n;
            Func<double, double> f = x => x * x - 3;
            Func<double, double> df = x => 2 * x;
            double[] epsValues = { 1e-4, 1e-8, 1e-12 };
            foreach (double e in epsValues)
            {
                eps = e;
                //if (f(a) * dda > 0)
                //    x0 = a;
                //else
                //    x0 = b;
                x0 = e;
                n = 0;
                x1 = x0 - f(x0) / df(x0);
                while (Math.Abs(x1 - x0) >= eps)
                {
                    x0 = x1;
                    x1 = x0 - f(x0) / df(x0);
                    n++;
                }
                Console.WriteLine($"Pentru eps = {eps}, n = {n}, x ≈ {x1}");
            }

        }
    }
}
