using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul_numeric_lab_1._1
{
    internal class Program
    {
        static void Main()
        {
            double eps = 1e-3;
            double x1 = 0, x2 = 0, x3 = 0;
            double x1New, x2New, x3New;
            int iter = 0;
            do
            {
                x1New = (10 - x2 - x3) / 5.0;
                x2New = (4 - x1New - 4 * x3) / 6.0;
                x3New = (-7 - x1New - x2New) / 10.0;
                iter++;
                Console.WriteLine($"Iter {iter}: x1={x1New:F5}, x2={x2New:F5}, x3={x3New:F5}");
                if (Math.Max(
                        Math.Abs(x1New - x1),
                        Math.Max(Math.Abs(x2New - x2), Math.Abs(x3New - x3))
                    ) < eps)
                    break;
                x1 = x1New;
                x2 = x2New;
                x3 = x3New;
            } while (true);
            Console.WriteLine("\nSolutia finala:");
            Console.WriteLine($"x1 = {x1New:F4}");
            Console.WriteLine($"x2 = {x2New:F4}");
            Console.WriteLine($"x3 = {x3New:F4}");
        }
    }
}
