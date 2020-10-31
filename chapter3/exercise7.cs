/*Kirjoita C#-kielellä ohjelma, joka ensin pyytää ja lukee seuraavat binääriluvut näppäimistöltä: 11001101, 01010111.
Tämän jälkeen ohjelman tulee suorittaa bittikohtainen poissulkeva TAI (bitwise exclusive OR)-operaatio luvuilla
ja tulostaa tulokset näytölle.*/

using System;

class example3_7
{
	static void Main(string[] args) 
	{
		
			Console.WriteLine("Anna binääriluvut 11001101 sekä 01010111:");
			// binäärilukujen kanssa tulee käyttää convert.ToInt32 -> int.parse ei toimi 
		    var lukuYksi = Convert.ToInt32(Console.ReadLine(),2);
			var lukuKaksi = Convert.ToInt32(Console.ReadLine(),2);
			Console.WriteLine(lukuYksi^lukuKaksi);
	
	}
}