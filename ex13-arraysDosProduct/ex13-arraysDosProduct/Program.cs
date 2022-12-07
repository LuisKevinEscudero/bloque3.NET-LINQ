/*Write a query that returns dot product of two arrays.
Expected input and output
[1, 2, 3], [4, 5, 6] → 32
[7, -9, 3, -5], [9, 1, 0, -4] → 74*/

namespace ArraysDotProduct
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] array1 = new int[] { 5, 8, 2, 9 };
			int[] array2 = new int[] { 1, 7, 2, 4 };

			var query = (from a in array1
						join b in array2
						on Array.IndexOf(array1, a) equals Array.IndexOf(array2, b)
						 select a * b).Sum();

			Console.WriteLine(query);

		}
	}
}