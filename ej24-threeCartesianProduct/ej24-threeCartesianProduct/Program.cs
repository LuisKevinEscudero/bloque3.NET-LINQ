/*Write a program in C# Sharp to generate a cartesian product of three sets. 
Expected Output :
The cartesian product are :
{ letter = X, number = 1, colour = Green }
{ letter = X, number = 1, colour = Orange }
{ letter = X, number = 2, colour = Green }
{ letter = X, number = 2, colour = Orange }
{ letter = X, number = 3, colour = Green }
{ letter = X, number = 3, colour = Orange }
{ letter = Y, number = 1, colour = Green }
{ letter = Y, number = 1, colour = Orange }*/

namespace ThreeCartesianProduct
{
	public class Program
	{
		static void Main(string[] args)
		{
			char[] letters = { 'X', 'Y', 'Z' };
			int[] numbers = { 1, 2, 3 };
			string[] colors = { "Green", "Orange" };

			Console.Write("\nLINQ : Generate a cartesian product of three sets : ");
			Console.Write("\n----------------------------------------------------\n");

			IEnumerable<string> cartesianProduct = from letter in letters
												   from number in numbers
												   from color in colors
												   select letter + " " + number.ToString() + " " + color;

			Console.WriteLine("The cartesian product are : ");
			foreach (var item in cartesianProduct)
			{
				Console.WriteLine("letter = {0}, number = {1}, color = {2}", item[0], item[2], item.Substring(4));
			}
		}
	}
}