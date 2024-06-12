using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Kaninchen : Saeuger, IPflanzenfresser
    {
        public Kaninchen(string name, string Besitzer) 
        {
            base.name = name;
            base.besitzer = Besitzer;
        }

        public string Fressen()
        {
            return Name + " frisst Pflanzen";
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
