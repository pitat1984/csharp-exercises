using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentance = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string input;
            double miles;
            double gal;
            double mpg;

            Console.WriteLine("Search for a word in Alice in Wonderland");
            input = Console.ReadLine();

            string lowercase = sentance.ToLower();
            string lower_input = input.ToLower();

            //Console.WriteLine(lowercase.IndexOf(lower_input));
            if (lowercase.IndexOf(lower_input) > -1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            input = Console.ReadLine();
            
        }
    }
}
