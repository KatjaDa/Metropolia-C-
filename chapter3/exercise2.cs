/*
Kirjoita C#-kielellä ohjelma, joka pyytää ja lukee kaksi numeroa näppäimistöltä. Tämän jälkeen ohjelman pitää suorittaa perusaritmeettiset operaatiot (yhteen-, vähennys-, kerto- ja jakolasku) luvuilla ja tulostaa näytölle jokaisen operaation tulos. Ohjelman pitää tulostaa kaikki luvut kahden desimaalin tarkkuudella. Esimerkiksi jos syötetyt luvut ovat 3,456 ja 1,230, ohjelman pitää tulostaa tulokset, kuten seuraavassa:
3,46 + 1,23 = 4,69
3,46 - 1,23 = 2,23
Anna ohjelmalle luvut 2 ja 5.*/

using System;

class example3_2
{
	static void Main(string[] args) 
	{
		
			Console.WriteLine("Anna kaksi lukua:");
		    var lukuYksi = double.Parse(Console.ReadLine());
			var lukuKaksi = double.Parse(Console.ReadLine());
			
			Console.WriteLine(lukuYksi+ " + "+lukuKaksi+" = "+(lukuYksi+lukuKaksi));
			Console.WriteLine(lukuYksi+ " - "+lukuKaksi+" = "+(lukuYksi-lukuKaksi));
			Console.WriteLine(lukuYksi+ " * "+lukuKaksi+" = "+(lukuYksi*lukuKaksi));
			Console.WriteLine(lukuYksi+ " / "+lukuKaksi+" = "+(lukuYksi/lukuKaksi));
			
	}
}