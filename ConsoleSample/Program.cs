using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace ConsoleSample
{
    class RandomNumberClass 
    {
        public static DateTime TimeOfInstantiation;

        public static Random RandomKey;

        static RandomNumberClass()
        {
            RandomKey = new Random();
            TimeOfInstantiation = DateTime.Now;
        }        

        public int GetRandonNumber() 
        {
            return RandomKey.Next();
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            //string userInput;
            //string revertStr;
            //userInput = Console.ReadLine();
            //char[] charLists = userInput.ToCharArray();
            //foreach (var charList in charLists.Reverse())
            //{
            //    Console.Write(charList);
            //}
            //Console.WriteLine();

            //Console.WriteLine("===============");

            //RandomNumberClass a = new RandomNumberClass();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(a.GetRandonNumber());
            //}           

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(RandomNumberClass.RandomKey.Next());
                Console.WriteLine(RandomNumberClass.TimeOfInstantiation.ToString());
            }
        }
    }
}
