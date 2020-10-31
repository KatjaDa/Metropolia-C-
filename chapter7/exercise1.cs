/*Kirjoita C#-kielellä ohjelma, jossa määrittelet KulkuValine-luokan, johon kuuluvat seuraavat protected-kentät: tyyppi, merkki, vuosiMalli ja hinta. Määrittele luokalle sopivat muodostimet sekä virtuaali TulostaTiedot()-metodi, joka tulostaa näytölle KulkuValine-olion tiedot. Määrittele myös Auto-luokka, joka perii KulkuValine-luokan. Auto-luokan protected-kentät tulee olla koneenKoko, malli ja ovienLkm. Määritelle Auto-luokalle myös omat muodostimet sekä ylikirjoita TulostaTiedot()-metodi siten, että se tulostaa auton tiedot. 
Ohje: osa ohjelmakoodista on annettu, täydennä ohjelma vain puuttuvilta osin. */

using System;

class KulkuValine
{
	protected string tyyppi;
	protected string merkki;
	protected int vuosiMalli;
	protected float hinta;

public KulkuValine () {
}
	
public KulkuValine(string tyyppi, string merkki, int vuosiMalli, float hinta) {
	this.tyyppi = tyyppi;
	this.merkki = merkki;
	this.vuosiMalli = vuosiMalli;
	this.hinta = hinta;
}

	public virtual void TulostaTiedot() {
		Console.WriteLine(tyyppi+", "+merkki+", "+vuosiMalli+", "+hinta);
	}
}

class Auto : KulkuValine {
	protected int koneenKoko;
	protected string malli;
	protected int ovienLkm;
	
	public Auto (string tyyppi, string merkki, int vuosiMalli, float hinta, int koneenKoko, string malli, int ovienLkm) {
		this.tyyppi = tyyppi;
		this.merkki = merkki;
		this.vuosiMalli = vuosiMalli;
		this.hinta = hinta;
		this.koneenKoko = koneenKoko;
		this.malli = malli;
		this.ovienLkm = ovienLkm;
		}
	
	public override void TulostaTiedot() {
		Console.WriteLine(tyyppi+", "+merkki+", "+vuosiMalli+", "+hinta+", "+koneenKoko+", "+malli+", "+ovienLkm);
	}
}

class Ohjelma {
    static void Main (string[] args) {
        KulkuValine kv = new KulkuValine("auto", "Honda", 2014, 18190f);
        kv.TulostaTiedot();

        Auto a = new Auto("maasto", "Honda", 2014, 18190f, 143, "Civic", 4);
        a.TulostaTiedot();
    }
}