using System;

namespace LearningMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            SayHi("Biswajit", 21);
            SayHi("Manik", 31);
            SayHi("Chirag", 55);
        }
        //Method & Function are the same in C#.
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hi " + name + "; age is "+ age);
        }
    }
}
