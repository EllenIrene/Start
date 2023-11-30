using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
	internal class datatyper
	{
		public void Run()
		{
			int tall = 5;
			{
				Console.WriteLine(tall);
			}

			var desimalTall = 1.01F;
			{

				Console.WriteLine(desimalTall);
			}


			var tall2 = 0.02D;
			{

				Console.WriteLine(tall2);
			}


			var Tall3 = 3.0M;
			{

				Console.WriteLine(Tall3);
			}


			long Minus = -1;
			{

				Console.WriteLine(Minus);
			}


			char karakter = 'D';
			{

				Console.WriteLine(karakter);
			}


			string tekst = "Hei";
			{

				Console.WriteLine(tekst);
			}

			int[] Array = { 1, 2, 3 };// Hvordan få ut hele aeeay? Eller plukke ut for eks index 2
			{

				Console.WriteLine(2);
			}

			string[] tekst2 = { "Hei", "Hadet", "Den er grei" };// Hvordan få printet ut i 2 for eks?

			{

				Console.WriteLine(2);
			}

			bool santUsant = false;

			{

				Console.WriteLine(santUsant);
			}

			Console.WriteLine($"Tallet er: {desimalTall}");

		}
	}
}