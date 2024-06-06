namespace Haustier
{
    public abstract class Haustier
    {
        //public Haustier(string name)
        //{

        //}
        public string Name
        { get { return name; } }
        public virtual string Pflege()
        {
            return this.ToString().Substring(ToString().IndexOf('.') + 1) + " " + Name;
        }

        protected string name;
    }
}

