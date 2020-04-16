using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagate_Example
{

    
    public static class Calculator
    {
        public delegate double CalcCriteria(double n1, double n2);
        public static double calc(double a, double b, CalcCriteria criteria)
        {
            return criteria(a, b);
        }
    }
}
