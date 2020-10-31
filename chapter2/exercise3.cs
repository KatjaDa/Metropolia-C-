using System;

  class example2_3

{
	  // luodaan vakioluettelo
    enum vuodenajat{ kevät = 1, kesä = 2, syksy = 3, talvi = 4 };

    static void Main(string[] args)
    {
		
		// tulostetaan vuodenajat vakioluettelon syksyn ARVO(3), jolloin kirjataan int eteen. Mikäli tässä olisi vain vuodenajat.syksy
		//tulostuu konsolille syksy eikä syksyn int arvo.
		Console.WriteLine((int)vuodenajat.syksy);
    }
}