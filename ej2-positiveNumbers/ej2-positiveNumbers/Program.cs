/*
Write a program in C# Sharp to find the +ve numbers from a list 
of numbers using two where conditions in LINQ Query.
Expected Output:
The numbers within the range of 1 to 11 are :
1 3 6 9 10 
 */

namespace MyNamespace
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 1, -2, 3,- 4, -5, 6, -7,- 8, 9, 10, -11 };

			IEnumerable<int> positiveNumbers = from x in numbers
											   where x > 0
											   select x;

			foreach (var item in positiveNumbers)
			{
				Console.WriteLine(item);
			}
		}
	}
}