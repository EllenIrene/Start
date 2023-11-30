using System;

namespace Start
{
	internal class Registrer
	{
		public void Run()
		{
			string navn = AskForName();
			string adresse = AskForAddress();
			string telefonnummer = AskForPhoneNumber();
			string profil = AskForProfileName();

			WelcomeMessage(navn);
			Console.WriteLine($"Takk, du er nå ferdig registrert hos oss med følgende opplysninger: \n Navn: {navn} \n Bosted: {adresse} \n Telefonnummer: {telefonnummer} \n Velkommen som bruker hos oss! ");
			Console.WriteLine($" Ditt profilnavn er satt til: \n {profil}");
		}

		static string AskForName()
		{
			Console.WriteLine("Hei! Her kan du registrere deg.\n Vennligst fyll inn ditt for- og etternavn: ");
			return Console.ReadLine();
		}

		static string AskForAddress()
		{
			Console.WriteLine("Hvilken by er din folkeregistrerte adresse i? ");
			return Console.ReadLine();
		}

		static string AskForPhoneNumber()
		{
			Console.WriteLine(" Hva er ditt private telefonnummer?:");
			return Console.ReadLine();
		}

		static string AskForProfileName()
		{
			Console.WriteLine("For å gå videre, må du nå lage deg ett profilnav; ");
			return Console.ReadLine();
		}

		static void WelcomeMessage(string name)
		{
			Console.WriteLine($"Så hyggelig du velger å registrere deg hos oss {name}! \n Vennligst fyll inn registreringen som trengs:");
		}
	}
}