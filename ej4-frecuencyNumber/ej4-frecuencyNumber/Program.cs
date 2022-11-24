/*
Write a program in C# Sharp to display the number and frequency 
of number from giving array. 
Expected Output :
The number and the Frequency are :
Number 5 appears 3 times
Number 9 appears 2 times
Number 1 appears 1 times 
 */

using System.Collections.Immutable;

namespace frecuencyNumber
{
	public class Program
	{
		static void Main(string[] args)
		{
			method1();
			method2();
		}

		public static void method1()
		{
			int[] numbers = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
			Console.Write("\nLINQ : Display the number and frequency of number from given array : \n");
			Console.Write("---------------------------------------------------------------------\n");
			Console.WriteLine("The numbers in array are: ");
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write(numbers[i] + " ");
			}

			var numQuery = from x in numbers
						   group x by x into y
						   select y;
			Console.WriteLine("\nThe number and the Frequency are : \n");
			foreach (var arrNo in numQuery)
			{
				Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
			}
		}

		public static void method2()
		{
			int[] numbers = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
			Console.Write("\nLINQ : Display the number and frequency of number from given array : \n");
			Console.Write("---------------------------------------------------------------------\n");
			Console.WriteLine("The numbers in array are: ");
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write(numbers[i] + " ");
			}

			IEnumerable<int> uniqueNumbers = numbers.Distinct();
			Console.WriteLine("\n");
			foreach (int num in uniqueNumbers)
			{
				int frequency = numbers.Count(x => x == num);
				Console.WriteLine("Number {0} appears {1} times", num, frequency);
			}


		}
	}
}