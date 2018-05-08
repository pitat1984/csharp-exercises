using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double radius = -1;
            double area;


            while (radius < 0)
            {
                Console.WriteLine("Enter a radius: ");
                input = Console.ReadLine();
                radius = double.Parse(input);

                if (radius < 0)
                {
                    Console.WriteLine("You need to enter a number greater than -1.");
                }

            }
                area = Math.Round(Math.PI * radius * radius, 3);
                Console.WriteLine("The area of a circle with radius " + radius + " is: " + area);
                Console.ReadLine();
            
        }
    }
}
