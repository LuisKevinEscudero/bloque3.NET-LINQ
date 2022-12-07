/*Write a query that returns letters and their frequencies in the string.
Expected input and output
"gamma" → "Letter g occurs 1 time(s), 
Letter a occurs 2 time(s), Letter m occurs 2 time(s)"*/

namespace FrecuencyOfLetters
{
	public class Program
	{
		static void Main(string[] args)
		{
			string word = "abracadabra";

			var query = from w in word
						group w by w into grup
						select grup;

			foreach (var item in query)
			{
				Console.WriteLine("Letter {0} occurs {1} time(s)", item.Key, item.Count());
			}

		}
	}
}