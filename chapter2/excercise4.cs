using System;

class example2_3 
{
	public static void Main(string[] args)
	{
		char hexa = '\x5eb3';
		int luku = Convert.ToInt32(hexa);
		
		Console.WriteLine(luku);
	}
}