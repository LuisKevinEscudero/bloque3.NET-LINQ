/*
Write a program in C# Sharp to convert a string array to a string.
Test Data :
Input number of strings to store in the array :3
Input 3 strings for the array :
Element[0] : cat
Element[1] : dog
Element[2] : rat
Expected Output:
Here is the string below created with elements of the above array :
cat, dog, rat 
*/

namespace StringArray
{
	public class Program
	{
		static void Main(string[] args)
		{
			;
			int number;
			Console.WriteLine("Input number of strings to store in the array :");
			number = Convert.ToInt32(Console.ReadLine());
			string[] words = new string[number];
			for (int i = 0; i < number; i++)
			{
				Console.WriteLine("Input {0} strings for the array :", i+1);
				words[i] = Console.ReadLine();
			}

			Console.WriteLine("Here is the string below created with elements of the above array :");
			Console.WriteLine(string.Join(", ", words));
		}
	}
}