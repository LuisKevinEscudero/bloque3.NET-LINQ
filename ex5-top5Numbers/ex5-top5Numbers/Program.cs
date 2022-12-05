/*Write a query that returns top 5 numbers from the list of integers in descending order.
Expected input and output
[78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21*/

namespace Top5Numbers
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> { 6, 0, 999, 11, 443, 6, 1, 24, 54 };
			
			numbers.Sort();
			var query = (from number in numbers
						orderby number descending
						select number).Take(5);

			foreach (var item in query)
			{
				Console.WriteLine(item);
			}
		}
	}
}