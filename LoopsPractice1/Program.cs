using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //When would you use a loop?
            //Why would you use a loop?
            //Nested Loops
            //Infinite Loops
            //Keywords break and continue
            //for loops
            //foreachloops
            //while loops
            //do-while loops


            //For Loop
            //Used for both counting and 
            //Iterating through an array (or other collection type)
            //Looks like this
            //for(initializer;condition;updater)
            //  {

            //    do something
            //}


            //    for(int i=0; i <= 10; i++)
            //   {
            //      Console.WriteLine(i);
            //     }
            //  prints the 0-11 all that meets the condition.

            for (int i = 15; i > 0; i--)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}
