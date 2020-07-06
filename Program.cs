using System;

namespace Lab_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
      
            string entry, restart;
            double length, width, height, area, perimeter, volume;

            Console.Write("Welcome to Grand Circus' Room Detail Generator");

            Console.Write("\n");

            Start:
            Console.WriteLine("Enter the length");
            entry = Console.ReadLine();
            length = double.Parse(entry);

            Console.Write("\n");

            Console.WriteLine("Enter the width");
            entry = Console.ReadLine();
            width = double.Parse(entry);

            Console.Write("\n");

            Console.WriteLine("Enter the height");
            entry = Console.ReadLine();
            height = double.Parse(entry);

            Console.Write("\n");

            area = length * width;
            Console.WriteLine($"The area is {area}");

            perimeter = 2 * (length + width);
            Console.WriteLine($"The perimeter is {perimeter}");

            volume = length * width * height;
            Console.WriteLine($"The volume is {volume}");

            Console.Write("\n");

            if (area < 250)
            {
                Console.WriteLine("This is a small-sized room");
            }
            else if (area > 250 && area < 650)
            {
                Console.WriteLine("This is a medium-sized room");
            }
            else if (area > 650)
            {
                Console.WriteLine("This is a large-size room");
            }

            Console.Write("\n");

            Console.WriteLine("Would you like to continue?");
            restart = Console.ReadLine();

            if (restart == "yes")
            {
                Console.Write("\n");
                goto Start;
            }
            else if (restart == "no")
            {
                Console.Write("\n");
                Console.WriteLine("Thank you for using the Room Detail Generator!");
            }
        }
    }
}
