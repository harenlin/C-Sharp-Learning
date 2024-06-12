using System;
using System.Collections.Generic;

public class HttpCookie
{
	private readonly Dictionary<string, string> _dictionary;
	public DateTime Expiry { get; set; }

	public HttpCookie()
	{
		_dictionary = new Dictionary<string, string>();
	}

	/* public void SetItem(string key, string value)
	{

	}

	public string GetItem(string key)
	{

	} */

	public string this[string key]
	{
		get { return _dictionary[key]; }
		set { _dictionary[key] = value; }
	}

	public void DisplayCookie()
	{
		Console.WriteLine("Cookie Details: ");
		foreach (KeyValuePair<string, string> entry in this._dictionary)
		{
		    Console.WriteLine("({0}, {1})", entry.Key, entry.Value);
		}
	}
}
