using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp2;
using NameCheck;
using PlayerClass;

namespace ConsoleApp1
{
   
     

    class Program
    {
       
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; //I change the output colors later.
                                                         // So, setting them to green here
                                                        //  prevents them not matching later.
            Console.WriteLine("What is your name stranger?");

                Character.Name=StringValidator.ConsoleUserInputChecker(Console.ReadLine()); // this validates input as string  
                Console.WriteLine("Well met " + Character.Name);                           // &
                                                                                       //Sets Character.Name.
            Console.WriteLine("How do you wish to vanquish your foes?");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1: With strength?");

                  Console.ForegroundColor = ConsoleColor.Blue;
                  Console.WriteLine("2: With intelligence?");


                 Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine("3: with Guile?");

            PlayerClass.Character.pickClass();
           
            Console.WriteLine("You are: " + Character.Name+ " the adventuring "+ Character.Class+"!");



          
            Console.WriteLine("Press any key to continue");
            Console.ReadLine(); // causes pause to read console.

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(
                "You approach a looming barn scintillating in the moonlight. " +
                "You approach the structure slowly, each foot step its own contained cacophony. " +
                "Now, you hear faint sounds coming from within the barn. What do you do?"
                );





            Console.ReadLine(); // causes pause to read console.
            // Testing:
            // Console.WriteLine(Character.Class);
            // Console.WriteLine(Character.Name);

        }






    }
}


