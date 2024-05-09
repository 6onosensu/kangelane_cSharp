using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace kangelane_cSharp
{
    public class Program
    {
        private static List<Hero> heroes = new List<Hero>();
        private static readonly string path = @"C:\Users\opilane\source\repos\6onosensu\kangelane_cSharp\heroes.txt";
        //private static readonly string path = @"C:\work\kangelane_cSharp\heroes.txt";
        public static void Main(string[] args)
        {
            ReadHeroData(path);
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero);
                Console.WriteLine($"Saved {hero.NumOfSavedPeople(100)} out of 100 people in danger.");
            }
        }

        public static void ReadHeroData(string filename)
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (var line in lines)
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
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
        }
    }
}
