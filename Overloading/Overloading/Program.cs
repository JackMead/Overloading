using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var quack = new Duck("Sir Quackalot", "Mallard", 100, 17);
            var quacker = new Duck("Sir Duckabit", "Muscovy", 250, 18);

            
            var duckDic = new Dictionary<Duck, int>
            {
                {quack,1},
                {quacker,2 }
            };

            //Test Dictionary works
            foreach (var pair in duckDic)
            {
                Console.WriteLine("{0} is the {1}th duck",pair.Key.Name, pair.Value);
            }

            //Test ToString()
            Console.WriteLine(quack);

            //Test Comparer
            var weightComparer = new WeightRelationalComparer();
            Console.WriteLine("{0} weighs more than {1}? {2}", quack.Name, quacker.Name, quack > quacker);
        }
    }
}
