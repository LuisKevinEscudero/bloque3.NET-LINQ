/*
Write a program in C# Sharp to count file extensions and group it using LINQ.
Test Data :
The files are : aaa.frx, bbb.TXT, xyz.dbf,abc.pdf
aaaa.PDF,xyz.frt, abc.xml, ccc.txt, zzz.txt
Expected Output :
Here is the group of extension of the files :
1 File(s) with .frx Extension
3 File(s) with .txt Extension
1 File(s) with .dbf Extension
2 File(s) with .pdf Extension
1 File(s) with .frt Extension
1 File(s) with .xml Extension 
 */

namespace CountFileExtension
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] files = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
			List<string> extensions = new List<string>();
			IEnumerable<string> uniqueExtensions;

			Console.Write("\nLINQ : Count file extensions and group it : ");
			Console.Write("\n------------------------------------------\n");

			Console.WriteLine("The files are: ");
			foreach (var file in files)
			{
				Console.WriteLine(file);
			}
			Console.WriteLine("******************");
			foreach (var item in files)
			{
				extensions.Add(item.Split('.').Last().ToLower());
				Console.WriteLine(item.Split('.').Last());
			}
			uniqueExtensions = extensions.Distinct();

			foreach (var item in uniqueExtensions)
			{
				Console.WriteLine("{0} File(s) with .{1} Extension", extensions.Count(x => x == item), item);
			}

		}
	}
}