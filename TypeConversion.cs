using System;

class HelloWorld {
	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("Data Types Conversion");
		Console.WriteLine("======================================");

        Console.WriteLine("--------Integer (int) Type--------");
        string textAge = "25";
        int age        = Convert.ToInt32(textAge);
        Console.WriteLine(age);
		
        Console.WriteLine("--------Long Integer (long) Type--------");
		string textBigNumber = "-900000000";
        long bigNumber       = (long)Convert.ToDouble(textBigNumber);
        Console.WriteLine(bigNumber);

		Console.WriteLine("--------Double (double) Type--------");
		string textDoubleNumber = "-34.5";
		double doubleNumber     = Convert.ToDouble(textDoubleNumber);
        Console.WriteLine(doubleNumber);

		Console.WriteLine("--------Float (float) Type--------");
		string textFloatNumber = "5.0001";
		float floatNumber      = Convert.ToSingle(textFloatNumber);
        Console.WriteLine(floatNumber);

		Console.WriteLine("======================================");
		// Type conversion
		string num_str = "15";
		int n1 = int.Parse(num_str);
        int n2 = Convert.ToInt32(num_str);
		// Convert:
		// ToByte(), ToInt16(), ToInt32(), ToInt64()
        Console.WriteLine("Converted result: n1 = {0}, n2 = {1}.", n1, n2);
	}
}
