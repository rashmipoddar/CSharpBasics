using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello World!";
            char h = 'H';
            string animal = "elephants";
            string filePath = @"c:\foo\bar.txt";
            string message = "My name is {0}. I live in {1}.";
            
            modifyString(greeting);
            removeFirstAndLastCharFromString(greeting);
            getCharsAtSpecificIndex(animal);
            isCharInString(greeting, h);
            getIndexOfCharInString(greeting, h);
            getFileNameAndDrive(filePath);
            splitStringToArray(greeting);
            formatStringWithFormattingTokens(message);
            
        }

        /// <summary>
        /// Creates a new substring by removing the first and last character of input string
        /// </summary>
        /// <param name="greeting"></param>
        /// <returns>The new substring created<returns>

        static void modifyString(string greeting)
        {
            string substring = greeting.Substring(1, greeting.Length - 2);
            Console.WriteLine(substring);
        }

        // Alternate method of removing first and last characters from a string
        static void removeFirstAndLastCharFromString(string greeting)
        {
            string modifiedGreeting = greeting.Remove(0, 1);
            modifiedGreeting = modifiedGreeting.Remove(greeting.Length - 2, 1);
            Console.WriteLine(modifiedGreeting);
        }

        // Print first, middle and last char of the string concatenated together
        static void getCharsAtSpecificIndex(string animal)
        {
            char firstChar = animal[0];
            char middleChar = animal[animal.Length / 2];
            char lastChar = animal[animal.Length - 1];

            Console.WriteLine(firstChar.ToString() + middleChar.ToString() + lastChar.ToString());
        }

        // check if a char is present in a string
        static void isCharInString(string greeting, char h)
        {
            bool isCharPresent = greeting.Contains(h);
            Console.WriteLine(isCharPresent);
        }

        // get the index of a particular char in string
        static void getIndexOfCharInString(string greeting, char h)
        {
            int charIndex = greeting.IndexOf(h);
            Console.WriteLine(charIndex);
        }

        // Get the filename without extension and the drive name in uppercase from a filepath
        static void getFileNameAndDrive (string filePath)
        {
            string[] subPath = filePath.Split('\\');
            // Array.ForEach(subPath, Console.WriteLine);
            string[] fileNameArray = subPath[subPath.Length - 1].Split('.');
            string fileName = fileNameArray[0];
            Console.WriteLine(fileName);

            char drive = Char.ToUpper(subPath[0][0]);
            // Console.WriteLine(Char.ToUpper(drive));
            Console.WriteLine(drive);
        }

        // split string into array on spaces and print every item in the array
        static void splitStringToArray(string greeting)
        {
            string[] words = greeting.Split(' ');
            Array.ForEach(words, Console.WriteLine);
        }

        // Create a string with formatting tokens
        static void formatStringWithFormattingTokens(string message)
        {
            string formattedString = String.Format(message, "Sara", "Seattle");
            Console.WriteLine(formattedString);
        }

        
    }
}
