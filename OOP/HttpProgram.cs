using System;

class HttpProgram
{
    static void Main(string[] args)
    {
		var cookie = new HttpCookie();
		cookie["name"] = "harenlin";
		cookie.DisplayCookie();
    }
}

