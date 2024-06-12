// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("Haren", "Lin", new DateTime(1999, 5, 30), "R10944020", "haren.lin@csie.ntu.edu.tw");
        customer.DisplayCustomerInfo();
    }
}

