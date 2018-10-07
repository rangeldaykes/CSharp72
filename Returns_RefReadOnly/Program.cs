using System;

namespace Returns_RefReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Returns_RefReadOnly");

            // ------- ref readonly return

            Console.WriteLine(string.Join(",", list));
            ref readonly var pos = ref GetPositionValue(3);
            Console.WriteLine(pos);
            // pos++; // Error CS1059  The operand of an increment or decrement operator must be a variable, property or indexer   

            Console.WriteLine(string.Join(",", list));

            // ------- ref readonly return

            Console.ReadLine();
        }

        static int[] list = new[] { 1, 2, 3, 4, 5 };

        static ref int GetPositionValue(int value)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == value)
                    return ref list[i];
            }

            throw new InvalidOperationException("not fount");
        }
    }
}
