using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System;

namespace ChainedQueryOperations
{
	public class Ingredient
	{
		public string Name { get; set; }
		public int Calories { get; set; }
	}

	public class Program
	{
		static void Main(string[] args)
		{
			Ingredient[] ingredients = new Ingredient[]
			{
				new Ingredient { Name = "Eggs", Calories = 500 },
				new Ingredient { Name = "Milk", Calories = 42 },
				new Ingredient { Name = "Butter", Calories = 102 },
				new Ingredient { Name = "Flour", Calories = 51 },
				new Ingredient { Name = "Sugar", Calories = 490 },
				new Ingredient { Name = "Vanilla", Calories = 7 },
				new Ingredient { Name = "Salt", Calories = 0 },
				new Ingredient { Name = "Baking Powder", Calories = 400 },
				new Ingredient { Name = "Chocolate Chips", Calories = 140 }
			};
			IEnumerable<string> highCalorieIngredientNamesQuery = ingredients
				.Where(x => x.Calories >= 150)
				.OrderBy(x => x.Name)
				.Select(x => x.Name); 
			
			foreach (var ingredientName in highCalorieIngredientNamesQuery) 
			{
				Console.WriteLine(ingredientName); 
			}

		}
	}
}