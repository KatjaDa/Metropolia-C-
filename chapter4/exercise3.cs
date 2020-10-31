/*Kirjoita C#-kielellä ohjelma, joka tulostaa näytölle 20 lukua seuraavasta sarjasta. Vihje: lukuun ottamatta ensimmäistä lukua, jokainen luku on itseään edeltävien lukujen summa. Ensimmäisen luvun perusteella voit laskea kaikki muut luvut.*/

using System;

class example4_3
{
    
    static void Main(string[] args)
    {
	int summa = 1;
	Console.WriteLine(summa);
		
		for(int i= 0; i < 20;)
		{
			Console.WriteLine(summa);
			summa+=summa;
			i++;
		}
    }
}