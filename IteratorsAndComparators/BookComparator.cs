using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public  int Compare(Book a, Book b)
        {
            int result = a.Title.CompareTo(b.Title);
            if (result == 0)
            {
               result = a.Year.CompareTo(b.Year);
            }
            return result;
        }
    }
}
