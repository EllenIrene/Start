namespace Start
{
	internal class Program
	{
		static void Main(string[] args)
		{
			{
				Console.WriteLine("OPPGAVER:");

				while (true)
				{
					Console.WriteLine("Velg hvilken oppgave du vil kjøre:\n");

					Console.WriteLine("1. If else");
					Console.WriteLine("2. Is equal");
					Console.WriteLine("3. Datatyper");
					Console.WriteLine("4. Hvor gammel er du?");
					Console.WriteLine("5. Random");
					Console.WriteLine("6. Registrer");
					Console.WriteLine("7. Void- Viser ikke hva som ligger i metoden");
					Console.WriteLine("8. Er de like? ");
					Console.WriteLine("9. Gjett ett tall mellom 1 og 100");

					Console.WriteLine("0. Avslutt");

					string valg = Console.ReadLine();

					switch (valg)
					{
						case "1":
							IfElse ifElse = new IfElse();
							ifElse.Run();
							break;

						case "2":
							Equal isEqual = new Equal();
							isEqual.Run();
							break;
						case "3":
							datatyper datatype = new datatyper();
							datatype.Run();
							break;

						case "4":
							HvorGammelErDU alder = new HvorGammelErDU();
							alder.Run();
							break;

						case "5":
							Randoms ran = new Randoms();
							ran.Run();
							break;
						case "6":
							Registrer skjema = new Registrer();
							skjema.Run();
							break;

						case "7":
							Voiding IkkePrint = new Voiding();
							IkkePrint.Run();
							break;
						case "8":
							ErLike ErdeLike = new ErLike();
							ErdeLike.Run();
							break;
						case "9":
							GjettTall gjett = new GjettTall();
							gjett.Run();
							break;

						case "0":
							return; // Avslutt programmet
						default:
							Console.WriteLine("Ugyldig valg. Prøv igjen.");
							break;
					}
				}
			}
		}
	}
}


