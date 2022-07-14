using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Hello World!");
        Dictionary<string, string> config = new Dictionary<string, string>();

            config.Add("resolution", "1940x1080");
            config.Add("title", "biswajit");
            
            Console.WriteLine(config["title"]);

            // Foreach loop
            foreach (var item in config)
            {
                Console.WriteLine(item.Value);
            }

        }
    }
}
