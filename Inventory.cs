using System;
using System.Collections.Generic;
using System.Threading;

namespace VendingMachine
{
    public class Inventory
    {
        public static List<GoodsItem> _items = new List<GoodsItem>()
        {
            new GoodsItem("The Answer", 42, 101010),
            new GoodsItem("Snake oil", 666, 666),
            new GoodsItem("C-sharp", 2000, 1),
            new GoodsItem("Covid19", 0, 0),
        };

        public static void ListItems()
        {
            int listPosition = 1;
            foreach (var goodsItem in _items)
            {
                Console.WriteLine($"{listPosition++}. – {goodsItem.ItemName} – {goodsItem.ItemPrice}$");
            }
        }

        public static void PurchaseItem(User user)
        {
            ListItems();
            Console.WriteLine("Enter the number of the item you want to purchase");
            if (int.TryParse(Console.ReadLine(), out var itemSelected))
            {
                itemSelected -= 1; // Get the array index

                foreach (var t in _items)
                {
                    if (user.CreditCard < _items[itemSelected].ItemPrice)
                    {
                        Console.WriteLine("Sorry, but you need to withdraw money to your creditcard.");
                        Menu.DisplayMenu();
                        break;
                    }
                    if (_items[itemSelected].ItemInventory == 0)
                    {
                        Console.WriteLine($"Sorry, but {_items[itemSelected].ItemName} seems to be sold out");
                        PurchaseItem(user);
                        break;
                    }
                    Console.WriteLine($"Thank you! Your order of {_items[itemSelected].ItemName} for {_items[itemSelected].ItemPrice}$ will be delivered as soon as possible.");
                        _items[itemSelected].ItemPrice -= user.CreditCard;
                        break;
                }
            }
            else
                Console.WriteLine("You need to enter a number");
        }
    }
}