using System;

public class Customer : Person {
    // Additional properties for the Customer class
    public string customerId { get; set; }
	public string email { get; set; }
	public readonly DateTime memberSince;

    // Constructor for the Customer class
    public Customer(string firstName, string lastName, DateTime dateOfBirth, string customerId, string email)
        : base(firstName, lastName, dateOfBirth)
    {
        this.customerId = customerId;
        this.email = email;
		this.memberSince = DateTime.Now;
    }
    
    // Additional method for the Customer class
    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer ID: {customerId}");
        Console.WriteLine($"Name: {GetFullName()}");
        // Console.WriteLine($"Date of Birth: {getDateOfBirth().ToShortDateString()}");
        Console.WriteLine($"Date of Birth: {this._dateOfBirth.ToShortDateString()}");
        Console.WriteLine($"email: {email}");
		Console.WriteLine($"memberSince: {memberSince}");
    }
}
