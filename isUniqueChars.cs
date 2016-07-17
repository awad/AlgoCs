using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(isUniqueChars("Hello"));
		Console.WriteLine(isUniqueChars("Helo"));
	}
	
	static bool isUniqueChars(String str)
	{
		bool[] char_set = new bool[128];
		foreach(char c in str)
		{
			if(char_set[c])
				return false;
			
			char_set[c] = true;
		}
		for(int i=0; i< 128; i++)
		{
			if(char_set[i])
				Console.WriteLine(i);
		}
		
		return true;
	}
		
}
