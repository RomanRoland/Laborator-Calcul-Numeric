using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Heron
    {
        private double a;//5
        private double x0;// = a;
        private double eps; //= 1e-8;
        private double xPrev;//= x0;
        private double xNext; //= 0.5 * (xPrev + a / xPrev);
        private int n; //= 1;
        public Heron(double A, double X0, double Eps, double xPrevious, double xNext, int number)
        {
            a = A;
            x0 = X0;
            eps = Eps;
            xPrev = xPrevious;
            this.xNext = xNext;
            n = number;
        }
        public void Main()
        {
            while (Math.Abs(xNext - xPrev) >= eps)
            {
                xPrev = xNext;
                xNext = 0.5 * (xPrev + a / xPrev);
                n++;
            }
            Console.WriteLine(n);
            Console.WriteLine(xNext);
            Console.ReadKey();
        }
    }
}
