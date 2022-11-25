/*
Write a program in C# Sharp to display the name of the days of a week.
Expected Output:
Sunday
Monday
Tuesday
Wednesday
Thursday
Friday
Saturday 
 */

namespace DayNames
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

			Console.Write("\nLINQ : Display the name of the days of a week : ");
			Console.Write("\n------------------------------------------------\n");

			IEnumerable<string> day = from d in dayWeek
									  select d;

			foreach (var item in day)
			{
				Console.WriteLine(item);
			}
			
			
		}
	}
}