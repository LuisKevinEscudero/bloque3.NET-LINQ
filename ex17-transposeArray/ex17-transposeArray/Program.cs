/*Write a query that transposes square array (switch rows with columns).
Expected input and output
[1,1,1,1    [1,2,3,4
 2,2,2,2     1,2,3,4
 3,3,3,3   → 1,2,3,4
 4,4,4,4]    1,2,3,4]*/

namespace TransposeArray
{
	public class Program
	{
		static void Main(string[] args)
		{
			var array = new int[][] {new int[]{ 1, 2, 3, 4, 5 },
									 new int[]{ 6, 7, 8, 9, 10 },
									 new int[]{ 11, 12, 13, 14, 15 },
									 new int[]{ 16, 17, 18, 19, 20 },
									 new int[]{ 21, 22, 23, 24, 25 }};

			Console.WriteLine("Original array:");
			PrintArray(array);

			var transposedArray = Enumerable.Range(0, array.Length).Select(x => array.Select(y => y[x]));
			Console.WriteLine("Transpose array: ");
			foreach (var row in transposedArray)
			{
				foreach (var number in row)
				{
					Console.Write(number + " ");
				}
				Console.WriteLine();
			}

		}

		//method to print array
		static void PrintArray(int[][] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array[i].Length; j++)
				{
					Console.Write(array[i][j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}