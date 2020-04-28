using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class Menu 
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Please chose one of following options:");
            Console.WriteLine("1. Order items");
            Console.WriteLine("2. Show account balance");
            Console.WriteLine("3. Withdraw money to your creditcard");
        }
    }
}