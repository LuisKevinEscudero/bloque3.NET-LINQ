/*Write a query that returns only uppercase words from string.
Expected input and output
"DDD example CQRS Event Sourcing" → DDD, CQRS*/

namespace UppercaseOnly
{
	public class Program
	{
		static void Main(string[] args)
		{
			string word = "THIS is UPPERCASE string LOL";

			var uppercaseWords = word.Split(' ');

			var query = from w in uppercaseWords
						where w == w.ToUpper()
						select w;

			foreach (var item in query)
			{
				Console.WriteLine(item);
			}
		}
	}
}