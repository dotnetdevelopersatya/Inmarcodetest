using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a   program that   loops through[1..100].   
            //It should   do the following:    
            //a) If the   number is divisible   by   3,   print fizz
            //b) If divisible   by   5   print   “buzz”.    
            //c) If divisible   by   3 & 5,   print   “fizzbuzz”.    

            //psudo code
            for (int i = 1; i < 100; i++)
            {
                //div by both 3&5 FIZZBUZZ
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                //div by 5 BUZZ
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                //div by 3 FIZZ
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else
                {
                    //do nothing
                }
            }

            // pause at end
            Console.ReadLine();
        }
    }
}
