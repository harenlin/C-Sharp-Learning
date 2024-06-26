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

		string input_name = "";
		while(true){
			Console.Write("Enter your name: ");
			input_name = Console.ReadLine();
			if( string.IsNullOrEmpty(input_name) ){
				Console.WriteLine("Invalid Input! Please type again!");
			} else {
				break;
			}
		}
			
		int input_age = -1;
		while(true){
			Console.Write("Enter your age: ");
			try {
				input_age = Convert.ToInt32(Console.ReadLine());
				break;
			} catch (System.Exception e) {
				Console.WriteLine($"{e.Message} --- Please type again!");
			}
		}
		
		Person person1 = new Person(input_name, input_age);
		// Console.WriteLine($"{person1.name} - {person1.age}");
		person1.selfIntro();
	}
}
