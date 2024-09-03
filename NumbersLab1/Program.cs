using System.Text.RegularExpressions;
namespace NumbersLab1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string myNumbers = "81575187k62387623593465387469";
			long totalSum = 0;

			while (true)
			{
				
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("To find matches enter a number from 1-9.\n(Type 'exit' to leave the applicaton)");
				Console.ResetColor();
				string userInput = Console.ReadLine();

				
				if (userInput.ToLower().Trim() == "exit")
				{
					Console.ForegroundColor = ConsoleColor.Red;
				    Console.WriteLine("GOODBYE");
					Console.ResetColor();
					break;
                }

				string regex = userInput;
				Match match1 = Regex.Match(myNumbers, regex);

				if (match1.Success)
				{
					int startMatch = match1.Index;

					Match match2 = Regex.Match(myNumbers.Substring(startMatch + 1), regex);

					if (match2.Success)
					{

						int endMatch = startMatch + match2.Index + match2.Length + 1;
						string matchedString = myNumbers.Substring(startMatch, endMatch - startMatch);

						totalSum += long.Parse(matchedString);

						Console.Write(myNumbers.Substring(0, startMatch));
						Console.ForegroundColor = ConsoleColor.Magenta;
						Console.Write(myNumbers.Substring(startMatch, endMatch - startMatch));
						Console.ResetColor();
						Console.WriteLine(myNumbers.Substring(endMatch));
						totalSum += long.Parse(matchedString);

					}
					else
					{
						Console.WriteLine(myNumbers);
					}
				}
				else 
				{
                    Console.WriteLine(myNumbers);
                }
				Console.ReadLine();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"Totalt = {totalSum}");


			}
			
		}
	}
}
