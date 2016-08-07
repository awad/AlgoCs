using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		string input = "Hal";
		List<string> perm = new List<string>();
		GeneratePermutations("", input, perm);
		int c = 1;
		foreach(String s in perm)
		{
			Console.WriteLine(c++ +". " + s);
		}
		
	}
	
	public static void GeneratePermutations(String prefix, String input, List<string> perm)
	{
		if(input.Length == 0 ){
			//Console.WriteLine(prefix);
			perm.Add(prefix) ;
		}
		
			
			for(int i=0; i<input.Length; i++)
			{
				Console.WriteLine(i + "-->" + prefix +"-->" + input[i] + " before: " + input.Substring(0, i) + " after: " + input.Substring(i+1, input.Length-i-1));
				GeneratePermutations(prefix + input[i], input.Substring(0, i) + input.Substring(i+1, input.Length-i-1), perm);
			}
	}
}
