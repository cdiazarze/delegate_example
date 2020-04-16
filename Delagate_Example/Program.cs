using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagate_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator.CalcCriteria myCriteria = new Calculator.CalcCriteria(Mul);
            Console.WriteLine(myCriteria(3,10));
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }
        static double Sus(double a, double b)
        {
            return a - b;
        }
        static double Mul(double a, double b)
        {
            return a * b;
        }
        static double Div(double a, double b)
        {
            return a / b;
        }
    }
}
