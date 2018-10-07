using System;

namespace ReadOnlySpan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReadOnlySpan");

            /* for test choose option */
            const int OPTION = 1;

            switch (OPTION)
            {
                case 1:
                    StringSimple();
                    break;

            }

            Console.ReadLine();
        }

        static void StringSimple()
        {
            string t = "Strings in .NET are immutable";
            ReadOnlySpan<char> fromString = t.AsSpan(); // or
            ReadOnlySpan<char> newFromString = new ReadOnlySpan<char>(t.ToCharArray());

            // fromString[0] = 'W'; error ReadOnlySpan is immutable

            Console.WriteLine(fromString.ToArray());
        }
    }
}
