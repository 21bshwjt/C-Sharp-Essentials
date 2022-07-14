using System;
using System.Collections.Generic;

namespace LearningLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            List<string> customers = new List<string>();

            customers.Add("Biswajit");
            customers.Add("Vivek");
            customers.Add("Raghu");
            customers.Add("Deepak");
            Console.WriteLine(customers.Count);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine(customers[2]);
        }
    }
}
