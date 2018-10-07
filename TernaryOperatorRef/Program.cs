using System;

namespace TernaryOperatorRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TernaryOperatorRef");

            // ternary ref
            int i = 1;
            int j = 2;
            ref int k = ref (i != 0 ? ref i : ref j); 
            k = 10;

            Console.WriteLine($"The var {nameof(i)} was alter to : {i}");
            Console.WriteLine($"The var {nameof(j)} was alter to : {j}");

            // ternary ref


            // the return of ref ternary is referece, then we can set a value for it
            int a = 8;
            int b = 9;
            (a < 10 ? ref a : ref b) = 1;
            Console.WriteLine($"The var {nameof(a)} was alter to : {a}");
            Console.WriteLine($"The var {nameof(b)} was alter to : {b}");

            Console.ReadLine();
        }
    }
}
