using System;

    public class Program
    {
        public static void Main(string[] stringNums)
        {
            int x = int.Parse(stringNums[0]);
            x++;
            Console.WriteLine($"Result with ++ after x is = {x}");
            --x;
            Console.WriteLine($"Result with -- before x is = {x}");
        }
    }
