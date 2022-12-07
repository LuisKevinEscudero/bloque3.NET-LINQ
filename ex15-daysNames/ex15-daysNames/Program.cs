/*Write a query that returns names of days.
Expected input and output
daysNames → "Sunday Monday Tuesday Wednesday Thursday Friday Saturday"*/

namespace DaysNames
{
	public class Program
	{
		static void Main(string[] args)
		{
			var daysNames = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();

			foreach (var day in daysNames)
			{
				Console.WriteLine(day);
			}
		}
	}
}