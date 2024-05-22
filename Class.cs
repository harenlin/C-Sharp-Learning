using System;

class Class {

	class Person {
		public string name;
		public int age;

		// default constructor
		public Person(){
			this.name = "";
			this.age = -1;
		}
		
		// constructor
		public Person(string name, int age){
			this.name = name;
			this.age = age;
		}

		public void selfIntro(){
			Console.WriteLine($"Hi everyone! My name is {this.name} and my lucky number is {this.age}!");
		}
	}

	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("Class");
		Console.WriteLine("======================================");

		Console.Write("Enter your name: ");
		string input_name = Console.ReadLine();
		Console.Write("Enter your age: ");
		int input_age = Convert.ToInt32(Console.ReadLine());
		
		Person person1 = new Person(input_name, input_age);
		// Console.WriteLine($"{person1.name} - {person1.age}");
		person1.selfIntro();
	}
}
