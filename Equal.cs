using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
	internal class Equal
	{
		public void Run()
		{
			Console.WriteLine("Du kjører IsEqual-klassen.");

			int tall1 = 1;
			int tall2 = 2;
			bool IsEqual = false;

			Equal isEqual = new Equal();  // Opprett en instans av Program-klassen
			Console.WriteLine($"Her er summen: {isEqual.ReturSum(tall1, tall2)}");
		}

		public int ReturSum(int number, int number2)
		{
			return number + number2;
		}
	}
}
