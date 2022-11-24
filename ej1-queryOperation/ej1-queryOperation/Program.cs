/*
Write a program in C# Sharp to shows how the three parts of a query operation execute. 
Go to the editor
Expected Output:
The numbers which produce the remainder 0 after divided by 2 are :
0 2 4 6 8 
 */

namespace MyNamespace
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			IEnumerable<int> result = from x in numbers
									  where x % 2 == 0
									  select x;

			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
		}
	}
}