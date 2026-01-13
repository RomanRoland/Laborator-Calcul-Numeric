using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double x0 = a;
            double eps = 1e-8; 
            double xPrev = x0;
            double xNext = 0.5 * (xPrev + a / xPrev);
            int n = 1;
            Heron alg = new Heron(a, x0, eps, xPrev, xNext, n);
            Console.WriteLine("Heron");
            alg.Main();
            eps = 1e-4;
            xPrev = 1;
            n = 1;
            AproximariSuccesive Alg = new AproximariSuccesive(eps, xPrev, n);
            Console.WriteLine("Aproximari Succesive");
            Alg.Main();
            eps = 1e-4;
            xPrev = 0.5;
            n = 1;
            Exercitiu_3 algo = new Exercitiu_3(eps, xPrev, n);
            Console.WriteLine("Exercitiul 3");
            algo.Main();
            eps = 1e-4;
            xPrev = 3 * Math.PI / 8;
            n = 1;
            Exercitiu_4 Algo = new Exercitiu_4(eps, xPrev, n);
            Console.WriteLine("Exercitiul 4");
            Algo.Main();
        }
    }
}
