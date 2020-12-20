using System;

namespace CSharpBasics
{
    enum Languages
    {
        JavaScript,
        Python = 10, 
        CSharp = 20
    }

    struct Book
    {
        public string name;
        public int price;
        public string author;
    }

    class Program
    { 
        static void Main(string[] args)
        {
            // String Basics
            // StringBasics.run();

            // Number Basics 
            // NumberBasics.runNumberBasics();


            // Declare a variable and assing it to one of the enum values
            Languages learning = Languages.CSharp;
            Console.WriteLine(learning); // CSharp
            Console.WriteLine(learning.GetType()); // CSharpBasics.Languages

            // enum to string conversion
            string lang = learning.ToString(); // CSharp
            Console.WriteLine(lang); // CSharp

            // enum to int conversion
            int score = (int) learning;
            Console.WriteLine(score); // 20

            // int to enum conversion
            Languages experienced = (Languages) 0;
            Console.WriteLine(experienced); // JavaScript

            Book book1 = new Book();
            book1.name = "Harry Potter";
            book1.price = 10;
            book1.author = "J. K. Rowling";

            Book book2 = new Book();
            book2.name = "False Impressions";
            book2.price = 15;
            book2.author = "Jeffrey Archer";

            Console.WriteLine(book1.name); // Harry Potter
            Console.WriteLine(book1.price); // 10
            Console.WriteLine(book1.author); // J. K. Rowling

            book1.name = book2.name;
            book1.price = book2.price;
            book1.author = book2.author;

            Console.WriteLine(book1.name); // False Impressions
            Console.WriteLine(book1.price); // 15
            Console.WriteLine(book1.author); // Jeffrey Archer

        }
    }
}
