/*Kehitä edellisen tehtävän ratkaisua siten, että Kirja-luokalle määrittelet Hinta-ominaisuuden. Määrättele Hinta-ominaisuudelle set-metodi siten, että sillä alustetaan hinta-kenttä ja jos sen saama arvo on yli 30, sitä vähennetään 10%:lla. Määrittele get-metodi siten, että se palauttaa hinta-kentän arvon. Vihje: set-metodissa voidaan käyttää if-lausetta, jossa value on vertailun kohde.
Ohje: osa ohjelmakoodista on annettu, täydennä ohjelma vain puuttuvilta osin. */

using System;
class Kirja
{
    string Nimi;
    string Kirjoittaja;
    string Kustantaja;
	string TeemanNimi;
	private float hinta;
	

    public Kirja(string nimi, string kirjoittaja, string kustantaja, float hinta, string teema)
    {
        this.Nimi = nimi;
        this.Kirjoittaja = kirjoittaja;
        this.Kustantaja = kustantaja;
        this.Hinta = hinta;
        this.TeemanNimi = teema;
    }
	

    public void HaeKirja(string nimi)
    {
        if (nimi.Equals(this.Nimi))
        {
            Console.WriteLine(Nimi + ", " + Kirjoittaja + ", " + Kustantaja + ", " + TeemanNimi + ", " + Hinta);
        }
        else
        {
            Console.WriteLine("kirjaa ei löydy " + nimi);
        }
    }

    public static void VaihdaTeema(Kirja k, string teema)
    {
        k.TeemanNimi = teema;
    }
	
      public float Hinta {
      get {return hinta;}
   	  set { hinta = value;
		  if (value > 30) {
         	hinta = value * 0.90f; }
		  else hinta=value;
     	 }
	 }

          static void Main(string[]args)
    {
        Kirja k = new Kirja("Kirja","K. Kirjoittaja", 528, 21.50f, "Dekkari");
        Kirja k2 = new Kirja("Kirja2","K. Kirjoittaja", 347, 36.90f, "Fantasia");
        Console.WriteLine(k.hinta);
        Console.WriteLine(k2.Hinta);
    }
}