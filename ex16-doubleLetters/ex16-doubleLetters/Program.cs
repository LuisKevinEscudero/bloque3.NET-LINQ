/*Write a query that returns double letters sequence in format: AA AB AC ... ZX ZY ZZ
Expected input and output
(no input) → "AA AB AC ... AZ BA BB ... ZX ZY ZZ"*/

namespace DoubleLetters
{
	public class Program
	{
		static void Main(string[] args)
		{
			var query = from firstLetter in Enumerable.Range('A', 26)
						from secondLetter in Enumerable.Range('A', 26)
						select new string(new char[] { (char)firstLetter, (char)secondLetter });

			foreach (var item in query)
			{
				Console.WriteLine(item);
			}
		}
	}
}