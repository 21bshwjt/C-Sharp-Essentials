using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningConstructors
{
    class Book
    {
        public string title;
        public string auther;
        public int pages;

        public Book()
        {
        }
        public Book(string aTitle, string aAuther, int aPages)
        {
            title = aTitle;
            auther = aAuther;
            pages = aPages;
        }

    }
}
