using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimjerDecorator
{
    public class MlijekoDekorater : KahvaDecorator
    {
     

        public MlijekoDekorater(Kahva hrana) : base(hrana)
        { }
        
        public override double dajCijenu()
        {
            return _hrana.dajCijenu() + 1.5;
        }

        public override string dajOpis()
        {
            return _hrana.dajOpis() + " i mlijeko";
        }


    }
}
