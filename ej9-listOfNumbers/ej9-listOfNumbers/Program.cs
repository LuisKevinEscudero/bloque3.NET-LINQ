/*
Write a program in C# Sharp to create a list of numbers 
and display the numbers greater than 80 as output.
Test Data :
The members of the list are :
55 200 740 76 230 482 95
Expected Output :
The numbers greater than 80 are :
200
740
230
482
95 
 */

namespace ListOfNumbers
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int>();
			numbers.Add(55);
			numbers.Add(200);
			numbers.Add(740);
			numbers.Add(76);
			numbers.Add(230);
			numbers.Add(482);
			numbers.Add(95);

			Console.Write("\nLINQ : Create a list of numbers and display the numbers greater than 80 : ");
			Console.Write("\n-------------------------------------------------------------------------\n");
			Console.WriteLine("\nThe members of the list are : ");
		   
			foreach (var num in numbers)
			{
				Console.Write("{0} ", num);
			}

			IEnumerable<int> greaterNumbers = from x in numbers
											  where x > 80
											  select x;

			Console.WriteLine("\n");
			foreach (var item in greaterNumbers)
			{
				Console.WriteLine("{0} is greater than 80", item);
			}
		}
	}
}