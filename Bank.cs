using System;

namespace VendingMachine
{
    public class Bank
    {
        // Get Money
        public static bool Withdraw(int amount, User user)
        {
            if (amount > 0)
            {
                user.Balance -= amount;
                user.CreditCard += amount;
                Console.WriteLine($"You now have {user.CreditCard}$ available on your creditcard.");
            }
            else
            {
                Console.WriteLine("You can't fool us ;)");
            }

            return false;
        }

        public static void ShowBalance(User user)
        {
            Console.WriteLine($"Your balance is: {user.Balance}$");
        }
        
        // Add account for VendingMachine
    }
}