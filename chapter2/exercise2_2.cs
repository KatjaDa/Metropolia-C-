using System;

class example2_2
	{
		static void Main(string[] args)
			{
			string [] nimi = new string[3];
			nimi[0]="MacBook Air";
			nimi[1]="Jolla";
			nimi[2]="Nokia";
			
			string[] hinnat = new string[3];
			hinnat[0] = "928,90€";
			hinnat[1] = "349€";
			hinnat[2] = "99,80€";
			
			Console.WriteLine(nimi[0]+" "+hinnat[0]+"\n"+nimi[1]+" "+hinnat[1]+"\n"+nimi[2]+" "+hinnat[2]);
		}
}