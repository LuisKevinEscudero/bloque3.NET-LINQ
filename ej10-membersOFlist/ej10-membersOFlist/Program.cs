/*
Write a program in C# Sharp to accept the members of a list 
through the keyboard and display the members more than a specific value. 
Test Data :
Input the number of members on the List : 5
Member 0 : 10
Member 1 : 48
Member 2 : 52
Member 3 : 94
Member 4 : 63
Input the value above you want to display the members of the List : 59
Expected Output :
The numbers greater than 59 are :
94
63 
 */

namespace MembersOfList
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int>();
			int elements;
			int value;

			Console.Write("\nLINQ : Accept the members of a list and display the members more than a specific value : ");
			Console.Write("\n----------------------------------------------------------------------------------------\n");

			
			Console.Write("How many elements are in the list? : ");
			elements = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < elements; i++)
			{
				Console.WriteLine("Enter element {0} : ", i);
				numbers.Add(Convert.ToInt32(Console.ReadLine()));
			}

			Console.Write("The list you entered is : ");
			foreach (int i in numbers)
			{
				Console.Write("{0} ", i);
			}

			Console.WriteLine("\nInput the value above you want to display " +
				"the members of the List: ");
			value = Convert.ToInt32(Console.ReadLine());

			IEnumerable<int> finalList = from x in numbers
										 where x > value
										 select x;

			Console.WriteLine("The numbers greater than {0} are : ", value);
			foreach (int i in finalList)
			{
				Console.WriteLine("{0} ", i);
			}



		}
	}
}