using System;
using System.Security.Policy;

namespace QuittableExample
{
    // Main program class
    class Program
    {
        // Entry point of the program
        static void Main(string[] args)

        {
            // Create an instance of Employee
            Employee employee = new Employee();

            // Use polymorphism to create an object of type IQuittable
            IQuittable quittable = employee;

            // Call the Quit method on the IQuittable object
            quittable.Quit();

            // Keep the console window open
            Console.ReadLine();
        }
    }

    // Define an interface called IQuittable
    public interface IQuittable
    {
        // Define a method signature for Quit
        void Quit();
    }

    // Assuming the Employee class exists in the namespace
    public class Employee : IQuittable
    {
        // Employee properties and methods would be here

        // Implementing the Quit method from the IQuittable interface
        public void Quit()
        {
            // Provide the implementation for the Quit method
            Console.WriteLine("The employee has quit the job.");
        }
    }
}