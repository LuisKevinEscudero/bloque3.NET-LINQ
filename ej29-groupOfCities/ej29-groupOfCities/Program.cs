/*Write a program in C# Sharp to split a collection of strings into some groups. Go to the editor
Expected Output :
Here is the group of cities :

ROME; LONDON; NAIROBI
-- here is a group of cities --

CALIFORNIA; ZURICH; NEW DELHI
-- here is a group of cities --

AMSTERDAM; ABU DHABI; PARIS
-- here is a group of cities --

NEW YORK
-- here is a group of cities --*/
namespace GroupOfCities
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] cities =
			{
				"ROME","LONDON","NAIROBI","CALIFORNIA",
				"ZURICH","NEW DELHI","AMSTERDAM",
				"ABU DHABI", "PARIS","NEW YORK"
			};

			Console.Write("\nLINQ : Split a collection of strings into some groups of 3 cities  : ");
			Console.Write("\n-------------------------------------------------------\n");
			Console.WriteLine("Here is the group of cities :");
			Console.WriteLine(String.Join(", ", cities));

			IEnumerable<string> groupCities = from city in cities
											  group city by city.Length into cityGroup
											  select cityGroup.Key + " - " + String.Join(", ", cityGroup);
			Console.WriteLine("+++++");
			foreach (string city in groupCities)
			{
				Console.WriteLine(city);
			}
		}
	}
}