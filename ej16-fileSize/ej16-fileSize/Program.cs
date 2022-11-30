/*
Write a program in C# Sharp to calculate size of file using LINQ. 
Expected Output :
The Average file size is 3.4 MB 
 */

namespace FileSize
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] files = Directory.GetFiles(@"C:\Users\luiskevin.escudero\Desktop\bloque3.NET-LINQ\ej16-fileSize\ej16-fileSize\docs\");
			var averageSize = files.Average(file => new FileInfo(file).Length);
			Console.WriteLine("The Average file size is {0} MB", averageSize / 1024 / 1024);
		}
	}
}