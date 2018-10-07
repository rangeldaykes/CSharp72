using System;

namespace DigitSeparatorAfterBaseSpecifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DigitSeparatorAfterBaseSpecifier");

            // aesthetic change, before underscore only can use after first literal number  0b1_1
            var bin = 0b_11;
            Console.WriteLine($"{nameof(bin)} - {bin}");

            var hex = 0x_FF;
            Console.WriteLine($"{nameof(hex)} - {hex}");

            Console.ReadLine();
        }
    }
}
