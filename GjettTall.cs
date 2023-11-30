using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
	internal class GjettTall
	{

		public void Run()
		{
		

		Random hvasomhelst = new Random();
		int guessNumber = hvasomhelst.Next(1, 101);
		bool playAgain = true;

		Console.WriteLine("Gjett ett tall mellom 1 og 100");

		while (playAgain)
		{

			string input = Console.ReadLine();
			int guess = Convert.ToInt32(input);

			if (guess<guessNumber)
			{
				Console.WriteLine("Du tippet for lavt....." + guess);
			}

			else if (guess > guessNumber)
			{
				Console.WriteLine("Du tippet for høyt....." + guess);
			}

			else
			{
				Console.WriteLine(" Hurra! Du gjettet riktig! :-D");
				Console.WriteLine(" Vil du spille på nytt? Ja / Nei: ");
				string answer = Console.ReadLine();
				playAgain = answer.ToLower() == "ja";
			}

		}




		}
	}
}