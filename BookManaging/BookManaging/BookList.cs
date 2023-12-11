using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookManaging
{
    class BookList
    {
        // định nghĩa danh sách book
        private ArrayList list = new ArrayList();

        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }

        public void ShowList()
        {
            foreach (Book b in list) {
                b.Show();
            }
        }
        public void Sort(Book.BookComparer c)
        {
            list.Sort(c);
        }

        public void searchBy()
        {
            Console.Write("Your information : ");
            string input = Console.ReadLine();
            do
            {
                switch(input)
                {
                    case "Title":
                        Console.Write("Title : ");
                        string title = Console.ReadLine();
                        foreach(Book item in list)
                        {
                            if (item.Title.Equals(title))
                            {
                                Console.WriteLine("Found");
                                item.Show();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Not Found");
                            }
                        }
                        break;
                    case "Author":
                        Console.Write("Author : ");
                        string author = Console.ReadLine();
                        foreach (Book item in list)
                        {
                            if (item.Author.Equals(author))
                            {
                                Console.WriteLine("Found");
                                item.Show();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Not Found");
                            }
                        }
                        break;
                    case "Publisher":
                        Console.Write("Publisher : ");
                        string publisher = Console.ReadLine();
                        foreach (Book item in list)
                        {
                            if (item.Publisher.Equals(publisher))
                            {
                                Console.WriteLine("Found");
                                item.Show();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Not Found");
                            }
                        }
                        break;
                    case "Year":
                        Console.Write("Year : ");
                        string year = Console.ReadLine();
                        foreach (Book item in list)
                        {
                            if (item.Year.Equals(year))
                            {
                                Console.WriteLine("Found");
                                item.Show();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Not Found");
                            }
                        }
                        break;
                    default: break;
                }
            }while(input != Console.ReadLine());
        }

        public void searchRangeYear()
        {
            float min, max;


            Console.Write("Min range : ");
            string st = Console.ReadLine();
            min = float.Parse(st);

            Console.Write("Max range : ");
            st = Console.ReadLine();
            max = float.Parse(st);

            foreach(Book item in list)
            {
                if(item.Year >= min && item.Year <= max)
                {
                    item.Show();
                }
            }
        }

        public void InputList()
        {
            int n;
            Console.Write("Amount of books : ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                --n;
            }
        }
        
        
    }
}
