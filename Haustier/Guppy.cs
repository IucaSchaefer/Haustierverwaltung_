using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Guppy : Fisch
    {
        public Guppy(string name)
        {
            base.name = name;
        }

        public override string Schwimmen()
        {
            return base.Schwimmen() + " schwimmt hin und her.";
        }
    }
}
