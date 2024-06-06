using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public abstract class Saeuger : Haustier, IStreichelbar
    {
        public virtual string Fortbewegen()
        {
            return this.ToString().Substring(ToString().IndexOf('.') + 1) + " " + Name;
        }

        public string Streicheln()
        {
            return Name + " wird gestreichelt";
        }
    }
}
