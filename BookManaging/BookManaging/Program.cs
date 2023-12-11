namespace BookManaging
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookList bl = new BookList();
            int choose = 0;
            do
            {
                Console.WriteLine("---------------Nhom 4---------------");
                Console.WriteLine("1.Add Books");
                Console.WriteLine("2.Show BookList");
                Console.WriteLine("3.Sort");
                Console.WriteLine("4.Search");
                Console.WriteLine("5.Search by range year");
                Console.WriteLine("6.Exit");
                Console.WriteLine("------------------------------------");
                Console.Write("Please choose action: "); choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        bl.InputList();
                        break;
                    case 2:
                        bl.ShowList();
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("---------------Nhom 4---------------");
                            Console.WriteLine("1.By Title");
                            Console.WriteLine("2.By Author");
                            Console.WriteLine("3.By Publisher");
                            Console.WriteLine("4.By Year");
                            Console.WriteLine("5.Back");
                            Console.WriteLine("------------------------------------");
                            Console.Write("Please choose action: "); choose = int.Parse(Console.ReadLine());
                            switch (choose)
                            {
                                case 1:
                                    Book.BookComparer bk = Book.GetComparer();
                                    bk.WhichComparision = Book.BookComparer.ComparisionType.Title;
                                    bl.Sort(bk);
                                    bl.ShowList();
                                    break;
                                case 2:
                                    Book.BookComparer bk1 = Book.GetComparer();
                                    bk1.WhichComparision = Book.BookComparer.ComparisionType.Author;
                                    bl.Sort(bk1);
                                    bl.ShowList();
                                    break;
                                case 3:
                                    Book.BookComparer bk2 = Book.GetComparer();
                                    bk2.WhichComparision = Book.BookComparer.ComparisionType.Publisher;
                                    bl.Sort(bk2);
                                    bl.ShowList();
                                    break;
                                case 4:
                                    Book.BookComparer bk3 = Book.GetComparer();
                                    bk3.WhichComparision = Book.BookComparer.ComparisionType.Year;
                                    bl.Sort(bk3);
                                    bl.ShowList();
                                    break;
                                default:
                                    break;
                            }
                        } while (choose != 5);
                        break;
                    case 4:
                        bl.searchBy();
                        break;
                    case 5:
                        bl.searchRangeYear();
                        break;
                    default:
                        break;
                }
            } while (choose != 6);
        }
    }
}