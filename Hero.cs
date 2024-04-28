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

        // constructor
        public Hero(string name, string location)
        {
            this.name = name;
            this.location = location;
        }

        // get and set methods for name and location
        public string GetName() { return name; }
        public string SetName(string value) { return value; }
        public string GetLocation() { return location; }
        public string SetLocation(string value) { return value; }

        // methods Save and toString
        public virtual int Save(int numOfPeople)
        {
            return (int)Math.Round(numOfPeople * 0.95);
        }
        public override string ToString()
        {
            return $"Hero: {name}, Location: {location}";
        }
    }
}
