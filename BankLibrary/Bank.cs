using System;

namespace BankLibrary
{
        public class Bank
        {
       ////     private Array[] detail;
       ////public Array[][] details;
            private float _amt;

            public float Amount
            {
                get { return _amt; }
                set { _amt = value; }
            }

            private long _accNo;

            public long AccountNo
            {
                get { return _accNo; }
                set { _accNo = value; }
            }

            private string _branchname;

            public string BranchName
            {
                get { return _branchname; }
                set { _branchname = value; }
            }

            private DateTime _dDate;

            public DateTime DDate
            {
                get { return _dDate; }
                set { _dDate = value; }
            }

            private float _bal = 0;

            public float Total
            {
                get { return _bal; }
                set { _bal = value; }
            }
           

            public void Deposit(float amt, DateTime depositDate, string branchname, long AccountNo)

            {
                Total += amt;
                Console.WriteLine($"Amount {Amount} had been Deposited to the Account number {AccountNo} on {depositDate} from {branchname} branch \nTotal Balance {Total}");

            }

            public void Deposit(long AccountNo, float amt, DateTime depositDate, string branchname)
            {
                Total += amt;
                Console.WriteLine($"Amount {amt} had been Deposited to the Account number {AccountNo} on {depositDate} from {branchname} branch \nTotal Balance {Total}");
            }

            public void Deposit(long AccountNo, float amt, DateTime depositDate)
            {
                Total += amt;
                Console.WriteLine($"Amount {amt} had been Deposited to the Account number {AccountNo} on {depositDate} \nTotal Balance {Total}");
            }

            public void Withdraw(float amt, DateTime depositDate, string branchname, long accountNo)

            {
                if (AccountNo == accountNo)
                {
                    if (BranchName == branchname) 
                    {
                        if (amt < Total)
                        {
                            Total -= amt;
                            Console.WriteLine($"Amount {amt} had been withdrawn from the Account number {AccountNo} on {depositDate} from {branchname} branch");
                            Console.WriteLine(" Remaining Balance:{0}", Total);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Funds..\n Balance : {0}", Total);
                            Console.WriteLine("Try Again");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Account Doesn't in these Branch");
                    }
                }
                else
                {
                    Console.WriteLine(" Account Doesn't Exist...");
                }
            }

        }
    }
