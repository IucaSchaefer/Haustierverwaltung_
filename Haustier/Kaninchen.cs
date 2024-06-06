using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Kaninchen : Saeuger
    {
        public Kaninchen(string name) 
        {
            base.name = name;
        }

        public override string Pflege()
        {
            return base.Pflege() + " Stall wird ausgemistet";
        }

        public override string Fortbewegen()
        {
            return base.Fortbewegen() + " Hoppelt hin und her";
        }
    }
}
