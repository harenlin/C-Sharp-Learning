using System;

class NumericFormatting {
	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("Numeric Formatting");
		Console.WriteLine("======================================");

		double value = 1000D / 12.34D;
		Console.WriteLine(value);
		Console.WriteLine(string.Format("{0:0}", value));
		Console.WriteLine(string.Format("{0:0.0}", value));
		Console.WriteLine(string.Format("{0:0.00}", value));
	}
}
