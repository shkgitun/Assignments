using System;

namespace StructAssignment
{
    // Define a struct named Number

    public struct Number
    {
        // Property of the struct named Amount with a decimal data type
        public decimal Amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the struct Number
            Number number = new Number();

            // Assign a value to the Amount property of the Number instance
            number.Amount = 123.45M;

            // Print the value of the Amount property to the console
            Console.WriteLine("The amount is: " +number.Amount);

            // Keep the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}