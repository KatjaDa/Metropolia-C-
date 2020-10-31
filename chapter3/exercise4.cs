/*Kirjoita C#-kielellä ohjelma, joka pyytää ja lukee kaksi lukua näppäimistöltä ja ilmoittaa lukujen
suhteet toisiinsa, eli onko ensimmäinen luku suurempi, yhtäsuuri vai pienempi kuin toinen luku.*/
using System;

class example3_4
{
	static void Main(string[] args) 
	{
		
			Console.WriteLine("Anna kaksi lukua:");
		    var lukuYksi = int.Parse(Console.ReadLine());
			var lukuKaksi = int.Parse(Console.ReadLine());
		
		
			if (lukuYksi == lukuKaksi) {
			Console.WriteLine(lukuYksi+" on yhtä suuri kuin "+lukuKaksi);
			}
			else if (lukuYksi > lukuKaksi) {
				Console.WriteLine(lukuYksi+" on suurempi kuin "+lukuKaksi);
			}
		
			else if (lukuYksi < lukuKaksi) {
				Console.WriteLine(lukuYksi+" on pienempi kuin "+lukuKaksi);
			}
			
	}
}