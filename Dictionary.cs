using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary {

	static void printDict(Dictionary<int, string> dict){
		/* 
		   for(int idx = 0; idx < dict.Count; idx++){
		   KeyValuePair<int, string> pair = dict.ElementAt(idx);
		   Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
		   } 
		 */
		foreach (KeyValuePair<int, string> pair in dict) {
			Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
		}
	}

	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("Dictionary");
		Console.WriteLine("======================================");

		Dictionary<int, string> dict = new Dictionary<int, string> {
			// KeyValuePair
			{1, "Haren"},
			{2, "Eric"},
			{3, "Hank"}
		};

		Console.WriteLine("Initial Dictionary: ");
		printDict(dict);

		// Add something into the dictionary
		dict[4] = "M3";
		if ( !dict.ContainsKey(5) ) {
			dict.Add(5, "Michael");
		} else {
			Console.WriteLine("Key already exists. Consider updating the value instead.");
		}

		Console.WriteLine("The Dictionary After Adding Pairs: ");
		printDict(dict);

			
		string name_1st = "";
		if ( dict.TryGetValue(1, out name_1st) ){
			Console.WriteLine("The 1st handsome young man: {0}!", name_1st);
		} else {
			Console.WriteLine("Not Found");
		}
	}
}
