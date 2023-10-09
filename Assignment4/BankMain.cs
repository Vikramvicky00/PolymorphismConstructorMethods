using System;


namespace Assignment4
{
 internal class BankMain
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            Console.WriteLine("Enter Account Number : ");
            b.AccountNo = (long)Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Amount to deposit : ");
            b.Amount = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Branch Name : ");
            b.BranchName = Console.ReadLine();
            b.DDate = DateTime.Now;
            b.Deposit(b.AccountNo, b.Amount, b.DDate, b.BranchName);
            Console.WriteLine();

            Console.WriteLine("WITHDRAW METHOD");
            Console.WriteLine("Enter Account Number : ");
            long AccountNo = (long)Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Amount to Withdraw :");
            float withamount = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Branch Name : ");
            string BranchName = Console.ReadLine();
            b.Withdraw(withamount, b.DDate, BranchName, AccountNo);
            Console.ReadLine();
        }

    }
}
