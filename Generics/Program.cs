using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find maximum Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(45,65,78);
            Console.WriteLine(output);
            double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(17.8, 24.67, 70.96);
            Console.WriteLine(doubleoutput);

        }
    }
}