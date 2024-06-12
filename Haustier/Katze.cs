using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Katze : Saeuger, IFleischfresser
    {
        public Katze(string Name, string Besitzer)
        {
            base.name = Name;
            base.besitzer = Besitzer;
        }

        public string Fressen()
        {
            return Name + " frisst Fleisch";
        }
        private string Schnurren()
        {
            return " schnurrt";
        }

        public override string Streicheln()
        {
            return Name + Schnurren();
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
