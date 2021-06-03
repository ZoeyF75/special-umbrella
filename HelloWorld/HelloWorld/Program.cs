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
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();
            Console.Write("Enter a number: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            
            if (op == "+")
            {
                Console.Write(num1 + num2);
            }
            else if (op == "-")
            {
                Console.Write(num1 - num2);
            }
            else if (op == "*")
            {
                Console.Write(num1 * num2);
            }
            else if (op == "/")
            {
                Console.Write(num1 / num2);
            }else
            {
                Console.WriteLine("You misentered an input value");
            }
            
            Console.ReadLine();
        }
    }
}
