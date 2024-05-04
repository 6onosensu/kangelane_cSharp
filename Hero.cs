using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kangelane_cSharp
{
    public class Hero
    {
        private string name;
        private string location;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public Hero(string name, string location)
        {
            Name = name;
            Location = location;

        }

        public virtual int NumOfSavedPeople(int numInDanger)
        {   
            return (int)Math.Round(numInDanger * 0.95);
        }

        public override string ToString()
        {
            return $"Hero: {Name}, Location: {Location}";
        }
    }
}
