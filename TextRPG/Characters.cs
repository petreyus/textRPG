using System;

namespace PlayerClass
{

    public class Character
    {

      
        public static string Name { get; set; } = "";
        public static string Class { get; set; } = "";
        // private int Attack { get; set; } = rnd.Next(1, 100);
     
            

            public static void pickClass()
        {

             string userInput = Console.ReadLine();
            // if user selects anything but 1,2,3
            // call function again: take it from the top
            switch (userInput)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are a warrior!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Character.Class="warrior";
                    break;

                case "2":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You are a mage!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Character.Class = "mage";
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You are a thief!");
                    Character.Class = "thief";
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please type a number 1-3 to select your class");
                    Console.ForegroundColor = ConsoleColor.Green;
                    pickClass();
                    break;

            }




        }


       public void ATK()
        {
            Random rnd = new Random();
            int Attack = rnd.Next(1, 100);
            Console.WriteLine("your attack is:"+ @Attack);
        }


       public static void HP()
        {
            Console.WriteLine("Input your health");
            string hp = Console.ReadLine();
            Console.WriteLine("your hp is:" + hp);
         }






    }


}




