using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSet test = new TestSet();

            var result = test.Where(i => i % 2 == 0);

            foreach (var VARIABLE in result)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.ReadLine();
        }
    }
}
