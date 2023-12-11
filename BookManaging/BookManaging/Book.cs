using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using static BookManaging.BookList;

namespace BookManaging
{
    public class Book : IBook,IComparable
    {
        #region
        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;

        private ArrayList chapter = new ArrayList();
        #endregion

        public string this[int index]
        {
            get
            {
                if(index >= 0 && index < chapter.Count)
                {
                    return (string)chapter[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if(index >= 0 && index <= chapter.Count)
                {
                    chapter[index] = value;
                }
                else if (index == chapter.Count)
                {
                    chapter.Add(value);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        public string Publisher { get { return publisher; } set { publisher = value; } }
        public string ISBN { get { return isbn; } set { isbn = value; } }
        public int Year { get { return year; } set { year = value; } }

        public void Show()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Author : " + author);
            Console.WriteLine("Publisher : " + publisher);
            Console.WriteLine("ISBN : " + isbn);
            Console.WriteLine("Chapter : ");
            for(int i = 0; i < chapter.Count; ++i)
            {
                Console.WriteLine("\t{0} : {1}", i + 1 , chapter[i]);
            }
            Console.WriteLine("----------------");
        }

        public void Input()
        {
            Console.Write("Title : ");
            title = Console.ReadLine();

            Console.Write("Author : ");
            author = Console.ReadLine();

            Console.Write("Publisher : ");
            publisher = Console.ReadLine();

            Console.Write("ISBN : ");
            isbn = Console.ReadLine();

            Console.Write("Year : ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Input chapter (finished with empty string)");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                {
                    chapter.Add(str);
                }

            } while (str.Length > 0);

        }
        public static BookComparer GetComparer()
        {
            return new Book.BookComparer();
        }
        public int CompareTo(object? obj)
        {
            Book b = (Book)obj;
            return this.title.CompareTo(b.title);
        }
        public int CompareTo(Book b,Book.BookComparer.ComparisionType which)
        {
            switch (which)
            {
                case Book.BookComparer.ComparisionType.Year:
                    return this.year.CompareTo(b.year);
                case Book.BookComparer.ComparisionType.Title:
                    return this.title.CompareTo(b.title);
                case Book.BookComparer.ComparisionType.Author:
                    return this.author.CompareTo(b.author);
                case Book.BookComparer.ComparisionType.Publisher:
                    return this.publisher.CompareTo(b.publisher);
            }
            return 0;
        }

        public class BookComparer : IComparer
        {
            private Book.BookComparer.ComparisionType whichComparision;
            public enum ComparisionType
            {
                Year,Author,Title,Publisher
            };

            public int Compare(object? x, object? y)
            {
                Book b1 = (Book)x;
                Book b2 = (Book)y;
                return b1.CompareTo(b2, WhichComparision);
            }
            public Book.BookComparer.ComparisionType WhichComparision
            {
                 get
                 {
                    return whichComparision;
                 }
                 set
                 {
                    whichComparision = value;
                 }
            }

        }
    }
}