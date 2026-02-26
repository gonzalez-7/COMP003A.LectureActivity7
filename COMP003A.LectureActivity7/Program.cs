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
		}
	}
}
