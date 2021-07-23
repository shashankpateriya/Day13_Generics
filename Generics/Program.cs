using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find maximum Number");
            //int output = MaximumNumberCheck.MaximumIntegerNumber(45,65,78);
            //Console.WriteLine(output);
            //double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(17.8, 24.67, 70.96);
            //Console.WriteLine(doubleoutput);
            //string strigoutput = MaximumNumberCheck.MaximumStringNumber("potato", "onion", "Tomato");
            //Console.WriteLine(strigoutput);

            int[] intArray = { 7986, 4573, 536, 87, 34 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);

            double[] doubleArray = { 5.6, 458.5, 789.98, 538.79, 657.88 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);

            string[] stringArray = { "onion", "tomato", "potato", "bringal", "capsicum" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);

            Console.ReadKey();
        }
    }
}