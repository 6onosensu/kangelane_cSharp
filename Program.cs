using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kangelane_cSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random a = new Random();
            int N = a.Next();
            try
            {
                StreamWriter text = new StreamWriter(@"heroes.txt", true);
                Console.WriteLine("Enter some text: ");
                string sentence = Console.ReadLine();
                text.WriteLine(sentence);
                text.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("error with the file");
            }
            try
            {
                StreamReader text = new StreamReader(@"heroes.txt", true);
                Console.WriteLine("Enter some text: ");
                string sentences = text.ReadToEnd();
                text.Close();
                // text.ReadLine(sentences);
            }
            catch (Exception)
            {
                Console.WriteLine("There is a error with reading the file");
            }
        }

        private static StreamWriter StreamWriter(string v1, bool v2)
        {
            throw new NotImplementedException();
        }
    }
}
