using System;

class Struct {

	struct Person {
		public string name;
		public int age;
		
		public Person(string name, int age){
			this.name = name;
			this.age = age;
		}
	}

	static void createPerson(string name, int age, ref Person person){
		person.name = name;
		person.age = age;
	}

	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("Structure");
		Console.WriteLine("======================================");

		Console.Write("Enter your name: ");
		string input_name = Console.ReadLine();
		Console.Write("Enter your age: ");
		int input_age = Convert.ToInt32(Console.ReadLine());
		
		Person person1 = new Person();
		createPerson(input_name, input_age, ref person1);
		Console.WriteLine($"{person1.name} - {person1.age}");

		Console.WriteLine("======================================");

		Console.Write("Enter your name: ");
		input_name = Console.ReadLine();
		Console.Write("Enter your age: ");
		input_age = Convert.ToInt32(Console.ReadLine());
		
		Person person2 = new Person(input_name, input_age);
		Console.WriteLine($"{person2.name} - {person2.age}");
		
	}
}
