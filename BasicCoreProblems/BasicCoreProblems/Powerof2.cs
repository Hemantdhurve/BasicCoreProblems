using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class Powerof2
    {
        public static void powerOf2()
        {
            Console.WriteLine("2 TAKEN AS OUR BASE VALUE");
            int basevalue = 2;  

            Console.WriteLine("INPUT EXPONENT");
            int exponent=Convert.ToInt32(Console.ReadLine());

            int power = 1;
            for (int i = 1; i <= exponent; i++)
            power *= basevalue;

            Console.WriteLine("2^exponent :" + power);

        }
    }
}
