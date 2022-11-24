using System.Xml.Linq;

namespace QueryExpressionStyle
{

	public class Program
	{
		static void Main(string[] args)
		{
			Ingredient[] ingredients = 
				{ 
					new Ingredient{ Name = "Sugar", Calories = 500 }, 
					new Ingredient{ Name = "Egg", Calories = 100 }, 
					new Ingredient{ Name = "Milk", Calories = 150 }, 
					new Ingredient{ Name = "Flour", Calories = 50 }, 
					new Ingredient{ Name = "Butter", Calories = 200 } 
			}; 
			
			IEnumerable<string> highCalorieIngredientNamesQuery = 
				from i in ingredients where i.Calories >= 150
				orderby i.Name 
				select i.Name; 
			
			foreach (var ingredientName in highCalorieIngredientNamesQuery) 
			{  
				Console.WriteLine(ingredientName); 
			}
		}
	}
}