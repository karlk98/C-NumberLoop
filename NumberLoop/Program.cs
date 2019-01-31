using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            string space = " ";
            do
            {
                num1++;
                Console.Write(num1 + space);
            }
            while (num1 < 100);
            Console.ReadKey();
        }
    }
}
