using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class AproximariSuccesive
    {
        double eps;
        double xPrev;
        double xNext;
        int n;
        public AproximariSuccesive(double Eps, double xPrevious, int number)
        {
            eps = Eps;
            xPrev = xPrevious;
            this.xNext = Phi(xPrev);
            n = number;
        }
        private double Phi(double x)
        {
            return Math.Pow(x + 1, 0.25);
        }
        public void Main()
        {
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
