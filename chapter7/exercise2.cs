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
	/*muistiin: string.Format replaces one or more format items in a string with the string representation of a specified object.*/
	
	public override string ToString() {
		return string.Format(tyyppi+", "+merkki+", "+vuosiMalli+", "+hinta+", "+koneenKoko+", "+malli+", "+ovienLkm);
	}
}

class Ohjelma {
    static void Main (string[] args) {
        Auto a = new Auto("maasto", "Honda", 2014, 18190f, 143, "Civic", 4);
        Auto a = new Auto("farmari", "Skoda", 2014, 22990f, 151, "Civic", 4);
        Console.WriteLine(a.ToString()+"\n"+a2.ToString());
        Console.WriteLine(a.Equals(a2));
    }
}