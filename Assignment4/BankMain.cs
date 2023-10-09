using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
 internal class BankMain
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.Amount = 2000;
            b.AccountNo = 202902019023;
            b.BranchName = "vizag";
            b.DDate = DateTime.Now;
            b.Deposit(b.AccountNo, b.Amount, b.DDate, b.BranchName);
            Console.WriteLine();
            b.Deposit(b.AccountNo, 6000, b.DDate);
            Console.WriteLine();
            b.Withdraw(1500, b.DDate, b.BranchName, b.AccountNo);
            Console.ReadLine();
        }

    }
}
