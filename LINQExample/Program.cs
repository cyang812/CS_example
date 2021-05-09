using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace LINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupA = new[] { 3, 4, 5, 6, 7, 8 };
            var groupB = new[] { 4, 5, 6, 7, 8, 9 };

            //var someInts = from a in groupA
            //               join b in groupB on a equals b
            //               select a;

            var someInts = from a in groupA
                           join b in groupB on a equals b
                           into groupAandB
                           from c in groupAandB
                           where c < 6
                           select c;

            foreach (var v in someInts)
                Console.WriteLine($"{v}");
        }
    }
}
