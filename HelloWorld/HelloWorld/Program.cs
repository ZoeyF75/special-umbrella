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
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            SayHi(name);
            Console.ReadLine();

        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }
}
