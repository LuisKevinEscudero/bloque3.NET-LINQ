/*Write a program in C# Sharp to generate a cartesian product of two sets.
Expected Output :
The cartesian product are :
{ letterList = X, numberList = 1 }
{ letterList = X, numberList = 2 }
{ letterList = X, numberList = 3 }
{ letterList = X, numberList = 4 }
. . .*/

namespace CantesianProduct
{
	public class Program
	{
		static void Main(string[] args)
		{
			char[] letters = { 'X', 'Y', 'Z' };
			int[] numbers = { 1, 2, 3, 4 };

			Console.Write("\nLINQ : Generate a cartesian product of two sets : ");
			Console.Write("\n------------------------------------------------\n");

			IEnumerable<string> cartesianProduct = from letter in letters
												   from number in numbers
												   select letter + number.ToString();

			Console.WriteLine("The cartesian product are : ");
			foreach (var item in cartesianProduct)
			{
				Console.WriteLine( " LetterList = {0}, numberList= {1} " , item[0], item[1]);
			}
		}
	}
}