using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kangelane_cSharp
{
    public class SuperHero: Hero
    {
        private static Random random = new Random();
        private double skill;

        public double GetSkill() { return skill; }

        public SuperHero(string name, string location) 
            : base(name, location)
        {
            Random random = new Random();
            // returns a random floating-point number
            // that is greater than or wqual to 0.0, and less than 1.0
            skill = random.NextDouble() * 4 + 1; 
        }

        //The override modifier is required to extend
        //or modify the abstract or virtual implementation
        //of an inherited method, property, indexer, or event.
        public override int Save(int numOfPeople)
        {
            double savePercentage = 95 + skill;
            return (int)Math.Round(numOfPeople * (savePercentage / 100));
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Skill: {skill}";
        }
    }
}
