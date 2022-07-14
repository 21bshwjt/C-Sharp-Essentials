using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            ArrayList list = new ArrayList();
            list.Add("Biswajit Biswas");
            list.Add("Vivek Rai");
            String s = (string)list[0];

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
