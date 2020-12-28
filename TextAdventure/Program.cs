/*
 * [Poetry by Robert Frost]
 * by JLEM, 11/28/2020
 *  
 */

using System;
using System.Collections.Generic;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.StartGame();
       
        }
    }

    public static class Game
    {
        // character name
            static string CharacterName = "Robert Frost";
        // things found on path
        static List<string> found = new List<string>();
        // keep traveling variable
        static bool traveling = true;

        // creating poem arrays
        static string[] intro = new string[]
        {
            "Two roads diverged in a yellow wood,",
            "And sorry I could not travel both",
            "And be one traveler, long I stood",
            "And looked down one as far as I could",
            "To where it bent in the undergrowth;"
        };

        static string[] pathA = new string[]
        {
            "Whose woods these are I think I know.",
            "His house is in the village, though;",
             "He will not see me stopping here",
             "To watch his woods fill up with snow.",
             "",
             "The woods are lovely, dark, and deep,",
             "But I have promises to keep,",
             "And miles to go before I sleep,",
             "And miles to go before I sleep."
        };

        static string[] pathB = new string[]
        {
            "Then took the other, as just as fair,",
            "And having perhaps the better claim,",
            "Because it was grassy and wanted wear;",
            "Though as far as that, the passing there",
            "Had worn them really about the same",
            "",
            "And both that morning equally lay",
            "In leaves no step had trodden black.",
            "Oh, I kept the first for another day!",
            "Yet knowing how way leads on to way,",
            "I doubted if I should ever come back."
        };

        static string[] closing = new string[]
        {
            "I shall be telling this with a sigh",
            "Somewhere ages and ages hence:",
            "Two roads diverged in a wood, and I --",
            "I took the one less traveled by,",
            "And that has made all the difference."
        };

        // an array of string arrays - to hold the poem parts
        static string[][] poem = new string[][]
        {
            intro,
            pathA,
            pathB,
            closing
        };

        // print out game and overview
        public static void StartGame()
        {
            Console.WriteLine("Two Roads Diverged");
            Console.WriteLine("The poetry of Robert Frost");
            NameCharacter();
            Game.Choice();
            Game.EndGame();

        }

        //ask player for name, and save it
        public static void NameCharacter()
        {
            Console.WriteLine("Please enter your traveler's name:");
            CharacterName = Console.ReadLine();
            Console.WriteLine("There you go - your traveler is named " + CharacterName);
            Console.WriteLine();

        }

        public static void Choice()
        {
            do
            {
                string input = "";
                string cont = "";

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;

                foreach (var p in poem[0])
                {
                    Console.WriteLine(p);
                }

                Console.WriteLine();
                Console.Write($"{CharacterName}, which road will you take?\n");
                Console.Write("The main road (A), or the road less traveled by?(B)\n");
                input = Console.ReadLine();
                input = input.ToUpper();

                if (input == "A")
                {
                    found.Add("Snow");
                    Console.WriteLine("You've chosen road A.");
                    Console.WriteLine();

                    foreach (var p in poem[1])
                    {
                        Console.WriteLine(p);
                    }
                    Console.WriteLine();
                }
                else
                {
                    found.Add("Road less traveled");
                    Console.WriteLine("You chosen road B:");
                    Console.WriteLine();
                    foreach (var p in poem[2])
                    {
                        Console.WriteLine(p);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Do you want to continue traveling? Y/N");
                cont = Console.ReadLine().ToUpper();
                if (cont == "Y")
                {
                    traveling = true;
                }
                else
                {
                    traveling = false;
                }
            } while (traveling);

            Console.ResetColor();
            Console.WriteLine();
        }

        public static void EndGame()
        {
            foreach (var p in poem[3])
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            Console.WriteLine("Found along the way:");
            foreach (var item in found)
            {
                Console.WriteLine(item);
            }
        }

    }

}
