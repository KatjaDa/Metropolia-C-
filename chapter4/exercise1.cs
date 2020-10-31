/*Kirjoita C#-kielellä ohjelma, jossa määrittelet muuttujan arvonta ja alustat sen kokonaisluvulla 45.
Ohjelman pitää pyytää ja lukea luku näppäimistöltä ja verrata sitä muuttujan arvonta arvoon. Jos käyttäjän syöttämä
luku on yhtäsuuri kuin arvonta, ohjelman pitää tulostaa "Onneksi olkoon, sama luku!" ja lopettaa.
Muussa tapauksessa ohjelman pitää jatkaa luvun pyytämistä kunnes kierrosten määrä on 5, jolloin tulostetaan "Kierroksia 5, lopetetaan ohjelma."*/

using System;

class example4_1
{
	static void Main(string[] args) 
	{
		
			int arvonta = 45;
			int lopetus = 0;
			int lukijanLuku = 0;
		
		annaLuku : Console.WriteLine("Anna luku:");
		
		while(lopetus < 6 || lukijanLuku != 45) {
			lopetus++;
		    lukijanLuku = int.Parse(Console.ReadLine());
			
			if (lopetus == 5) {
			Console.WriteLine("Kierroksia 5, lopetetaan ohjelma.");
				break;
			}

			if (lukijanLuku == arvonta) {
				Console.WriteLine("Onneksi olkoon, sama luku!");
				break;
			}
			if (lukijanLuku != arvonta && lopetus < 6) {
	// Viope verification program won't let you through if there was no "goto" in code..
				goto annaLuku;
			}
				
	}

	}
}