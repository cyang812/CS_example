using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace DelegateExample
{
    delegate void MyDel1(int a);
    delegate void MyDel2();
    delegate int MyDel3(int a);

    class MyClass 
    {
        static int StudentCount = 10;

        public static void Print() 
        {
            Console.WriteLine($"student count = {StudentCount}");
        }

        public void Add() 
        {
            ++StudentCount;
        }

        public void AddNumber(int num) 
        {
            StudentCount += num;
        }
    }

    class MyTeam
    {
        public int TeamCount = 100;

        public void Print()
        {
            Console.WriteLine($"team count = {TeamCount}");
        }

        public void Add()
        {
            TeamCount++;
        }

        public void AddNumber(int num)
        {
            TeamCount += num;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyTeam myTeam = new MyTeam();

            MyDel1 myDel1 = myClass.AddNumber;
            MyDel2 myDel2 = MyClass.Print;
            myDel2 += myClass.Add;
            myDel2 += MyClass.Print;

            myDel1(20);
            myDel2();
            myDel1(20);
            myDel2();

            myDel1 += myTeam.AddNumber;
            myDel2 += myTeam.Add;
            myDel2 += myTeam.Print;

            Console.WriteLine();

            myDel1(20);
            myDel2();
            myDel1(20);
            myDel2();


            //lambda 
            MyDel3 myDel3 = (x) => {
                myTeam.TeamCount += x; 
                Console.WriteLine(myTeam.TeamCount);
                return myTeam.TeamCount;
            };

            Console.WriteLine($"myDel3 : {myDel3(1000)}");
        }
    }
}
