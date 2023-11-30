namespace Start
{
	internal class Randoms
	{
		 public void Run()
			//{
			//    System.Random rand = new System.Random();
			//    var randomNumber = rand.Next(0, 3);
			//    if (randomNumber == 0)
			//    {
			//        Console.WriteLine("Tallet ble 0");
			//    }
			//    else if (randomNumber == 1)
			//    {
			//        Console.WriteLine("Tallet ble 1");
			//    }
			//    else
			//    {
			//        Console.WriteLine("Tallet ble 2"); System.Random rand = new System.Random();
		{
			

			System.Random rand = new System.Random();
			var randomNumber = rand.Next(1, 1001);
			Console.WriteLine("Tallet blir " + randomNumber);
		}
	}
}

