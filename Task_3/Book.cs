using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string name, string author, int year)
        {
            Name = name;
            Author = author;
            Year = year;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Author: {Author}, Year: {Year}";
        }
        public static bool operator == (Book a, Book b)
            {
              if(a.Name==b.Name && a.Author == b.Author && a.Year == b.Year)
                return true ;
              return false ;
            }
        public static bool operator != (Book a, Book b)
        {
            if (a == b)
                return false;
            return true ;
        }
    }
}
