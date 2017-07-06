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

            /*  for (int i = 15; i > 0; i++)
              {
                  Console.WriteLine(i);
              }
              // i exist outside of the loop because I has been inituilized beforehand.
              int i;
              for (int i = 15; i > 0; i++)
              {
                  Console.WriteLine(i);*/




            // for(int counter =15; counter>0; counter--)
            // {
            //    Console.WriteLine(counter)

            //  }
            //splits on the spaces
            //does the space have a index value
          /*  string greeting = "My name is little Bill";
            string[] wordsInGreeting = greeting.Split();//for loop to print the words
            for(int i =0; i< wordsInGreeting.Length; i++)
            {
                Console.WriteLine(wordsInGreeting[i]);
            }*/

        /*    //create an array called days with the elements monday tuesday and wednesday
            string[] days = { "Monday", "Tuesday", "Wednesday" };
            //using a for loop print the elements of the days array.
            for (int counter = 0; counter< days.Length; counter++)
            {
                Console.WriteLine(days[counter]);
            } */

         // string[] storyWord = { story };

            //start with the string "Once upon a time" and create an array called

            string story = "once upon a time.";
            //storyword using the split method.
            string[] storyWord = story.Split();

           

            //Reverse the order of the elements in
             Array.Reverse(storyWord);
         //   Console.WriteLine(story);

            for (int i = 0; i < storyWord.Length; i++)
            {
                Console.WriteLine(storyWord[i]);
            }

            //the array and using a for loop,print each word
            //add the product(multiplication)of 1 through 10 using a for loop
            //print the product  to the screen.
















        }
    }
}
