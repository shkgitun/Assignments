using System;

namespace EmployeeComparison
{
    // Define the Employee class
    public class Employee
    {
        // Auto-implemented properties for Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the &#39;==&#39; operator to compare two Employee objects by their Id property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both are null
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;
            // Check if one is null
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;
            // Compare Id properties
            return emp1.Id == emp2.Id;
        }

        // Overload the &#39;!=&#39; operator to compare two Employee objects by their Id property
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals() and GetHashCode() for good practice
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Employee emp = (Employee)obj;
            return Id == emp.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}