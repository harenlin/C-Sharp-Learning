using System;

public class Person
{
    // Properties of the Person class
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    
    // Constructor for the Person class
    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
    
    // Method to get the full name
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}
