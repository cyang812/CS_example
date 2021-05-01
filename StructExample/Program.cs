using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace StructExample
{
    class MyClass 
    {
        public int X;
        public int Y;

        public void print() 
        {
            Console.WriteLine($"MyClass: {X+Y}");
        }
    }


    struct MyStruct
    {
        public int X;
        public int Y;

        public MyStruct(int a)
        {
            X = 10;
            Y = 20;
        }

        public MyStruct(int a, int b) 
        {
            X = a;
            Y = b;
        }

        public void print() 
        {
            Console.WriteLine(X + Y);        
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyStruct point1 = new MyStruct(100);
            MyStruct point2;
            point2 = point1;

            point1.X = 100;
            point1.Y = 200;

            point1.print();
            point2.print();

            Console.WriteLine("============");

            MyClass point3 = new MyClass();
            MyClass point4 = new MyClass();

            point3.X = 30;
            point3.Y = 30;
            point4 = point3;

            point3.print();
            point4.print();
        }
    }
}
