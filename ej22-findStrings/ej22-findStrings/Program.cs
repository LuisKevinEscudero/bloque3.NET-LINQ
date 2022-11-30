/*
Write a program in C# Sharp to find the strings for a specific minimum length.
Test Data :
Input number of strings to store in the array :4
Input 4 strings for the array:
Element[0] : this
Element[1] : is
Element[2] : a
Element[3] : string
Input the minimum length of the item you want to find : 5
Expected Output:
The items of minimum 5 characters are :
Item: string 
 */
namespace FindStrings
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input number of strings to store in the array :");
			int arrayExtension = Convert.ToInt32(Console.ReadLine());
			
			string[] words = new string[arrayExtension];

			for (int i = 0; i < arrayExtension; i++)
			{
				Console.WriteLine("Input {0} strings for the array:", i+1);
				words[i] = Console.ReadLine();
			}

			Console.WriteLine("Input the minimum length of the item you want to find :");
			int minLength = Convert.ToInt32(Console.ReadLine());
					
			Console.WriteLine("The items of minimum {0} characters are :", minLength);
			foreach (var item in words)
			{
				if (item.Length >= minLength)
				{
					Console.WriteLine("Item: {0}", item);
				}
			}
		}
	}
}