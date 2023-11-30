using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
	internal class HvorGammelErDU
	{
		int number = 5;
		int number2 = 1;
		bool isEqual = false;

		public void Run()
		{
			Console.WriteLine("Hei, hva heter du?");
			var name = Console.ReadLine();

			Console.WriteLine($"Hei, {name}! \n I hvilket år er du født?");

			var birthYear = int.Parse(Console.ReadLine());
			var age = DateTime.Now.Year - birthYear;

			Console.WriteLine("Har du hatt bursdag i år? (j/n)");

			string hadBirthInput = Console.ReadLine();
			bool hadBirth = hadBirthInput.ToLower() == "j";

			if (age > 0 && hadBirth)
			{
				age = age;
			}
			else
			{
				age--;
			}


			Console.WriteLine($"Da er du {age} år gammel.");
		}
	}
}