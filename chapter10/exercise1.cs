/*Kirjoita C#-kielellä ohjelma, joka luo tiedoston rekisteri.txt. Tämän jälkeen ohjelman tulee pyytää kolmen työntekijän tietoja; id (int), nimi (string) ja palkka (float) ja kirjoittaa ne rekisteriin. Anna tiedostoon seuraavat tiedot:
id: 1 | nimi: Jari | palkka: 3500
id: 2 | nimi: Matti | palkka: 4800
id: 3 | nimi: Tuomas | palkka: 2100*/

//Tehtävä meni tällä läpi, ei ehkä ideaalein ratkaisu..

using System;
using System.IO;

class example10_1 {
	static void Main(string[]args) 
	{
		string tiedosto = "rekisteri.txt";
		File.Create(tiedosto);
	
		int[] id = new int[3];
		string[] nimi = new string[3];
		string[] palkka = new string[3];
	
	Console.WriteLine("Anna kolmen työntekijän tiedot (id, nimi, palkka):");
	for(int i = 0; i <3; i++){
		Console.WriteLine("Anna id:");
		id[i] = int.Parse(Console.ReadLine());
		Console.WriteLine("Anna nimi:");
		nimi[i] = Console.ReadLine();
		Console.WriteLine("Anna palkka:");
		nimi[i] = Console.ReadLine();
		}
	}
}