using System;
using System.Linq;

namespace Tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {

            string choice;
            int choiceInt = 0;
            bool hasChosen = false;
            Pet tamagochi = new Pet();
            System.Console.WriteLine("Name your tamagochi");
            tamagochi.name = Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine("Your tamagochi is now named: " + tamagochi.name);


            while (tamagochi.GetAlive())
            {
                Console.Clear();
                hasChosen = false;
                System.Console.WriteLine("What do you want to do with " + tamagochi.name + "?");
                System.Console.WriteLine("1. Feed " + tamagochi.name);
                System.Console.WriteLine("2. Speak with " + tamagochi.name);
                System.Console.WriteLine("3. Teach " + tamagochi.name + " a new word");
                System.Console.WriteLine("4. Show stats");
                System.Console.WriteLine("5. Nothing");


                while (!hasChosen)
                {
                    choice = Console.ReadLine();
                    bool isParsable = Int32.TryParse(choice, out choiceInt);

                    if (isParsable)
                    {
                        if (choiceInt > 0 && choiceInt < 6)
                        {
                            hasChosen = true;
                        }
                        else
                        {
                            System.Console.WriteLine("Chose a number between 1 and 4!");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Write a number!");
                    }

                    switch (choiceInt)
                    {
                        case 1:
                            tamagochi.Feed();
                            Console.WriteLine("Feeded");
                            break;
                        case 2:
                            tamagochi.Hi();
                            break;
                        case 3:
                            System.Console.WriteLine("Teach " + tamagochi.name + " a new word");
                            string newWord = Console.ReadLine();
                            tamagochi.Teach(newWord);
                            System.Console.WriteLine(tamagochi.name + " has learned " + newWord);
                            break;
                        case 4:
                            tamagochi.PrintStats();
                            break;
                        case 5:
                            System.Console.WriteLine("You do nothing");
                            break;
                        default:

                            break;
                    }

                }

                Console.ReadKey();
                tamagochi.Tick();
            }

            System.Console.WriteLine(choiceInt);
            Console.ReadLine();

        }
    }
}
