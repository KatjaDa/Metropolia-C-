/*Kehitä edellistä ohjelmaa siten, että määrittelet liittymän IAsiakas, johon kuuluu metodit HaeAsiakas() ja LaskeBonus(). Määrittele myös luokka Asiakas, johon kuuluu attribuutit asiakkaan nimi ja ostokset, joka toteuttaa liittymän IAsiakas. Määrittele luokalle muodostin ja ToString()-metodi sekä toteuta liittymän IAsiakas metodit. Toteuta metodi HaeAsiakas() siten, että se saa argumenttina asiakkaan nimen, vertaa sitä kutsuvan olion asiakkaan nimeen ja vertaustuloksen perusteella palauttaa joko kutsuvan olion tai null-arvon. Toteuta metodi LaskeBonus() siten, että se laskee asiakkaan bonuksen sen ostosten perusteella seuraavasti: jos ostokset ovat korkeintaan 1000 €, bonus on 2 %, jos ostokset ovat 1000 ja 2000 euron välillä, bonus on 3 % ja muussa tapauksessa bonus on 5 % kokonaisostoksista. Luo ohjelman Main()-metodissa kolmen alkion taulukko, joka on tyyppiä Asiakas. Alusta taulukko Asiakas-olioilla ja kutsu taulukon alkioiden metodi HaeAsiakas() ja LaskeBonus().

Anna taulukolle seuraavat Asiakkaat: Jari, 300 | Teppo, 3900 | Johanna, 2200.

 

Ohje: osa ohjelmakoodista on annettu, täydennä ohjelma vain puuttuvilta osin. */

using System;

public interface IAsiakas
{
    Asiakas HaeAsiakas(string nimi, Asiakas a);
    double LaskeBonus();
}

public class Asiakas : IAsiakas
{
    public string nimi;
    public double ostokset;


    public Asiakas(string nimi, double ostokset)
    {
        this.nimi = nimi;
        this.ostokset = ostokset;
    }

    public override string ToString()
    {
        return nimi+", "+ostokset;
    }

    public Asiakas HaeAsiakas(string nimi, Asiakas asiakas)
    {
		
        if (string.Equals(asiakas.nimi, nimi))
        {
            return asiakas;
        }
        else
        {
            return null;
        }
    }

    public double LaskeBonus()
    {
	if (this.ostokset <= 1000) {
        return this.ostokset *0.02;
    } else if (this.ostokset>=1000 && this.ostokset<=2000) {
	return this.ostokset * 0.03;
	} else {
	return this.ostokset *0.05;
	
}
}
}

class Ohjelma {
    static void Main (string[] args) {
        Asiakas[] asiakkaat = new Asiakas[3];
        asiakkaat[0] = new Asiakas("Jari", 300);
        asiakkaat[1] = new Asiakas("Teppo", 3900);
        asiakkaat[2] = new Asiakas("Johanna", 2200);

        for(int i =0; i<asiakkaat.Length; i++) {
            Console.WriteLine(asiakkaat[i].HaeAsiakas("Teppo", asiakkaat[i]));
            Console.WriteLine(asiakkaat[i].LaskeBonus);
        }
    
    }
}