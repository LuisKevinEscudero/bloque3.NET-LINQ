/*
Write a program in C# Sharp to display the top n-th records.
Test Data :
The members of the list are :
5
7
13
24
6
9
8
7
How many records you want to display ? : 3
Expected Output :
The top 3 records from the list are :
24
13
9 
 */

namespace DisplayTopRecord
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> { 5, 7, 13, 24, 6, 9, 8, 7 };
			int records;

			Console.Write("\nLINQ : Display top nth  records from the list : ");
			Console.Write("\n----------------------------------------------\n");

			Console.WriteLine("The members of the list are : ");
			foreach (var num in numbers)
			{
				Console.WriteLine(num);
			}

			Console.WriteLine("How many record you want to display ? : ");
			records = Convert.ToInt32(Console.ReadLine());

			numbers.Sort();
			numbers.Reverse();

			Console.WriteLine("The top {0} of the list are: ", records);

			foreach (var item in numbers.Take(records))
			{
				Console.WriteLine(item);
			}

		}
	}
}