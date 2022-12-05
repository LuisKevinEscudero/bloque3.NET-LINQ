/*Write a query that returns words starting with letter 'a' and ending with letter 'm'.
Expected input and output
"mum", "amsterdam", "bloom" → "amsterdam"*/

using System.Security.Cryptography.X509Certificates;

namespace SelectWords
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<string> words = new List<string> { "alabam", "am", "balalam", 
				"tara", "", "a", "axeliam", "39yo0m", "trol" };

			var query = from word in words
						where word.StartsWith('a') && word.EndsWith('m')
						select word;


			foreach (var item in query)
			{
				Console.WriteLine(item);
			}
		}
	}
}