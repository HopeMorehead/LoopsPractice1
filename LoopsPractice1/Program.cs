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
            //the array and using a for loop,print each word
            Array.Reverse(storyWord);
            //   Console.WriteLine(story);

            for (int i = 0; i < storyWord.Length; i++)
            {
                Console.WriteLine(storyWord[i]);
            }

            //add the product(multiplication)of 1 through 10 using a for loop
            //print the product  to the screen.



            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int product = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                product = product * numbers[i];
            }

            Console.WriteLine(product);





            /*  int product = 1;

              for (int i = 1; i <= 10; i++)
              {
                  product = product * i;
              }


              Console.WriteLine(product); */



            //foreach loop- used to iterate over a collection (Exception. list or array)
            //You can think of the structure of a foreach loop as the statement:
            //For each item in the collection , do something

            // foreach(datatype variable in collection)
            // {
            //   do something

            ///  }
            ///  


            string[] firstMonths = { "Jan", "Dog", "Mar", "Apr" };
            // Always start with the keyword foreach
            foreach (string month in firstMonths)
            {
                Console.WriteLine(month[0]);
                Console.WriteLine(month.Length);
            }


            //foreach loops allow the temporary variable to know to assign
            //itself to each element in the collection(like an array), one at a times.

            //create an array of 6 musicians (bands or solo artists)
            //using a foreach loop,print each musician's name

            /*  string[] musicians = { "Micheal Jackson", "Flyleaf", "Breaking Benjamin", "Batman", "DaftPunk", "Hope" };



              foreach (string singers in musicians)
              {
                  Console.WriteLine(singers[0]);
                  Console.WriteLine(singers.Length);
                  Console.WriteLine(singers);
              }

              //while loop is used when you want a chunk of code to run only if a condition is met first.
              //while something is TRUE, do this thing.

              string firstName = Console.ReadLine();
              while (firstName.ToUpper() == "Daniel") 
              {
                  Console.WriteLine("Dude, I'm amazing");
                  break;
              }

              Console.WriteLine("Do you want to play the game? YES/NO");
              string playAgain = Console.ReadLine().ToUpper();
              while(playAgain.ToUpper() == "YES")
              {
                  Console.WriteLine("It's a rematch Yes/No");
                  playAgain = Console.ReadLine();
              };*/

            //A Do-while loop is similar to a while loop, however 
            //the do-won i hile loop is used when you want a chunk of code to run
            //at least once, but repeat only if the while condition is met
            //The structure of a do-while loop looks like this:

            /* do
             {
                 do something
             }
             while (condition);*/
            /*   string playAgain;
               do
               {
                   Console.WriteLine("Do you want to play the game? Yes/No");
                   Console.WriteLine("Great game");
                   Console.WriteLine("Do you want to play again? YES/NO");
                   playAgain = Console.ReadLine().ToUpper();
               }
               while (playAgain == "YES");*/

            //Ask the user for the class (in school) that they would like to add to their 
            //GPA calculation.
            //Ask the user for the letter grade for the class (no + or -)
            //Ask the user if they have another class they would like to add to their GPA calculation.
            //   using a do while loop, repeat the code if the user says "YES

            Console.WriteLine("Is there a additonal class you would like to add?");
            string userinput = Console.ReadLine();
            Console.WriteLine("What grad did you get?");
            string userinput2 = Console.ReadLine();
            do
            {

                Console.WriteLine("Grade added!");



            } while (userinput2 == "YES");
        }
    }
}


                