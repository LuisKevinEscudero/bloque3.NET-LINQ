/*Given a non-empty list of strings, return a list that contains only unique (non-duplicate) strings.
Expected input and output
["abc", "xyz", "klm", "xyz", "abc", "abc", "rst"] → ["klm", "rst"]*/

namespace UniquesValues
{
	public class Program
	{
		static void Main(string[] args)
		{
			var values = new List<string> { "Hi", "Meow", "Hello", "Meow", 
				"Hi!", "Meow", "Hi", "Bye" };

			var query = from value in values
						group value by value into g
						where g.Count() == 1
						select g.Key;

			foreach (var item in query)
			{
				Console.WriteLine(item);
			}

		}
	}
}