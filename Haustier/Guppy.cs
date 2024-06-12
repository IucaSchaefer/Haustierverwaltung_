using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Guppy : Fisch
    {
        public Guppy(string name, string Besitzer)
        {
            base.name = name;
            base.besitzer = Besitzer;
        }

        public override string Schwimmen()
        {
            return base.Schwimmen() + " schwimmt hin und her.";
        }
    }
}
