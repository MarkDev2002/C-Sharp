using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Bai3va4
{
    [Serializable]
    public class AccountList
    {
        private ArrayList list = new ArrayList();
        public void NewAccount()
        {
            Account account = new Account();
            account.FillInfo();
            list.Add(account);
        }
        public void RemoveAccount()
        {
            Report();
            Console.Write("Enter Account ID which you want to remove: ");
            int idAccount = int.Parse(Console.ReadLine());
            Account target = new Account { AccountID = idAccount };
            int index = list.BinarySearch(target, new Account());
            if (index != -1)
            {
                list.RemoveAt(index);
                Console.WriteLine("Account removed successfully.");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
            Report();
        }
        public void Save()
        {
            using (var stream = File.OpenWrite("C:\\Users\\DELL\\source\\repos\\Lab3\\Bai3va4\\Bai3va4\\data\\data.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Account) });
                serializer.Serialize(stream, this.list);
            }

        }
        public void Load()
        {
            using (var stream = File.OpenRead("C:\\Users\\DELL\\source\\repos\\Lab3\\Bai3va4\\Bai3va4\\data\\data.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Account) });
                this.list = serializer.Deserialize(stream) as ArrayList; 
                Report();
            }
        }
        public void SaveFile()
        {
            Console.Write("Input file name to save: ");
            string fname = Console.ReadLine();
            try
            {
                FileStream output = new FileStream(fname, FileMode.CreateNew, FileAccess.Write);
                StreamWriter writer = new StreamWriter(output);
                foreach (Account acc in list)
                {
                    writer.WriteLine("{0}, {1}, {2}, {3}", acc.AccountID, acc.FirstName, acc.LastName, acc.Balance);

                }
                writer.Close();
                output.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void LoadFile()
        {
            Console.Write("Input file name to load: ");
            string fname = Console.ReadLine();
            list.Clear();
            try
            {
                FileStream input = new FileStream(fname, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] list = str.Split(',');
                    Account acc = new Account(int.Parse(list[0]), list[1], list[2], int.Parse(list[3]));
                    this.list.Add(acc);
                }
                input.Close();
                reader.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Report()
        {
            foreach (Account acc in this.list)
            {
                acc.Query();
            }
        }
        public void Sort(Account type)
        {
            list.Sort(type);
        }

    }
}
