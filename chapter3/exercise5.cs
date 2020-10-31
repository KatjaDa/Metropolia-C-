/*Kirjoita C#-kielellä ohjelma, joka pyytää ja lukee kokonaisluvun näppäimistöltä ja käyttämällä
?-operaattoria(ternary operator) tulostaa "Ei" jos luku on 0 ja "Jaa" muussa tapauksessa.*/

using System;

class example3_5
{
	static void Main(string[] args) 
	{
		
			Console.WriteLine("Anna kokonaisluku:");
		    var lukuYksi = int.Parse(Console.ReadLine());	
		
			Console.WriteLine(!(lukuYksi == 0) ? "Jaa" : "Ei" );
	
	}
}