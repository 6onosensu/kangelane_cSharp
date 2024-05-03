using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kangelane_cSharp
{
    public class SuperHero: Hero
    {
        private static Random rand = new Random();
        private double skill;

        public double GetSkill() { return skill; }

        public SuperHero(string name, string location)
        {
            this.skill = rand.NextDouble() * 4 + 1; 
        }

        public override int NumOfSavedPeople(int num)
        {
            return (int)Math.Round(num * ((95 + skill) / 100));
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Skill: {skill}";
        }
    }
}
