using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kangelane_cSharp
{
    public class Hero
    {
        private string name;
        private string location;

        public Hero(string name, string location)
        {
            this.name = name;
            this.location = location;
        }

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

        public virtual int NumOfSavedPeople(int num)
        {
            return (int)Math.Round(num * 0.95);
        }
        public override string ToString()
        {
            return $"Hero: {name}, Location: {location}";
        }
    }
}
