/*Write a query that shuffles sorted array.
Expected input and output
[1, 2, 3, 4, 5, 6, 7, 8, 9, 10] → [4, 9, 3, 5, 2, 10, 1, 6, 8, 7]
[38, 24, 8, 0, -1, -17, -33, -100] → [0, -100, -17, 38, 8, -1, 24, -33,]*/

using System.Security.Cryptography;

namespace SuffleAnArray
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			//numero aleatorio
			var rng = new Random();

			var query = from num in numbers
						orderby rng.Next()
						select num;

			foreach (var item in query)
			{
				Console.WriteLine(item);
			}
		}
	}
}