using System;
using System.Runtime.CompilerServices;

namespace roomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Room Calculator Start

            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");

            //string cont = "y";
            bool cont = true;

            while (cont)
            {
                //get room length
                Console.WriteLine("Please input your room length in feet.");
                string input = Console.ReadLine();
                double length = Double.Parse(input);

                //get room width
                Console.WriteLine("Please input your room width in feet.");
                input = Console.ReadLine();
                double width = Double.Parse(input);

                //get room height
                Console.WriteLine("Please input your room height in feet.");
                input = Console.ReadLine();
                double height = Double.Parse(input);

                //calc area
                double area = length * width;
                Console.WriteLine("The area of your room is " + area + " square feet.");

                //calc perimeter
                double perimeter = (length * 2) + (width * 2);
                Console.WriteLine("The perimeter of your room is " + perimeter + " feet.");

                //calc volume
                double volume = (length * width * height);
                Console.WriteLine("The volume of your room is " + volume + " cubic feet.");

                //calc surface area
                double surfaceArea = (2*(length*width + length*height + width*height));
                Console.WriteLine("The Surface Area of your room is " + surfaceArea + " square feet.");



                Console.WriteLine("Would you like to continue and calculate another room? (y/n)");
                input = Console.ReadLine();
                input = input.ToLower();
                //char[] charArray = input2.ToCharArray();


                /*if (input2[0] == "n")
                {
                    yes = false;
                }*/

                if (input[0] == 'y')
                {
                    cont = true;
                }
                else if (input[0] == 'n')
                {
                    cont = false;
                }

                
                /*
                if (charArray[0] == 'y')
                {
                    yes = true;
                }
                else if (charArray[0] == 'n')
                {
                    yes = false;
                }
                */
            }

            



        }
    }
}
