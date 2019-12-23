using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");


            string input = Console.ReadLine();

            switch (input)
            {
                case "21":
                    Console.WriteLine("you can hit the blunt my guy");
                    break;
                case "60":
                    Console.WriteLine("you can hit the blunt my boomer");
                    break;
                case "12":
                    Console.WriteLine("you have to ask your mother if you can hit the blunt");
                    break;
                default:
                    Console.WriteLine("you mums a hoe, no chance.");
                    break;

            }

            //if (input == "21")
            //{
            //    Console.WriteLine("You can hit the blizzy my guy, chill");

            //}
            //else if (input == "30")
            //{
            //    Console.WriteLine("get out ya boomer");
            //}
            //else
            //{
            //    Console.WriteLine("youre too young gtfoh");
            //}
        } 
    }
}
