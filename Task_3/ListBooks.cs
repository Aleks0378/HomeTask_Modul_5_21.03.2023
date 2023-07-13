using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class ListBooks
    {
        public List<Book> books {  get; set; }
        public Book this[int index]
        {
            get 
            { 
                return books[index];
            }
            set
            {
                books[index] = value;
            }
        }
        public ListBooks()
        {
            books = new List<Book>(); 
        }
        public static ListBooks operator+(ListBooks list, Book book)
        {
            list.books.Add(book);
            return list;
        }
        public static ListBooks operator-(ListBooks list, Book book)
        {
            for (int i = 0; i < list.books.Count; i++)
            {
                if (list.books[i].Name == book.Name)
                    list.books.RemoveAt(i);
            }
            return list;
        }

        public bool Find(Book book)
        {
           foreach (var a in books)
            {
                if(a==book)
                    return true;
            }
           return false;
        }

    }
}
