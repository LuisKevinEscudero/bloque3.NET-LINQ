/*Write a program in C# Sharp to generate a Right Outer Join between two data sets.
Expected Output :

Here is the list after joining  :                                                                             
                                                                                                              
Item ID         Item Name       Purchase Quantity                                                             
-------------------------------------------------------                                                       
3               Butter                  800                                                                   
5               Honey                   650                                                                   
3               Butter                  900                                                                   
4               Brade                   700                                                                   
3               Butter                  900                                                                   
4               Brade                   650                                                                   
1               Biscuit                 458  */

namespace RightJoin
{
    public class Item_mast
    {
        public int ItemId { get; set; }
        public string ItemDescription { get; set; }
    }

    public class Purchase
    {
        public int InventoryNumber { get; set; }
        public int ItemId { get; set; }
        public int PurchaseQuantity { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Item_mast> itemlist = new List<Item_mast>
            {
           new Item_mast { ItemId = 1, ItemDescription = "Biscuit  " },
           new Item_mast { ItemId = 2, ItemDescription = "Chocolate" },
           new Item_mast { ItemId = 3, ItemDescription = "Butter   " },
           new Item_mast { ItemId = 4, ItemDescription = "Brade    " },
           new Item_mast { ItemId = 5, ItemDescription = "Honey    " }
            };

            List<Purchase> purchaselist = new List<Purchase>
            {
           new Purchase { InventoryNumber=100, ItemId = 3,  PurchaseQuantity = 800 },
           new Purchase { InventoryNumber=101, ItemId = 5,  PurchaseQuantity = 650 },
           new Purchase { InventoryNumber=102, ItemId = 3,  PurchaseQuantity = 900 },
           new Purchase { InventoryNumber=103, ItemId = 4,  PurchaseQuantity = 700 },
           new Purchase { InventoryNumber=104, ItemId = 3,  PurchaseQuantity = 900 },
           new Purchase { InventoryNumber=105, ItemId = 4,  PurchaseQuantity = 650 },
           new Purchase { InventoryNumber=106, ItemId = 1,  PurchaseQuantity = 458 }
            };

            Console.Write("\nLINQ : Generate a Right Join between two data sets : ");
            Console.Write("\n--------------------------------------------------\n");
            Console.Write("Here is the Item_mast List : ");
            Console.Write("\n-------------------------\n");

            foreach (var item in itemlist)
            {
                Console.WriteLine("ItemId: {0}, item description: {1}", item.ItemId, item.ItemDescription);
            }
            Console.Write("Here is the Item_mast List : ");
            Console.Write("\n-------------------------\n");

            foreach (var item in purchaselist)
            {
                Console.WriteLine("ItemId: {0}, Inventory Number: {1}, PurchaseQuantity: {2}", item.ItemId, item.InventoryNumber, item.PurchaseQuantity);
            }

            var query = from purchase in purchaselist
                        join item in itemlist
                        on purchase.ItemId equals item.ItemId into joined
                        from purIt in joined.DefaultIfEmpty()
                        select new
                        {
                            id = purchase.ItemId,
                            name = purIt.ItemDescription,
                            quantity = purchase.PurchaseQuantity
                        };

            Console.Write("\n-------------------------\n");
            Console.WriteLine("Here is the join list: ");
            Console.WriteLine("Item ID\t\t Item Name\t\t Purchase Quantity");
            foreach (var item in query)
            {
                Console.WriteLine("{0}\t\t {1}\t\t {2}", item.id, item.name, item.quantity);
            }
        }
    }
}