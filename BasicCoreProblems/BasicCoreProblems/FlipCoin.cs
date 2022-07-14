using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasicCoreProblems
{
    public class FlipCoin
    {
        public static void flipCoin()
        {
            Console.WriteLine("INPUT NUMBER OF TIMES TO FLIP COIN :");
            int number = Convert.ToInt32(Console.ReadLine());
            //variables
            int head = 0;
            int tail = 0;


            for (int i = 0; i < number; i++)
            {
                Random random = new Random();
                int flip = random.Next(0, 2);

                if (flip < 0.5)
                {
                    Console.WriteLine("FLIPPED COIN SHOWS TAIL" + tail++);
                }
                else
                {
                    Console.WriteLine("FLIPPED COINS SHOWS HEAD" + head++);
                }

                NewMethod(number, tail, head);
            }
        }
        private static void NewMethod(int number, int tail, int head)
        {
            float tailpercent = tail * 100 / number;
            float headpercent = head * 100 / number;

            Console.WriteLine("TAIL PERCENTAGE :" + tailpercent);
            Console.WriteLine("HEAD PERCENTAGE :" + headpercent);
        }
    }
}

