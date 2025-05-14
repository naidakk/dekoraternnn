using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimjerDecorator 
{
    public abstract class KahvaDecorator : Kahva
    {
        public Kahva _hrana;
        public KahvaDecorator(Kahva hrana)
        {
            _hrana = hrana;
        }
        public virtual string dajOpis()
        {
            return _hrana.dajOpis();
        }
        public virtual double dajCijenu()
        {
            return _hrana.dajCijenu();
        }
    }
}
