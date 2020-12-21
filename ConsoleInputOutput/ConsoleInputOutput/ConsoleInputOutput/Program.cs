using System;

namespace ConsoleInputOutput
{
    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your middle name");
            string middleName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();
            Console.Write(firstName);
            Console.Write($" {middleName} ");
            Console.Write(lastName);
            Console.Write("\n");
            Console.WriteLine("Press any key to exit.....");
            Console.ReadLine(); // Waits till the user presses enter before moving on
                                // Console.ReadKey(); // Moves on as soon as a key is pressed


            if (args.Length == 0 || (args.Length == 1 && args[0] == "/?"))
            {
                Console.WriteLine("Please enter valid arguments");
                Console.WriteLine("The arguments example is: 1 True");
            }
            else if (args.Length < 2)
            {
                Console.WriteLine("Two arguments are needed for the program to run");
            }
            else if (args[0] != "0" && args[0] != "1" && args[0] != "2" && args[0] != "3")
            {
                Console.WriteLine("The first argument can only be 0, 1, 2 or 3");
            }
            else
            {
                int directionNumber = int.Parse(args[0]);
                var path = ((Direction)directionNumber).ToString();
                bool parsedValue;
                if (Boolean.TryParse(args[1], out parsedValue))
                {
                    Console.WriteLine(parsedValue);
                }
                else
                {
                    Console.WriteLine("Please enter true or false as the second argument");
                    // throw new Exception("Please enter true or false as the second argument");
                }
                if (args.Length > 2)
                {
                    int value = int.Parse(args[2]);
                    Console.WriteLine(value);
                }
                Console.WriteLine(path);


            }

        }
    }
}
