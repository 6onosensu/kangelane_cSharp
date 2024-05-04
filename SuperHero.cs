using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace kangelane_cSharp
{
    public class SuperHero : Hero
    {
        private static readonly Random rand = new();
        private double skill = Math.Round((rand.NextDouble() * 4) + 1);
        public double Skill
        {
            get { return skill; }
            set { skill = value; }
        }
        public SuperHero(string name, string location) : base(name, location)
        {
        }

        public override int NumOfSavedPeople(int numInDanger)
        {

            return (int)Math.Round(numInDanger * ((95 + skill) / 100));
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Skill: {Skill}";
        }
    }
}
