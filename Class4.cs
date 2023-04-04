using System;

public class Table
{
	public static void main(string[] args)
	{
		Console.WriteLine("Enter the number: ");
		int num = int.Parse(Console.ReadLine());
		for(int i = 1; i <= 10; i++)
		{
			int t = num * i;
			Console.WriteLine(num + "*" + i + "=" + t);
		}
	}
	
}
