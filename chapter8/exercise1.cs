/*Ohjelma, jossa määrittelet liittymän ITuote, johon kuuluu metodit HaeTuote() ja LaskeYhteisArvo(). Määrittele myös luokka Tuoe, johon kuuluu attribuutit tuotteen nimi, yksikköhinta sekä lukumäärä, ja toteuttaa liittymän ITuote. Määrittele luokalle muodostin ja ToString()-metodi sekä toteuta liittymän metodit. Toteuta metodi HaeTuote() siten, että se saa argumenttina tuotteen nimen, vertaa sitä kutsuvan olion tuotteen nimeen ja vertaustuloksen perusteella palauttaa joko kutsuvan olion tai null arvon. Toteuta metodi LaskeYhteisArvo() siten, että se palauttaa tuotteen kokonaisarvon kertomalla sen yksikköhinnan ja lukumäärän keskenään. Luo ohjelman Main()-metodissa kolmen alkion taulukko, joka on tyyppiä Tuote. Alusta taulukko Tuote-olioilla ja kutsu taulukon alkioiden metodit HaeTuote() ja LaskeYhteisArvo().

Ohje: osa ohjelmakoodista on annettu, täydennä ohjelma vain puuttuvilta osin. */

using System;

public interface Ituote {
	string HaeTuote(string name, Tuote tuote);
	float LaskeYhteisArvo();
}

public class Tuote : Ituote {
	string nimi;
	float yksikkohinta;
	int lukumaara;

public Tuote(string nimi, float yksikkohinta, int lukumaara) {
		this.nimi=nimi;
		this.yksikkohinta = yksikkohinta;
		this.lukumaara = lukumaara;
	}


public string HaeTuote(string Nimi, Tuote tuote) {
			return nimi == Nimi ? "Tuote" : "";
   
    }

public float LaskeYhteisArvo() {
	return lukumaara * yksikkohinta;
}

    public override string ToString(){
        return nimi + yksikkohinta + lukumaara;
    }
	
}

//annettu ohjelma
class Ohjelma {
    static void Main (string[] args) {
        Tuote[] tuotteet = new Tuote[3];
        tuotteet[0] = new Tuote("kynä", 1.4f, 300);
        tuotteet[1] = new Tuote("vihko", 2.3f, 425);
        tuotteet[2] = new Tuote("tabletti", 349f, 251);
        
        for(int i =0; i<tuotteet.Length; i++)
        {
            Console.WriteLine(tuotteet[i].HaeTuote("vihko", tuotteet[i]));
            Console.WriteLine(tuotteet[i].LaskeYhteisArvo);
        }
    }
}