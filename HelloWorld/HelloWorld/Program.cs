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
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int answer = cube(number);
            Console.WriteLine(answer);
            Console.ReadLine();

        }

        static int cube(int num)
        {
            return num * num * num;
        }
    }
}
