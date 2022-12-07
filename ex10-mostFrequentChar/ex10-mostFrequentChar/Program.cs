/*Write a query that returns most frequent character in string. 
 * Assume that there is only one such character.
Expected input and output
"panda"  → 'a'
"n093nfv034nie9"→ 'n'*/

namespace MostFrequentChar
{
	public class Program
	{
		static void Main(string[] args)
		{
			string str = "49fjs492jfJs94KfoedK0iejksKdsj3";

			var query = from c in str
						group c by c into g
						orderby g.Count() descending
						select g.Key;

			Console.WriteLine(query.First());
		}
	}
}