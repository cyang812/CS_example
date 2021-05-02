using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace InterfaceExample
{
    interface IIfc1
    {
        void PrintOut(string s);
    }

    interface IIfc2
    {
        void PrintOut(string s);
    }

    class MyClass : IIfc1, IIfc2
    {
        void IIfc1.PrintOut(string s) 
        {
            Console.WriteLine($"Calling through: IIfc1 - {s}");
        }

        void IIfc2.PrintOut(string s)
        {
            Console.WriteLine($"Calling through: IIfc2 - {s}");
        }

        public void PrintOut(string s)
        {
            Console.WriteLine($"Calling through: class - {s}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.PrintOut("object");

            IIfc1 ifc1 = mc as IIfc1;
            if(ifc1 != null)
                ifc1.PrintOut("interface");

            IIfc2 ifc2 = mc as IIfc2;
            if (ifc2 != null)
                ifc2.PrintOut("interface");
        }
    }
}
