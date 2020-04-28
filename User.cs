namespace VendingMachine
{
    public class User
    {
       // BankInfo
       public int Balance { get; set; }
       public int CreditCard { get; set; }

       public User(int balance, int creditCard)
       {
           Balance = balance;
           CreditCard = creditCard;
       }
    }
}