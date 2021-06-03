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
            Console.WriteLine(GetPower(3, 2)); //9
            Console.ReadLine();
        }

        static int GetPower(int baseNum, int powNum)
        {
            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }
            return result;
        }

    }
}
