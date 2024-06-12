// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
		var person = new Person("Hao-Lun", "Lin", new DateTime(1999, 5, 30));
		Console.WriteLine(person.GetFullName());

        Customer customer = new Customer("Haren", "Lin", new DateTime(1999, 5, 30), "R10944020", "haren.lin@csie.ntu.edu.tw");
        customer.DisplayCustomerInfo();
    }
}

