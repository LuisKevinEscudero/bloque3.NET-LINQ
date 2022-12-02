/*Write a program in C# Sharp to display the list of items in the array according to the length of the string then by name in ascending order. Go to the editor
Expected Output :
Here is the arranged list :
ROME
PARIS
LONDON
ZURICH
NAIROBI
ABU DHABI
AMSTERDAM
NEW DELHI
CALIFORNIA*/

namespace DisplayItemsByLenght
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] cities =
			{
				"ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
			};

			Console.Write("\nLINQ : Display the list according to the length then by name in ascending order : ");
			Console.Write("\n--------------------------------------------------------------------------------\n");
			Console.Write("\nThe cities are :");
			Console.WriteLine(String.Join(", ", cities));

			IEnumerable<string> orderCities = from city in cities
											  orderby city.Length, city
											  select city;

			Console.Write("\nThe list of items in the array according to the length of the string then by name in ascending order :\n");
			foreach (var item in orderCities)
			{
				Console.WriteLine(item);
			}

		}
	}
}