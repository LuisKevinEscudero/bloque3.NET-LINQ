/*
 Write a program in C# Sharp to remove items 
from list using remove function by passing the object. 
Test Data :
Here is the list of items :
Char: m
Char: n
Char: o
Char: p
Char: q
Expected Output:
Here is the list after removing the item 'o' from the list :
Char: m
Char: n
Char: p
Char: q
 */

namespace RemoveItemsFromList
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<string> words = new List<string>() { "m", "n", "o", "p", "q" };
			Console.WriteLine("Here is the list of items :");
			foreach (string word in words)
			{
				Console.WriteLine("Char: {0}", word);
			}

			IEnumerable<string> result = from x in words
                                         where x != "o"
                                         select x;

            Console.WriteLine("Here the list after removing the item 'o' from the list :");
			foreach (string word in result)
			{
				Console.WriteLine("Char: {0}", word);
			}

		}
	}
}