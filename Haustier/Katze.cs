using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Katze : Saeuger
    {
        public Katze(string Name)
        {
            base.name = Name;
        }

        public override string Pflege()
        {
            return base.Pflege() + " wird gebürstet";
        }

        public override string Fortbewegen()
        {
            return base.Fortbewegen() + " schleicht";
        }

    }
}
