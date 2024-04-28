using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kangelane_cSharp
{
    internal class SuperHero: Hero
    {
        private double skill;
        public double GetSkill() { return skill; }
        public SuperHero(string name, string location) : base(name, location)
        {
            Random random = new Random();
            skill = random.NextDouble() * 4 + 1;
        }
        public override int Save(int numOfPeople)
        {
            double savePercentage = 95 + skill;
            double peopleSaved = numOfPeople * (savePercentage / 100);
            return (int)Math.Round(peopleSaved);
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Skill: {skill}";
        }
    }
}
