using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Goldfisch : Fisch, IStreichelbar
    {
        public Goldfisch(string name, string Besitzer)
        {
            base.name = name;
            base.besitzer = Besitzer;
        }

        public override string Schwimmen()
        {
            return base.Schwimmen() + " schwimmt im Keis.";
        }

        public string Streicheln()
        {
            return Name + " wird geschtreichelt";
        }
    }
}
