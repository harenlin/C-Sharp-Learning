using System;

class HelloWorld {
	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("TryParse");
		Console.WriteLine("======================================");

		Console.WriteLine("Enter a number:");
		string inputNum = Console.ReadLine();
		int num = 0;

		bool parseSuccess = int.TryParse(inputNum, out num);
		if( parseSuccess ){
			Console.WriteLine("Parsed number: " + num);
		} else {
			Console.WriteLine("Fail to parse!");
		}
	}
}
