using System;

class ToString {

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

		public string Name { get => this.name; set => this.name = value; }
		public int Age { get => this.age; set => this.age = value; }

		public void selfIntro(){
			Console.WriteLine($"Hi everyone! My name is {this.name} and my lucky number is {this.age}.");
		}

		public override string ToString(){
			return base.ToString() + " --- " + $"Name: {this.name} - Age: {this.age}.";
		}

		public override bool Equals(object obj){
			/*if(obj is Person){
				Person person = obj as Person;
				return this.Name.Equals(person.Name) && this.Age == person.Age;
			} return false; */
			try {
				Person person = obj as Person;
				return this.Name.Equals(person.Name) && this.Age == person.Age;
			} catch (System.Exception e) {
				Console.WriteLine($"{e.Message}");
				return false;
			}
		}

		public override int GetHashCode(){
        	unchecked // To avoid overflow warnings
	        {
    	        var hashCode = Name.GetHashCode();
        	    hashCode = (hashCode * 397) ^ Age;
            	return hashCode;
    	    }
	    }
	}

	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("ToString Override");
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
		Console.WriteLine(person1.ToString());

		Person person2 = new Person("Haren Lin", 25);
		Console.WriteLine(person1.Equals(person2));
	}
}
