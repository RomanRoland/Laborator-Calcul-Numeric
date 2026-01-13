using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_calcul_n_umeric_8
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
        static double TaylorExp(double u, int n)
        {
            double sum = 0;
            for (int k = 0; k <= n; k++)
                sum += Math.Pow(u, k) / Factorial(k);
            return sum;
        }
        static double TaylorSin(double u)
        {
            return u
                - Math.Pow(u, 3) / Factorial(3)
                + Math.Pow(u, 5) / Factorial(5)
                - Math.Pow(u, 7) / Factorial(7);
        }
        static void Main()
        {
            int n = 7;
            double eApprox = TaylorExp(1, n);
            Console.WriteLine("Aproximare e:");
            Console.WriteLine($"T7(1) = {eApprox}");
            Console.WriteLine($"e real = {Math.E}");
            Console.WriteLine();
            double u1 = Math.PI / 4;
            double sinPi4 = TaylorSin(u1);
            Console.WriteLine("Aproximare sin(pi/4):");
            Console.WriteLine($"T7(pi/4) = {sinPi4}");
            Console.WriteLine($"sin(pi/4) = {Math.Sqrt(2) / 2}");
            Console.WriteLine();
            double u2 = Math.PI / 18;
            double sin10 = TaylorSin(u2);
            Console.WriteLine("Aproximare sin(10°):");
            Console.WriteLine($"T7(pi/18) = {sin10}");
            Console.WriteLine($"sin(10°) = {Math.Sin(u2)}");
        }
    }
}
