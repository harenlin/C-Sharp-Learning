using System;

class ClassProperty {

	class Person {
		private string name;
		private int age;

		public Person(){
			this.name = "";
			this.age = -1;
		}
		
		public Person(string name, int age){
			this.name = name;
			this.age = age;
		}

		// class proterties
		/* public string Name
		{
			get 
			{
				return this.name;
			}
			set 
			{
				this.name = value;
			}
		} */
		public string Name { get => this.name; set => this.name = value; }

		/* public int Age
		{
			get 
			{
				return this.age;
			}
			set 
			{
				this.age = value;
			}
		} */
		public int Age { get => this.age; set => this.age = value; }

		public void selfIntro(){
			Console.WriteLine($"Hi everyone! My name is {this.name} and my lucky number is {this.age}!");
		}
	}

	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("Class Property");
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
		
		Person person1 = new Person();
		person1.Name = input_name;
		person1.Age = input_age;
		Console.WriteLine($"{person1.Name} - {person1.Age}");
	}
}
