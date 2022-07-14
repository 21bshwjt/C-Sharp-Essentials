using System;

namespace LearningConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contructors
            var book01 = new Book("Partiva", "Sirhendu Mukherjee", 789);
            var book02 = new Book("Nillohit", "Sunil Gangapadhay", 398);

            //Assign a new value
            book02.title = "New value";

            //Class
            var book03 = new Book();
            book03.title = "Kaka";
            book03.auther = "Biswajit Biswas";
            book03.pages = 21;

            Console.WriteLine(book01.pages);
            Console.WriteLine(book02.title);
            Console.WriteLine(book03.auther);
        }
    }
}
