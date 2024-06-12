using System;

public class Customer : Person {
    // Additional properties for the Customer class
    public string CustomerID { get; set; }
    public string Email { get; set; }

    // Constructor for the Customer class
    public Customer(string firstName, string lastName, DateTime dateOfBirth, string customerID, string email)
        : base(firstName, lastName, dateOfBirth)
    {
        CustomerID = customerID;
        Email = email;
    }
    
    // Additional method for the Customer class
    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer ID: {CustomerID}");
        Console.WriteLine($"Name: {GetFullName()}");
        Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Email: {Email}");
    }
}
