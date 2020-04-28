using System;
using System.Diagnostics;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Bank bank = new Bank();
            Inventory inventory = new Inventory();
            int balance = 0;
            int creditCard = 0;
            User user = new User(balance, creditCard);

            Menu.DisplayMenu();
            while (true)
            {
                var input = Console.ReadLine();
                {
                    switch (input)
                    {
                        case "1":
                            try
                            {
                                Console.Clear();
                                Inventory.PurchaseItem(user);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                throw;
                            }

                            break;
                        case "2":
                            try
                            {
                                Bank.ShowBalance(user);
                                Menu.DisplayMenu();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                throw;
                            }

                            break;
                        case "3":
                            try
                            {
                                Console.WriteLine("How much would you like to withdraw?");
                                int.TryParse(Console.ReadLine(), out var withdrawAmount);
                                Bank.Withdraw(withdrawAmount, user);
                                Menu.DisplayMenu();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                throw;
                            }

                            break;
                        default:
                            Console.WriteLine("You need to input 1. To order items, 2. To Show balance or 3. to Withdraw money");
                            break;
                    }
                }

            }
        }
    }
}