using System;

namespace Span
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Span");

            /* for test choose option */
            const int OPTION = 5;

            switch (OPTION)
            {
                case 1:
                    SimpleArray();
                    break;
                case 2:
                    SliceOfArray();
                    break;
                case 3:
                    CopySpanToAnotherSpan(); 
                    break;
                case 4:
                    SpanToArrayTest();
                    break;
                case 5:
                    AlterPositionOfSpan();
                    break;                    
            }                      

            Console.ReadLine();
        }

        static void AlterPositionOfSpan()
        {
            Span<char> span = new char[] { 's', 'p', 'a', 'n' };
            
            ref char first = ref span[0];

            span[0] = 'S'; // or
            first = 'S';

            Console.WriteLine(span.ToArray());
        }

        static void SimpleArray()
        {
            Console.WriteLine();

            int[] arr = { 0, 1, 2, 3, 4, 5 };
            Span<int> span = arr.AsSpan();

            foreach (var number in span)
            {
                Console.WriteLine(number);
            }
        }

        static void SliceOfArray()
        {
            Console.WriteLine();

            int[] arr = { 0, 1, 2, 3, 4, 5 };
            Span<int> span = arr.AsSpan();
            Span<int> slice = span.Slice(1, 3);

            foreach (var i in slice)
            {
                Console.WriteLine(i);
            }
        }

        static void CopySpanToAnotherSpan()
        {
            Console.WriteLine();

            int[] arr = { 1, 2, 3, 4, 5 };
            Span<int> span = arr.AsSpan();

            var destination = new Span<int>(new int[arr.Length]);
            span.CopyTo(destination);

            span.Clear();

            Console.Write("Array:"); 
            foreach (var i in arr)
            {
                Console.Write(i);
            }

            Console.WriteLine();
            Console.Write("Span:");
            foreach (var i in span)
            {
                Console.Write(i);
            }

            Console.WriteLine();
            Console.Write("Destination Span:");
            foreach (var i in destination)
            {
                Console.Write(i);
            }

        }

        static void SpanToArrayTest()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Span<int> span = arr.AsSpan();

            var destination = new Span<int>(new int[arr.Length]);

            var newArray = span.ToArray();

            span.Clear();

            Console.Write("Array:");
            foreach (var i in arr)
            {
                Console.Write(i);
            }

            Console.WriteLine();
            Console.Write("Span:");
            foreach (var i in span)
            {
                Console.Write(i);
            }

            Console.WriteLine();
            Console.Write("New Array:");
            foreach (var i in newArray)
            {
                Console.Write(i);
            }
        }
    }
}
