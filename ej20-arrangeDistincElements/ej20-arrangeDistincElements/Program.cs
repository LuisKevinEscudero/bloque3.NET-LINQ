/*Write a program in C# Sharp to arrange the distinct elements in the list in ascending order. Go to the editor
Expected Output :
Biscuit
Brade
Butter
Honey*/

using System;

namespace ArrangeDistincElements
{
	class Item_Mast
	{
		public int ItemId { get; set; }
		public string ItemDes { get; set; }

		public static List<Item_Mast> GetItemMast()
		{
			List<Item_Mast> itemlist = new List<Item_Mast>();
			itemlist.Add(new Item_Mast() { ItemId = 1, ItemDes = "Biscuit  " });
			itemlist.Add(new Item_Mast() { ItemId = 2, ItemDes = "Honey    " });
			itemlist.Add(new Item_Mast() { ItemId = 3, ItemDes = "Butter   " });
			itemlist.Add(new Item_Mast() { ItemId = 4, ItemDes = "Brade    " });
			itemlist.Add(new Item_Mast() { ItemId = 5, ItemDes = "Honey    " });
			itemlist.Add(new Item_Mast() { ItemId = 6, ItemDes = "Biscuit  " });
			return itemlist;
		}
	}

	public class Program
	{
		static void Main(string[] args)
		{
			Console.Write("\nLINQ : Arrange distinct elements in the list in ascending order : ");
			Console.Write("\n----------------------------------------------------------------\n");


			var itemlist = Item_Mast.GetItemMast();
			itemlist= itemlist.DistinctBy(x => x.ItemDes).ToList();

			Console.WriteLine("The list without order");
			foreach (var item in itemlist)
			{
				Console.WriteLine("{0}, {1}",item.ItemId, item.ItemDes);
			}

			var query = from item in itemlist
						orderby item.ItemDes ascending
						select item;

			Console.WriteLine("The orderder list: ");
			foreach (var item in query)
			{
				Console.WriteLine("{0}, {1}", item.ItemId, item.ItemDes);
			}

		}
	}


}