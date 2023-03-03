using System;

    public class Program
    {
        public static void Main(string[] stringNums)
        {
            sbyte one = -128;
            short two = -32768;
            int three = 50000;
            long four = 4611686018427387904;
            byte five = 254;
            ushort six = 65534;
            uint seven = 4294967295;
            ulong eight = 18446744073709551615;

            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(three);
            Console.WriteLine(four);
            Console.WriteLine(five);
            Console.WriteLine(six);
            Console.WriteLine(seven);
            Console.WriteLine(eight);
            
            char nine = '\u00A9';
            char ten = '\u225B';
            char eleven = '\u2473';

            Console.WriteLine(nine);
            Console.WriteLine(ten);
            Console.WriteLine(eleven);

            bool boolOne = true;
            bool boolTwo = false;

            Console.WriteLine(boolOne);
            Console.WriteLine(boolTwo);
        }
    }
