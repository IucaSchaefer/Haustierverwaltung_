using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public abstract class Fisch : Haustier
    {
        public virtual string Schwimmen()
        {
            return this.ToString().Substring(ToString().IndexOf('.') + 1) + Name;
        }

        public override string Pflege()
        {
            return WasserWechseln();
        }

        private string WasserWechseln()
        {
            return this.ToString().Substring(ToString().IndexOf('.')+1) +  Name + " Wasser wird gewechselt";
        }
    }
}
