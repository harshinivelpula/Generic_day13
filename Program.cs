namespace Generic
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {2000,1999,1998};
            GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            generic.PrintMaxValue();

        }
    }
}