using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3va4
{
    public class Program
    {
        static void Main(string[] args)
        {
            AccountList accountList = new AccountList();
            int urChoice = 0;
            do
            {
                Console.WriteLine("---MENU---");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Save");
                Console.WriteLine("3.Load");
                Console.WriteLine("4.Report");
                Console.WriteLine("5.Remove");
                Console.WriteLine("6.Sort");
                Console.WriteLine("7.Exit");
                Console.WriteLine("----------");
                try
                {
                    Console.Write("Your choice: "); urChoice = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                switch(urChoice)
                {
                    case 1:
                        accountList.NewAccount();
                        break;

                    case 2:
                        accountList.Save();
                        break;

                    case 3:
                        accountList.Load();
                        break;

                    case 4:
                        accountList.Report();
                        break;

                    case 5:
                        accountList.RemoveAccount();
                        break;

                    case 6:
                        do
                        {
                            Console.WriteLine("---MENU---");
                            Console.WriteLine("1.ID");
                            Console.WriteLine("2.First Name");
                            Console.WriteLine("3.Balance");
                            Console.WriteLine("4.Exit");
                            Console.WriteLine("----------");
                            try
                            {
                                Console.Write("Your choice: "); urChoice = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }                        
                        
                            Account type = new Account();
                            switch (urChoice)
                            {
                                case 1:
                                    type.WhichComparision = Account.ComparisionType.AccountID;
                                    accountList.Sort(type);
                                    accountList.Report();
                                    break;
                                case 2:
                                    type.WhichComparision = Account.ComparisionType.FirstName;
                                    accountList.Sort(type);
                                    accountList.Report();
                                    break;
                                case 3:
                                    type.WhichComparision = Account.ComparisionType.Balance;
                                    accountList.Sort(type);
                                    accountList.Report();
                                    break;
                                default:
                                    break;
                            }
                        } while (urChoice != 4);                        
                        break;

                    default:
                        break;
                }
            } while (urChoice != 7);
            

        }
    }
}
