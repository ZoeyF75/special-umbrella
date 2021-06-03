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
            bool isMale = false;
            bool isTall = false;
            if (isMale && isTall)
            {
               Console.WriteLine("You are a tall male");
            } else if (isMale)
            {
                Console.WriteLine("You are a male");
            } else
            {
               Console.WriteLine("You are not male");
            }
            Console.ReadLine();
        }
    }
}
