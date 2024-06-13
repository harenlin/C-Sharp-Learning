using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public static class ExtentionMethods {
	// "Extension Method" should be "static"
	public static string Shorten(this String str, int numberOfWords) {
		if (numberOfWords < 0)
			throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0.");

		if (numberOfWords == 0)
			return "";

		var words = str.Split(' ');

		if (words.Length <= numberOfWords)
			return str;

		return string.Join(" ", words.Take(numberOfWords)) + "...";
	}

	static void Main(string[] args) {
		string post = "This is supposed to be a very long blog post blah blah blah...";
		var shortenedPost = post.Shorten(5);
		Console.WriteLine("Shorten Output: {0}", shortenedPost);
	}
}
