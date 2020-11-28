using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string CharacterName = "John Doe";


            Console.WriteLine("Game Title");
            Console.WriteLine("Welcome to ...");
            Console.WriteLine("Please enter your characters's name:");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Great, Your character is now named " + CharacterName);

        }
    }
}
