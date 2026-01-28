using System; // Gives access to basic C# functionality like Console

namespace InterfacePolymorphismDemo
{
    // STEP 1:
    // Create an interface called IQuittable
    // An interface defines a contract that any implementing class must follow
    interface IQuittable
    {
        // This method does not return anything (void)
        // Any class that implements this interface MUST define this method
        void Quit();
    }

    // STEP 2:
    // Create an Employee class that implements the IQuittable interface
    // The ":" syntax means Employee is inheriting from the interface
    class Employee : IQuittable
    {
        // Property to store the employee's first name
        public string FirstName { get; set; }

        // Property to store the employee's last name
        public string LastName { get; set; }

        // Implementing the Quit() method from the IQuittable interface
        // This method defines what happens when an employee quits
        public void Quit()
        {
            // Display a message to the console
            Console.WriteLine($"{FirstName} {LastName} has quit the company.");
        }
    }

    class Program
    {
        // Main method — entry point of the console application
        static void Main(string[] args)
        {
            // STEP 3:
            // Use polymorphism by creating an object of type IQuittable
            // Even though the object is of type Employee,
            // it can be stored as an interface type because Employee implements IQuittable
            IQuittable employee = new Employee()
            {
                // Assign values to the Employee properties
                FirstName = "John",
                LastName = "Doe"
            };

            // Call the Quit() method using the interface reference
            // Polymorphism allows this call even though we are using the interface type
            employee.Quit();

            // Keeps the console window open until the user presses a key
            Console.ReadLine();
        }
    }
}
