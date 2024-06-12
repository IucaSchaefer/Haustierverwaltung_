using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Hausschwein: Saeuger, IFleischfresser, IPflanzenfresser
    {
        public Hausschwein(string Name, string Besitzer) 
        {
            base.name = Name;
            base.besitzer = Besitzer;
        }

        string IPflanzenfresser.Fressen()
        {
            return Name + "frisst Pflanzen"; 
        }

        string IFleischfresser.Fressen()
        {
            return Name + "frisst Fleisch";
        }
    }
}
