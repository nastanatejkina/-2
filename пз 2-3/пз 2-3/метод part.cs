using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пз_2_3
{
    public class Chislo
    {
        private double first;
        private double second;

        public Chislo(double a, double b)
        {
            first = a;
            second = b;
            a = Console.Read();
            b = Console.Read();
        }
        public (double, double) IPart() => (first / second, first % second);
    }

    
}
