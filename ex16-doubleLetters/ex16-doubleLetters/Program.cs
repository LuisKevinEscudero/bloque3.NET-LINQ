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

			var query2 = from firsLetter in Enumerable.Range('A', 26)
						 from secondLetter in Enumerable.Range('A', 26)
						 group new string(new char[] { (char)firsLetter, (char)secondLetter }) by firsLetter into g
						 select g;

			foreach (var item in query2)
			{
				Console.WriteLine(item.Key);
			}
		}
	}
}