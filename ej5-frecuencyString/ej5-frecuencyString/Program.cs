/*
 Write a program in C# Sharp to display the characters 
and frequency of character from giving string. Go to the editor
Test Data:
Input the string: apple
Expected Output:
The frequency of the characters are :
Character a: 1 times
Character p: 2 times
Character l: 1 times
Character e: 1 times 
 */

namespace FrecuencyString
{
	public class Program
	{
		static void Main(string[] args)
		{
			string word = "apple";

			IEnumerable<char> characters = word.Distinct();
			foreach (var item in characters)
			{
				int frecuency = word.Count(x => x == item);
				Console.WriteLine("Character {0}: {1} times", item, frecuency);
			}
		}
	}
}