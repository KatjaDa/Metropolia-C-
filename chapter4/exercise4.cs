/*Kirjoita C#-kielellä ohjelma, joka tulostaa näytölle 20 lukua seuraavasta sarjasta.
Vihje: lukuun ottamatta kahta ensimmäistä lukua, jokainen luku on itseään edeltävän kahden luvun summa. Kahden ensimmäisen luvun perusteella voit laskea kaikki muut luvut
1,1,2,3,5,8,13*/

using System;

class example4_4
{
    
    static void Main(string[] args)
    {
		int[] numero = new int[20];
		numero[0]=1;
		numero[1]=1;

		for(int i= 2; i < numero.Length;i++)
			numero[i] =numero[i-1]+numero[i-2];
		
		for(int i=0; i<numero.Length;i++)
			Console.WriteLine(numero[i]);

		
    }
}