// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
using System;
using System.Collections.Generic;

public class Program
{
	public static void Main(string[] args)
	{
		//Console.WriteLine ("Hello Mono World");
		PrintDuplicateChars("Hello Mono World whatsup?");
	}

	public static void PrintDuplicateChars(string input)
	{
		if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
		{
			return;
		}

		input = input.ToLower().Replace(" ", "");
		List<char> alreadyCounted = new List<char>();
		
		foreach (var x in input)
		{
			if (!alreadyCounted.Contains(x))
			{
				var splits = input.Split(x);
				if (splits.Length > 2)
				{
					Console.WriteLine($"{x}={splits.Length - 1}");					
				}

				alreadyCounted.Add(x);
			}
		}
	}
}
