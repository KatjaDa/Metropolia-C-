/*Kirjoita C#-kielellä ohjelma, jossa määrittelet Kirja-luokan. Kirja-luokan kentät ovat nimi, kirjailija, kustantaja, hinta sekä teemanNimi. Määrittele luokalle sopivat muodostimet sekä HaeKirja()- ja VaihdaTeema()-metodit. HaeKirja()-metodi saa parametrina nimen ja vertaile sitä kirjan nimeen. Metodin tulee tulostaa kirjan loput tiedot jos parametrin ja kirjan nimi ovat samat ja muussa tapauksessa ilmoittaa, että kirjaa ei löytynyt. VaihdaTeema() on staattinen metodi, jolla muutat teeman nimeä. Luo Main()-metodissa muutama olio luokasta ja kutsu HaeKirja()- ja VaihdaTeema()-metodit.
Ohje: osa ohjelmakoodista on annettu, täydennä ohjelma vain puuttuvilta osin. */

using System;
class Kirja
{
    string Nimi;
    string Kirjoittaja;
    string Kustantaja;
	string Teema;
	float Hinta;
	

    public Kirja(string nimi, string kirjoittaja, string kustantaja, float hinta, string teema)
    {
        this.Nimi = nimi;
        this.Kirjoittaja = kirjoittaja;
        this.Kustantaja = kustantaja;
        this.Hinta = hinta;
        this.Teema = teema;
    }
	

    public void HaeKirja(string nimi)
    {
        if (nimi.Equals(this.Nimi))
        {
            Console.WriteLine(Nimi + ", " + Kirjoittaja + ", " + Kustantaja + ", " + Teema + ", " + Hinta);
        }
        else
        {
            Console.WriteLine("kirjaa ei löydy " + nimi);
        }
    }

    public static void VaihdaTeema(Kirja k, string teema)
    {
        k.Teema = teema;
    }

     static void Main(string[]args)
    {
        Kirja k = new Kirja("Kirja","K. Kirjoittaja", 528, 21.50f, "Dekkari");
        Kirja k2 = new Kirja("Kirja2","K. Kirjoittaja", 347, 36.90f, "Fantasia");
        k.HaeKirja(k.Nimi);
        VaihdaTeema(k2, "Jännitys");
        k2.HaeKirja(k2.Nimi);
    }
}