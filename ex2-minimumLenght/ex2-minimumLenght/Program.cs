/*Write a query that returns words at least 5 characters long and make them uppercase.
Expected input and output
"computer", "usb" → "COMPUTER"*/

namespace MinimumLength
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<string> words = new List<string> { "zebra", "elephant", "cat", "dog", "rhino", "bat" };

			var query= from word in words
					   where word.Length >= 5
					   select word.ToUpper();

			foreach (var item in query)
			{
				Console.WriteLine(item);
			}
		}
	}
}