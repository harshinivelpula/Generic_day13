using System.Collections;

namespace Generic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to generic problem");
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            arraygenerics.toPrint(intArray);
            arraygenerics.toPrint(doubleArray);
            arraygenerics.toPrint(charArray);
        }
    }
}