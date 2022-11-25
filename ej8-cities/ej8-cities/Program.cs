/*
Write a program in C# Sharp to find the string which starts 
and ends with a specific character. Go to the editor
Test Data :
The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA',
'ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
Input starting character for the string : A
Input ending character for the string : M
Expected Output :
The city starting with A and ending with M is : AMSTERDAM 
 */

namespace Cities
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] cities =
			{
				"ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
			};

			char start;
			char end;

			Console.Write("\nLINQ : Find the string which starts and ends with a specific character : ");
			Console.Write("\n-----------------------------------------------------------------------\n");
			Console.WriteLine("The cities are: ");
			Console.WriteLine(String.Join(", ", cities));

			Console.WriteLine("Input starting character for the string : ");
			start = Convert.ToChar(Console.ReadLine().ToUpper());

			Console.WriteLine("Input ending character for the string : ");
			end = Convert.ToChar(Console.ReadLine().ToUpper());


			IEnumerable<string> result = from x in cities
										 where start.Equals(x.First()) && end.Equals(x.Last())
										 select x;
			foreach (var item in result)
			{
				Console.WriteLine("The city starting fom {0} and end for {1} is: {2}", start, end, item);

			}


		}
	}
}