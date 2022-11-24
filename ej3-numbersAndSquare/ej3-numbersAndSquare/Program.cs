/*
3. Write a program in C# Sharp to find the number of an array and the
square of each number. 
Expected Output :
{ Number = 9, SqrNo = 81 }
{ Number = 8, SqrNo = 64 }
{ Number = 6, SqrNo = 36 }
{ Number = 5, SqrNo = 25 } 
 */

namespace MyNamespace
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 3, 9, 2, 8, 6, 5 };

			IEnumerable<int> square = from x in numbers
									  where (x * x) > 20
									  select x;

			foreach (int num in square)
			{
				Console.WriteLine("Number = {0}, SqrNo = {1}", num, num * num);
			}
		}
	}
}