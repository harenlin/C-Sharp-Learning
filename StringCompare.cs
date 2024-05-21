using System;

class StringCompare {
	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("String Comparison");
		Console.WriteLine("======================================");

		Console.WriteLine("Type your name: ");
		string name1 = Console.ReadLine();
		Console.WriteLine("Type your name again: ");
		string name2 = Console.ReadLine();
		
		// if( !name1.Equals(name2) || name1.Equals("") || name2.Equals("") ){
		if( !name1.Equals(name2) || string.IsNullOrEmpty(name1) || string.IsNullOrEmpty(name2) ){
			Console.WriteLine("Name Inonsistent or Invalid input!");
		} else {
			Console.WriteLine("Name Consistent!");
		}

		Console.WriteLine("======================================");
		for(int i = 0; i < name1.Length; i++){
			Console.WriteLine(name1[i]);
		}

		// Check if contain the specific substring
		Console.WriteLine("Does the name1 string contain the substring \"ar\"?\n" + name1.Contains("ar"));

		// Check the character equality
		bool char_a_found = false;
		for(int i = 0; i < name1.Length; i++){
			if( name1[i].Equals('a') ) char_a_found = true;
		}
		Console.WriteLine("Does the name1 string contain the character \'a\'?\n" + char_a_found);
	}
}
