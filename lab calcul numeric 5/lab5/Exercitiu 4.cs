using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Exercitiu_4
    {
        double eps;
        double xPrev;
        double xNext;
        int n;
        public Exercitiu_4(double Eps, double xPrevious, int number)
        {
            eps = Eps;
            xPrev = xPrevious;
            this.xNext = Phi(xPrev);
            n = number;
        }
        static double Phi(double x)
        {
            return Math.Sin(x) + 0.25;
        }
        public void Main()
        {
            double eps = 1e-4;
            double xPrev = 3 * Math.PI / 8;
            double xNext = Phi(xPrev);
            int n = 1;
            while (Math.Abs(xNext - xPrev) >= eps)
            {
                xPrev = xNext;
                xNext = Phi(xPrev);
                n++;
            }
            Console.WriteLine(n);
            Console.WriteLine(xNext);
            Console.ReadKey();
        }
    }
}
