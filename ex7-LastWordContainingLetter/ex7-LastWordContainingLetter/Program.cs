/*Given a non-empty list of words, sort it alphabetically 
 * and return a word that contains letter 'e'.
Expected input and output
["plane", "ferry", "car", "bike"]→ "plane"*/

namespace LastWordContainingLetter
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<string> words = new List<string> { "cow", "dog", "elephant", 
				"cat", "rat", "squirrel", "snake", "stork" };

			var query= from word in words
					   where word.Contains("e")
					   orderby word
					   select word;

			foreach (var item in query)
			{
				Console.WriteLine(item);
			}
		}
	}
}