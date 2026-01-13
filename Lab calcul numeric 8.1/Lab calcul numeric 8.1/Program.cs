using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_calcul_numeric_8._1
{
    internal class Program
    {
        static double Factorial(int n)
        {
            double f = 1;
            for (int i = 1; i <= n; i++)
                f *= i;
            return f;
        }
        static double TaylorCos(double u)
        {
            return 1
                - Math.Pow(u, 2) / Factorial(2)
                + Math.Pow(u, 4) / Factorial(4)
                - Math.Pow(u, 6) / Factorial(6)
                + Math.Pow(u, 8) / Factorial(8);
        }
        static void Main(string[] args)
        {
            double u = Math.PI / 6;
            double approx = TaylorCos(u);
            double exact = Math.Cos(u);
            Console.WriteLine("Aproximare cos(pi/6) cu Taylor ordin 8:");
            Console.WriteLine($"T8(pi/6) = {approx}");
            Console.WriteLine($"cos(pi/6) = {exact}");
            Console.WriteLine($"sqrt(3)/2 = {Math.Sqrt(3) / 2}");
        }
    }
}
