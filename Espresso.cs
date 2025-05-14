using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimjerDecorator
{
    public class Espresso : Kahva
    {
        public string dajOpis()
        {
            return "espresso";
        }
        public double dajCijenu()
        {
            return 3.0;
        }
    }
}
