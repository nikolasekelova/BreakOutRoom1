using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakOutRoom1
{
    internal class BezpecneDelenie
    {
        public double PodelCisla(double a, double b)
        {
            if (b == 0.0)
            {
                throw new ArgumentException("Nulou nejde delit.");
            }
            return a/b;
        
        }
    }

}
