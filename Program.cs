using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kangelane_cSharp
{
    public class Program
    {
        private static List<Hero> heroes = new List<Hero>();

        public static void Main()
        {
            ReadHeroData("heroes.txt");

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero);
                Console.WriteLine($"Saved {hero.Save(100)} out of 100 people in danger.");
            }
        }

        public static void ReadHeroData(string filename)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(" / ");
                        var name = parts[0].Trim();
                        var location = parts[1].Trim();
                        Hero hero;

                        if (name.EndsWith("*"))
                        {
                            hero = new SuperHero(name.TrimEnd('*'), location);
                        }
                        else
                        {
                            hero = new Hero(name, location);
                        }

                        heroes.Add(hero);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}
