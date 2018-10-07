using System;

namespace ExtensionMethods_in_ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExtensionMethods_in_ref");

            var i = 10;
            var j = 8;
            Console.WriteLine($"i is {i}");
            var k = i.SumIn(j);
            Console.WriteLine($"i is {i}");
            Console.WriteLine($"k is {k}");

            var m = j.SumRef(ref i);
            Console.WriteLine($"j is {j}");
            Console.WriteLine($"m is {m}");

            Console.ReadLine();
        }        
    }

    public static class Integers
    {
        // use reference of this not copy value
        public static int SumIn(in this int i1, in int i2)
        {
            //i1 = 3; // <= erro because is readonly
            return i1 + i2;
        }

        public static int SumRef(ref this int i1, ref int i2)
        {
            i1 += 2; 
            return i1 + i2;
        }
    }
}
