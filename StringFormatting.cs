using System;

class HelloWorld {
	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("String Formatting");
		Console.WriteLine("======================================");

		string name = "Haren";
		int age = 25;

		Console.WriteLine("Your name is " + name + ", your age is " + age);
		Console.WriteLine($"Your name is {name}, your age is {age}");
		Console.WriteLine("Your name is {0}, your age is {1}", name, age);
		Console.WriteLine(string.Concat("Your name is ", name, ", your age is ", age));
	}
}
