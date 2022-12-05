/*Write a query that replaces 'ea' substring with astersik (*) in given list of words.
Expected input and output
"learn", "current", "deal" →  "l*rn", "current", "d*l"*/

namespace ReplaceSubstring
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<string> words = new List<string> { "near", "speak", "tonight", 
				"weapon", "customer", "deal", "lawyer" };

			var query = from word in words
						select word.Contains("ea") ? word.Replace("ea", "*") : word;

			foreach (var item in query)
			{
				Console.WriteLine(item);
			}

		}
	}
}