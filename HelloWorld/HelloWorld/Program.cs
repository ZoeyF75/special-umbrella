using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args) //main Method
        {
            int[,] numberGrid =
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            int[,] myArray = new int[2, 3];
            Console.WriteLine(numberGrid[0, 0]);

            Console.ReadLine();
        }

    }
}
