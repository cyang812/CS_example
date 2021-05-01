using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace DerivedClass
{
    class MyBaseClass 
    {
        static int var = 10;

        virtual public void print() 
        {
            Console.WriteLine($"var = {var}");
        }
    
    }

    class MyDerivedClass : MyBaseClass 
    {
        static int var = 20;
        override public void print() 
        {
            Console.WriteLine($"var = {var}");
        }
    }

    class MyAnotherDerivedClass : MyBaseClass
    {
        static int var = 30;
        new public void print()
        {
            Console.WriteLine($"var = {var}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            MyDerivedClass myDerivedClass = new MyDerivedClass();
            myDerivedClass.print();
           
            MyBaseClass myBaseClass = (MyBaseClass)myDerivedClass;
            myBaseClass.print();

            Console.WriteLine("======================");

            MyAnotherDerivedClass myAnotherDerivedClass = new MyAnotherDerivedClass();
            myAnotherDerivedClass.print();

            MyBaseClass myBaseClass1 = (MyBaseClass)myAnotherDerivedClass;
            myBaseClass1.print();
        }
    }
}
