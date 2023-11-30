using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start //Alle classer må ha Start her
{
	internal class IfElse // Her er navnet som det refereres til i hovedprogrammet
	{
		int number = 5;
		int number2 = 1;
		bool isEqual = false;

		public void Run()//Denne må alltid være med, for  kjøre det i hovedprogrammet
		{
			Console.WriteLine("Du kjører IfElse-klassen.");

			if (number == number2)
			{
				isEqual = true;
				Console.WriteLine("The numbers are equal");
			}
			else
			{
				isEqual = false;
				Console.WriteLine("The numbers are not equal");
			}

			if (isEqual)
			{
				number++;
			}
			else
			{
				number2--;
			}

			Console.WriteLine($"number: {number}, number2: {number2}");
		}
	}
}
