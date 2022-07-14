using System;

namespace LearningClass01
{
    class Program
    {
        static void Main(string[] args)
        {
            var book01 = new Book();
            book01.title = "Partiva";
            book01.auther = "Sirhendu Mukherjee";
            book01.pages = 798;

            var book02 = new Book();
            book02.title = "Nillohit";
            book02.auther = "Sunil Gangapadhay";
            book02.pages = 398;

            Console.WriteLine(book01.pages);
            Console.WriteLine(book02.auther);
        }
    }
}
