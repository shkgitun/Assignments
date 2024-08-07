// Using necessary libraries
using System;

namespace ConsoleApp
{
// Define a class named MathOperations
class MathOperations

{
// Define a method that takes two integers as parameters
public void PerformOperation(int number1, int number2)
{
// Perform a math operation (e.g., addition) on the first integer
int result = number1 + 10;

// Display the second integer to the screen
Console.WriteLine("The second integer is: "+ number2);
}
}

class Program
{
static void Main(string[] args)
{
// Instantiate the MathOperations class
MathOperations mathOps = new MathOperations();

// Call the PerformOperation method with positional arguments
mathOps.PerformOperation(5, 20);

// Call the PerformOperation method with named arguments
mathOps.PerformOperation(number1: 10, number2: 30);

// Keep the console window open
Console.ReadLine();

}
}
}