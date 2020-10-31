/*Kirjoita C#-kielellä ohjelma, joka pyytää ja lukee ylärajan ja tulostaa alkuluvut (prime numbers), jotka ovat sitä pienempiä tai yhtä suuri kuin se itse. Vihje: alkuluku on positiivinen kokonaisluku, joka on jaollinen vain ykkösellä ja itsellään.*/

using System;  
  class example4_6
   {  
     static void Main(string[] args)  
	{
	
		Console.WriteLine("Anna yläraja:");
		int ylaraja=int.Parse(Console.ReadLine());
   		
		for (int x = 2; x < ylaraja; x++){
        int alkuluku = 0;
        for (int y = 1; y < x; y++)
        {
            if (x % y == 0)
                alkuluku++;

            if(alkuluku == 2) break;
        }
        if(alkuluku != 2)
           Console.WriteLine(x);

        alkuluku = 0;
    
			}
		 }
  }