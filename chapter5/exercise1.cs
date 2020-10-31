/*Ohjelma, jossa määrittelet Kirja-luokan. Luokan kentät ovat kirjan nimi, kirjoittajan nimi, id-numero sekä kappalehinta. Määrittele luokalle muodostimia sekä metodi, joka tulostaa kirjat tiedot näytölle. Luo pääohjelmassa olioita Kirja-luokasta ja kutsu metodi, joka tulostaa olioiden tiedot näytölle.*/


using System;

class Kirja
{
	
	public string nimi;
	public string kirjoittaja;
	public int idNumero;
	public double kplHinta;
	
public void kirjanTiedot() {
	Console.WriteLine(nimi+", "+kirjoittaja+", "+idNumero+", "+kplHinta);
	}
}

class example5_1 {
	static void Main(string[] args){
	Kirja kirja;
	
	kirja = new Kirja();
	kirja.nimi="Kirja";
	kirja.kirjoittaja="K.kirjoittaja";
	kirja.idNumero=528;
	kirja.kplHinta=21.5;

	kirja.kirjanTiedot();
		
	}
}