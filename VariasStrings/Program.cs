using System;

    public class Program
    {
        public static void Main(string[] stringNums)
        {
            string one = "simples";
            string two = "\n";
            string three = @"Não é um codigo Unicode \u1234, não é' nova linha \n";
            string four = @"""Esta string esta entre aspas""";
            string five = "Esta string não está entre aspas";

            Console.WriteLine(two);
            Console.WriteLine(one);
            Console.WriteLine(three);
            Console.WriteLine(four);
            Console.WriteLine(five);
        }
    }