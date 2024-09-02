using System.Text.RegularExpressions;
namespace NumbersLab1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string myNumbers = "81575187k62387623593465387469";

			while (true)
			{
				// Ask the user to type a number from 1-9 to find matches in my string & give the option to exit

				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("To find matches enter a number from 1-9.\n(Type 'exit' to leave the applicaton)");
				string userInput = Console.ReadLine();

				//break the loop if 'exit'
				if (userInput.ToLower().Trim() == "exit")
				{
                    Console.WriteLine("GOODBYE");
					break;
                }
				int userNumber = 0;

				else
				{

				}

			

			}
			
		}
	}
}
