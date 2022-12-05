/*Write a query that returns list of numbers and their squares only if
 square is greater than 20
Expected input and output
[7, 2, 30] → 7 - 49, 30 - 900*/

namespace SquareGraterThan20
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> { 3, 9, 2, 4, 6, 5, 7 };

			var query= from number in numbers
					   where number*number > 20
					   select number;

			foreach (var item in query)
			{
				Console.WriteLine("{0} - {1}",item, item*item);
			}
		}
		
	}
}