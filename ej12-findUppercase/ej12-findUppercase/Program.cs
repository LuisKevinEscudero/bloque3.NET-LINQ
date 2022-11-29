/*
Write a program in C# Sharp to find the uppercase words in a string. 
Test Data :
Input the string : this IS a STRING
Expected Output :
The UPPER CASE words are :
IS
STRING
 */

namespace FindUppercase
{
	public class Program
	{
		static void Main(string[] args)
		{
			string input = "this IS a STRING";

			Console.WriteLine("Writte a text with uppercase words: ");
			input = Console.ReadLine();

			Console.WriteLine("The input string is : {0}", input);

			List<string> words = input.Split(' ').ToList();
			IEnumerable<string> uppercasse = from x in words
											 where x == x.ToUpper()
											 select x;

			Console.WriteLine("The UPPER CASE words are :");
			foreach (string word in uppercasse)
			{
				Console.WriteLine(word);
			}
		}
	}
}