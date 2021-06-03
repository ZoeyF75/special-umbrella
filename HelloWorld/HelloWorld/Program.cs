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
            int[] luckyNumbers = {4, 8, 16, 4, 13 };
            string[] friends = new string[10]; //can hold ten values
            luckyNumbers[0] = 900; //update value
            friends[0] = "Jim";
            friends[1] = "Fred";

            Console.WriteLine(luckyNumbers[0]); //prints the 4

            Console.ReadLine();

        }
    }
}
