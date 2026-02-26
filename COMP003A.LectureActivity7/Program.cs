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
		}
	}
}
