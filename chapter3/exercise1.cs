using System;

class example2_2
	{
		static void Main(string[] args)
			
			// tuotteiden lukumäärät puuttuivat kokonaan tehtävänannosta, jonka keksin omat
			// taulukon voi luoda joko näin;
			{
			decimal [] tuoteHinta = new decimal[3];
			tuoteHinta[0]=3.98m;
			tuoteHinta[1]=36.0m;
			tuoteHinta[2]=19.98m;
			// tai lyhyemmin;
			int[] tuoteLkm = new int[3] {2,2,5};
			
			decimal [] tuoteYhtHinta = new decimal[3] {tuoteHinta[0]*tuoteLkm[0], tuoteHinta[1]*tuoteLkm[1], tuoteHinta[2]*tuoteLkm[2]};
			
			Console.WriteLine("Tuote1: "+tuoteYhtHinta[0]);
			Console.WriteLine("Tuote2: "+tuoteYhtHinta[1]);
			Console.WriteLine("Tuote3: "+tuoteYhtHinta[2]);
		}
}