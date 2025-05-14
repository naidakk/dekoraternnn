using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimjerDecorator
{
    class SecerDekorater: KahvaDecorator
    {
        Kahva _hrana;

        public SecerDekorater( Kahva hrana) : base(hrana)
        {
            _hrana = hrana;
        }


        public override double dajCijenu()
        {
            return _hrana.dajCijenu() + 1.0;
        }

        public override string dajOpis()
        {
            return _hrana.dajOpis() + " i secer";
        }


    }
}
