using System;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); //Get App Info

            GreetUser(); //Greet User

            while (true)
            {
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init Guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10.");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number.");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        //Print wrong number
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo() //App information
        {
            // Set App Version
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Janusz Dlugosz";

            //Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            //Display App Info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Text Color
            Console.ResetColor();
        }

        static void GreetUser() //Ask User and Greet
        {
            // Ask User their name
            Console.WriteLine("What is your name?");

            //User Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
