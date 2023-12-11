using System.Collections;

namespace Bai3va4
{
    [Serializable]
    public class Account : IComparer,IComparable
    {
        private int accountID;
        private string firstName;
        private string lastName;
        private int balance;
        private Account.ComparisionType whichComparision;
        public int AccountID { set { accountID = value; } get { return accountID; } }
        public string FirstName { set { firstName = value; } get { return firstName; } }
        public string LastName { set { lastName = value; } get { return lastName; } }
        public int Balance { set { balance = value; } get { return balance; } }
        public Account.ComparisionType WhichComparision { set { whichComparision = value; } get { return whichComparision; } }
        public void FillInfo()
        {
            Console.Write("Account ID: "); accountID = int.Parse(Console.ReadLine());
            Console.Write("First Name: "); firstName = Console.ReadLine();
            Console.Write("Last Name: "); lastName = Console.ReadLine();
            Console.Write("Balance: "); balance = int.Parse(Console.ReadLine());
        }
        public Account(int accountID, string firstName, string lastName, int balance)
        {
            this.accountID = accountID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public Account()
        {

        }
        public void Query()
        {
            Console.WriteLine("Account ID: {0}, First Name: {1}, Last Name: {2}, Balance: {3}",accountID,firstName,lastName,balance);
        }
        public int Compare(object? x, object? y)
        {
            Account a = (Account)x;
            Account b = (Account)y;
            return a.accountID.CompareTo(b.accountID);
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
        public int CompareTo(Account acc, Account.ComparisionType which)
        {
            switch (which)
            {
                case Account.ComparisionType.AccountID:
                    return this.accountID.CompareTo(acc.accountID);
                case Account.ComparisionType.FirstName:
                    return this.firstName.CompareTo(acc.firstName);
                case Account.ComparisionType.Balance:
                    return this.lastName.CompareTo(acc.lastName);
            }
            return 0;
        }
        public enum ComparisionType
        {
            AccountID, FirstName, Balance
        }
    }
}