using System;
namespace NameCheck
{
    class StringValidator
    {

        public static string ConsoleUserInputChecker(string Name)

        {
            // checks for any digits in the input string
            foreach (char c in Name)

             if (!Char.IsLetter(c))
                {


                    Console.WriteLine("Input must be letters only; try again.");
                    Name = Console.ReadLine();
                    return ConsoleUserInputChecker(Name);
                }
            // checks for empty input string
            if (string.IsNullOrEmpty(Name))

            {

                Console.WriteLine("Input can't be empty; try again.");
                Name = Console.ReadLine();
                return ConsoleUserInputChecker(Name);
            }
            // To do:
            // check if user has a Space in name, 
            // then output error as "no character spaces".

            else
            {


                return (Name);
            }



        }


    }
}