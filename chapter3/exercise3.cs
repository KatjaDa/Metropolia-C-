/*Kirjoita C#-kielellä ohjelma, joka pyytää ja lukee kaksi kokonaislukua näppäimistöltä ja tulostaa niiden jakojäännöksen näytölle.

Anna luvuiksi 3 ja 6.*/
using System;

class example3_3
{
	static void Main(string[] args) 
	{
		
			Console.WriteLine("Anna kaksi kokonaislukua:");
		    var lukuYksi = int.Parse(Console.ReadLine());
			var lukuKaksi = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Lukujen jakojäännös on: "+(lukuYksi%lukuKaksi));
			
	}
}