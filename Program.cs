namespace Generic
{
    class Program
    {
        public static void Main(string[] args)
        {
            int intArray = Refactors<int>.MaximumValue(8,11,28);
            Console.WriteLine("\nMax integer number is: " + intArray);

            double output = Refactors<double>.MaximumValue(12.6,13.8,18.20);
            Console.WriteLine("\nMax floating number is: " + output);

            char strArr = Refactors<char>.MaximumValue('s','h','k');
            Console.WriteLine("\nMax string is: " + strArr);
        }
    }
}