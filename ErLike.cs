using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
	internal class ErLike
	{
		public void Run()
		{
		

		Console.Write("Skriv inn det første tallet: ");
		int num1 = Convert.ToInt32(Console.ReadLine());

		Console.Write("Skriv inn det andre tallet: ");
		int num2 = Convert.ToInt32(Console.ReadLine());

		bool areEqual = AreNumbersEqual(num1, num2);
		Console.WriteLine("Er tallene like? " + areEqual);
	}

	static bool AreNumbersEqual(int num1, int num2)
	{
		return num1 == num2;
	}
}
}
