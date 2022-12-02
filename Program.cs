namespace Generic
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("welcome to generic problem");
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            printarray1.toPrint(intArray);
            printarray1.toPrint(doubleArray);
            printarray1.toPrint(charArray);
        }
    }
}