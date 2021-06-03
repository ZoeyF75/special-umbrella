using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy";
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("Academy"));
            Console.WriteLine(phrase[0]); //first letter
            Console.WriteLine(phrase.IndexOf("Academy")); //8 starts at index 8, -1 if string doesn't contain
            Console.WriteLine(phrase.Substring(8)); //prints out Academy

            Console.ReadLine();

        }
    }
}
