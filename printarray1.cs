using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class printarray1
    {
        public static void toPrint(int[] inputArray)
        {
            foreach (int element in inputArray)
            {
                System.Console.WriteLine(element);
            }
            Console.WriteLine("------------------------  ");
        }

        public static void toPrint(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("------------------------ ");
        }

        public static void toPrint(char[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("------------------------");
        }
    }
}
