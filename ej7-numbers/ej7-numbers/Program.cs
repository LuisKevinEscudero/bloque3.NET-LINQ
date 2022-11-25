/*
Write a program in C# Sharp to display numbers,
multiplication of number with frequency and frequency of
a number of giving array. 
Test Data :
The numbers in the array are :
5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2
Expected Output :
Number Number*Frequency Frequency
------------------------------------------------
5 15 3
1 1 1
9 9 1
2 4 2 
 */

namespace Numbers
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

			Console.Write("\nLINQ : Display numbers, number*frequency and frequency : ");
			Console.Write("\n-------------------------------------------------------\n");
			Console.Write("The numbers in the array are : \n");
			
			Console.WriteLine(string.Join(", ", numbers));
			
			IEnumerable<int> uniqueNumbers = numbers.Distinct();
			
			IEnumerable<int> frequency = uniqueNumbers.Select(x => numbers.Count(y => y == x));


			foreach (int i in uniqueNumbers)
			{
				Console.WriteLine("{0} {1} {2}", i, i * frequency.ElementAt(uniqueNumbers.ToList().IndexOf(i)), frequency.ElementAt(uniqueNumbers.ToList().IndexOf(i)));
			}
		}
	}
}