using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        { 
            string userInput = "y";
            while (userInput == "y")
            {
                //1.Prompt the user to enter the values of length and width of the classroom
                //2 Display the area and perimeter of said classroom
                //3 Prompt the user to continue
                double length, width, height;
                string LengthString, HeightString, WidthString ;
                Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
               
                Console.WriteLine("Enter Length: ");
                LengthString = Console.ReadLine();
                length = double.Parse(LengthString);
                
                Console.WriteLine("Enter Width: ");
                WidthString = Console.ReadLine();
                width = double.Parse(WidthString);
                
                Console.WriteLine("Enter Height: ");
                HeightString = Console.ReadLine();
                height = double.Parse(HeightString);
                
                double total = length * width;
                double perimeter = length + length + width + width;
                double volume = length * width * height;
                
                Console.WriteLine("Area: " + total + "");
                Console.WriteLine("Perimeter: " + perimeter + "");
                Console.WriteLine("Volume: " + volume + "");
                Console.WriteLine("Continue? (y/n) ");
                userInput = Console.ReadLine().ToLower();
                
             
            
            }
        }
    }
}
