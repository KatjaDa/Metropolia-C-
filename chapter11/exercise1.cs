/*Ohjelma, joka jatkuvasti pyytää käyttäjältä kaksi kokonaislukua, jakaa ne keskenään ja tallentaa jakolaskun tuloksen taulukkoon, jossa on kolmelle alkiolle tilaa. Ohjelman tulee toimia hallitusti jos luvut ovat väärässä formaatissa, taulukossa ei ole enää tilaa tai sattuu nollalla jako. Vihje: Ohjelmassa tulee käsitellä seuraavat poikkeukset: FormatException, IndexOutOfRangeException sekä DivideByZeroException.
*/

using System;
using System.Collections;

class example11_1 {
	static void Main(string[] args) {
		
		int luku1, luku2;
		string jatka = "k";
		ArrayList taulukko = new ArrayList(3);
		
      try

      {
		while (jatka.Equals("k")){
		int tulos;
		
        Console.WriteLine("Anna kaksi kokonaislukua:");
		luku1 = int.Parse(Console.ReadLine());
        luku2 = int.Parse(Console.ReadLine());
		tulos = luku1/luku2;
		taulukko.Add(tulos);
		taulukko.Add(tulos);
		jatka="k";
		}

        }


      catch (Exception e) {
		  if(e.Message.Contains("Attempted to divide by zero")) {
		  Console.WriteLine("Yritit jakaa nollalla.");
		  }
		  else if (e.Message.Contains("Format Exception")) {
			  Console.WriteLine("Virhe:" +e.Message);
		  }
		  else if (e.Message.Contains("Index Out Of Range Exception")) {
			  Console.WriteLine("Virhe:" +e.Message);
		  }
		}

	}
	
}