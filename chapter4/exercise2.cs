/*Kirjoita C#-kielellä ohjelma, joka pyytää ja lukee viisi kokonaislukua näppäimistöltä, kirjoittaa ne sopivaan taulukkoon ja lopussa laskee niiden keskiarvon ja tulostaa sen näytölle. Käytä keskiarvon laskennassa foreach-lausetta*/

using System;

class example4_2
{
    
    static void Main(string[] args)
    {
        int [] lukutaulu = new int[5];
		Console.WriteLine("Anna viisi kokonaislukua:");
		lukutaulu[0] = int.Parse(Console.ReadLine());
		lukutaulu[1] = int.Parse(Console.ReadLine());
		lukutaulu[2] = int.Parse(Console.ReadLine());
		lukutaulu[3] = int.Parse(Console.ReadLine());
		lukutaulu[4] = int.Parse(Console.ReadLine());
		int summa = 0;
		
		foreach(var luku in lukutaulu) {
			summa+= luku;
		}

		Console.WriteLine("keskiarvo: "+(summa/lukutaulu.Length));
    }
}