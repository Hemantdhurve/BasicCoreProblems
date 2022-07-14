using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class Harmonic
    {
        public static void harmonic()
        {
            Console.WriteLine("ENTER LIMIT :");
            // int count=Convert.ToInt32(Console.ReadLine());
            double count = Convert.ToDouble(Console.ReadLine());
            double har = 0;
            if (count != 0)
            {

                for (double i = 1; i < count; i++)
                {
                    har = har + 1 / i;
                }
                Console.WriteLine("HARMONIC NUMBERS ARE :" + har);
            }
        }
    }
}
