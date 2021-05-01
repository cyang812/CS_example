using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace EnumExample
{
    [Flags]
    enum MyEnum 
    {
        RED = 0x01,
        YELLOW = 0x02,
        GREEN = 0x04,
        BLACK = 0x08,
        WHITE = 0x11,
        BLUE = 0x12,
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyEnum e1 = MyEnum.RED;
            MyEnum e2 = MyEnum.GREEN;
            MyEnum e3 = MyEnum.YELLOW;
            MyEnum e4 = MyEnum.BLACK;

            Console.WriteLine(nameof(MyEnum.BLUE));
            Console.WriteLine(nameof(MyEnum.RED));
            Console.WriteLine(nameof(MyEnum.YELLOW));
            Console.WriteLine(nameof(MyEnum.WHITE));

            MyEnum e5 = MyEnum.RED | MyEnum.YELLOW | MyEnum.BLACK;

            Console.WriteLine(e5);

            foreach (var name in Enum.GetNames(typeof(MyEnum)))
            {
                Console.WriteLine(name);
            }
        }
    }
}
