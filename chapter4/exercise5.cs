/*Kirjoita C#-kielellä ohjelma, joka pyytää ja lukee reaalilukuja näppäimistöltä, laskee ne yhteen ja näyttää niiden reaaliaikaisen summan samalla, kun se pyytää seuraavaa lukua. Ohjelman pitää jatkaa näin niin kauan kuin lukujen yhteissumma on korkeintaan 100. Jos lukujen yhteissumma ylittää 100, ohjelman tulee ilmoittaa, että raja on saavutettu ja se lopettaa toiminnan*/

using System;

class example4_5
{
    
    static void Main(string[] args)
    {
		int summa = 0;
		while (summa < 101) {
			Console.WriteLine("Anna luku:");
			summa+=int.Parse(Console.ReadLine());
			Console.WriteLine(summa);
			if (summa > 100 ) {
				Console.WriteLine("Raja saavutettu.");
				break;
			}
		}

    }
}