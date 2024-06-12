using System.Text;

namespace Haustier
{
    public abstract class Haustier
    {
        //public Haustier(string name)
        //{

        //}

        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append(" ");
            sb.Append(Name);
            return sb.ToString();
            // return base.ToString() + " " + Name;
        }
        public string Name
        { get { return name; } }
        public virtual string Pflege()
        {
            return this.ToString().Substring(ToString().IndexOf('.') + 1) + " " + Name;
        }

        protected string name;
        protected string besitzer;
    }
}

