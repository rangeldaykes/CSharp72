using System;

namespace Parameter_In
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DefaultLiteralExpressions");

            int number = 8;
            ParameterByValue(number); // Copy value to method
            Console.WriteLine(number); // print = 8

            ParameterByReference(ref number); // send reference
            Console.WriteLine(number); // 18

            // not need write parameter in to argumente (method call) (is optional)
            ParameterByReferenceReadOnly(number); // send reference but readonly
            Console.WriteLine(number); // 18

            Console.ReadLine();
        }

        static void ParameterByValue(int n) => n += 10;

        static void ParameterByReference(ref int n) => n += 10;

        static void ParameterByReferenceReadOnly(in int n)
        {
            // n += 10 // parameter in not be set 
            Console.WriteLine(n);
        }
    }
}
