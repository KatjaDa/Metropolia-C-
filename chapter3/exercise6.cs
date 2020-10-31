/*Kirjoita C#-kielellä ohjelma, jossa määrittelet merkkijono (string)-tyyppisen muuttujan ja desimaaliluvun. Ohjelman pitää pyytää ja lukea opiskelijan
arvosana näppäimistöltä. Tämän jälkeen sen tulee käyttämällä ?-operaattoria alustaa merkkijono-muuttuja
siten, että jos arvosana on alle 4, sen arvoksi tulee "Opiskelija jää luokalle." ja muussa tapauksessa "Opiskelija pääsee luokalta!".
Lopussa ohjelman tulee tulostaa näytölle arvosana ja merkkijono.*/

using System;

class example3_6
{
	static void Main(string[] args) 
	{
		
			Console.WriteLine("Anna arvosana:");
		    var lukuYksi = int.Parse(Console.ReadLine());	
			// jos lukuYksi on pienempi kuin 4, tulee vastaukseksi ? ensimmäinen vastaus, muutoin tulee : jälkeinen vastaus
			Console.WriteLine(lukuYksi < 4 ? lukuYksi+" Opiskelija jää luokalle" : lukuYksi+" Opiskelija pääsee luokalta!" );
	
	}
}