using System.Collections.Generic;

namespace COMP003A.LectureActivity7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] scores = { 85, 90, 78, 02, 88 };

			Console.WriteLine("Array scores using for loop: ");

			for (int i = 0; i < scores.Length; i++)
			{
				Console.WriteLine(scores[i]);
			}

			

			List<string> names = new List<string>();
			names.Add("Alex");
			names.Add("Jordan");
			names.Add("Taylor");

			Console.WriteLine();
			Console.WriteLine("Names using foreach loop: ");

			foreach (string name in names)
			{
				Console.WriteLine(name);
			}

			

			Console.WriteLine();
			Console.WriteLine("Names using for loop: ");
			
			for (int i = 0; i < names.Count; i++)
			{
				Console.WriteLine(names[i]);
			}


			Console.WriteLine();
			Console.Write("Enter a number between 1 and 3: ");
			string input = Console.ReadLine();

			bool isAllDigits = true;

			if (input == null || input.Length == 0)
			{
				isAllDigits = false;
			}

			else
			{
				for (int i = 0; i < input.Length; i++)
				{
					if (input[i] < '0' || input[i] > '9')
					{
						isAllDigits = false;
					}
				}
			}

			if (isAllDigits)
			{
				int choice = int.Parse(input);

				if (choice >= 1 && choice <=3)
				{
					Console.WriteLine("Valid input! You entered: " + choice);
				}

				else
				{
					Console.WriteLine("Number is out of range. Please enter 1 to 3.");
				}
			}

			else
			{
				Console.WriteLine("Invalid input (not a number).");
			}

			Console.WriteLine();
			Console.WriteLine("try-catch test: ");

			try
			{
				int choice2 = int.Parse(input);
				Console.WriteLine("Converted number (try-catch): " + choice2);
			}

			catch (FormatException)
			{
				Console.WriteLine("Invalid number entered (Format Exception caught.)");
			}

			/* Reflection
			 * 1. It prevents errors before they happen
			 * 
			 * 2. Because user can type unexpected input like letters that can crash parsing
			 * 
			 * 3. It helped me by understand loop behavior by letting me watch the loop variable change each interaction
			 */
		}
	}
}
