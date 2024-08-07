using System;

namespace EmployeeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and set its properties
            Employee emp1 = new Employee
            {
                Id = 1,
                FirstName ="John",
                LastName = "Doe"
        };

        // Instantiate the second Employee object and set its properties
        Employee emp2 = new Employee
        {
            Id = 2,
            FirstName = "Jane",
            LastName = "Smith"
};

    // Compare the two Employee objects using the overloaded &#39;==&#39; operator
    bool areEqual = emp1 == emp2;

    // Print the result of the comparison to the console
    Console.WriteLine("Are the two employees equal?" + areEqual);

// Compare the two Employee objects using the overloaded &#39;!=&#39; operator
bool areNotEqual = emp1 != emp2;

    // Print the result of the comparison to the console
    Console.WriteLine("Are the two employees not equal?" + areNotEqual);

// Keep the console window open until a key is pressed
Console.ReadKey();
}
}
}