using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    class SwapNumbers
    {
        public static void swapNumbers()
        {
            Console.WriteLine("INPUT 1ST NUMBER :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("INPIUT 2ND NUMBER :");
            int b = Convert.ToInt32(Console.ReadLine());

            int temp = 0;

            Console.WriteLine("BEFORE SWAPPING a :" +a + "b :" +  b);

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After Swapping b :" + a + "a :" + b);
        }
    }
}
