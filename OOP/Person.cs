using System;

public class Person
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    protected DateTime _dateOfBirth { get; private set; }
	// C# Coding Convention: the private variable should have a underline prefix.
    
    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this._dateOfBirth = dateOfBirth;
    }

    public DateTime getDateOfBirth(){
		return this._dateOfBirth;
	} 
    
    public string GetFullName()
    {
        return $"{firstName} {lastName}";
    }
}
