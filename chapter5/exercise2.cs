/*

Kehitä edellisen tehtävän Kirja-luokkaa siten, että määrittelet luokalle toisen metodin, jonka parametrina on Kirja-olio. Metodin pitää verrata parametrina olevan olion kappalehintaa kutsuvan olion kappalehintaan ja tulostaa näytölle kumpi kirja on kalliimpi. Sellainen metodi voi näyttää
seuraavanlaiselta:


public void VertaileKirja(Kirja kirja)
{
    if(this.kappaleHinta > kirja.kappaleHinta)
    System.Console.WriteLine(this.kirjanNimi + " on kalliimpi  
    kuin " + kirja.kirjanNimi)
    ...
}

 

Ohje: osa ohjelmakoodista on annettu, täydennä ohjelma vain puuttuvilta osin. */

using System;

class Kirja
{
    string nimi;
    string kirjoittaja;
    int id;
    float hinta;



    public Kirja(string nimi, string kirjoittaja, int id, float hinta)
    {
        this.nimi = nimi;
        this.kirjoittaja = kirjoittaja;
        this.id = id;
        this.hinta = hinta;
    }

    public override string ToString()
    {
        return nimi + ", " + kirjoittaja + ", " + id + ", " + hinta;
        
    }
            public void VertaileKirja(Kirja kirja)
{ 
    if(this.hinta > kirja.hinta);
       System.Console.WriteLine(this.nimi + " on halvempi kuin " + kirja.nimi);
       }
    
}

class Ohjelma 
{
    static void Main(string[]args)
    {
        Kirja k = new Kirja("Kirja","K. Kirjoittaja", 528, 21.50f );
        Kirja k2 = new Kirja("Kirja2","K. Kirjoittaja", 347, 36.90f );
        k.VertaileKirja(k2);
    }
}
