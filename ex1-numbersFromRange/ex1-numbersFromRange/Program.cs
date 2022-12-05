/*Given an array of integers, write a query that 
 * returns list of numbers greater than 30 and less than 100.
Expected input and output
[67, 92, 153, 15] → 67, 92*/

namespace NumbersFromRange
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 67, 92, 153, 15 };
			var query = from num in numbers
						where num > 30 && num < 100
						select num;

			Console.WriteLine("The array numbers; ");
			Console.WriteLine(String.Join(", ", numbers));

			Console.WriteLine("Numbers greater than 30 and less than 100 are:");
			foreach (var num in query)
			{
				Console.WriteLine(num);
			}
		}
	}
}