using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculnumericlab4
{
    internal class function
    {
        string Data;
        List<string> input;
        List<double> variables;
        public function(string data)
        {
            Data = data;
            string[] split = data.Split(new char[] {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '+', '*', '/', '^'});
            input = new List<string>();
            foreach (string variable in split)
            {
                input.Add(variable);
            }
        }
        public void functionSolver()
        {
            string Calculus = (string)Data.Clone();
            foreach (string variable in input)
            {
                Console.WriteLine("Care este valoarea lui " + $"{variable}" + "?");
                double input = double.Parse(Console.ReadLine());
                variables.Add(input);
                Calculus.Replace(variable, input.ToString());
            }
            foreach (string variable in input)
            {
            }
        }
        //public

        //public double Derevation()
        //{
        //    double output;
        //    output = 
        //    return output;
        //}
    }
}
