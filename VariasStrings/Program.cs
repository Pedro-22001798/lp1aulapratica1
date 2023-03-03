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

            string six = "a" + 2;
            int x = 500;
            int y = 100;
            string seven = $"valor de x é {x}";
            string eight = $"valor de x + y = {x+y}";
            string nine = String.Format("Y é {1}, X é {0}", x,y);

            Console.WriteLine(six);
            Console.WriteLine(seven);
            Console.WriteLine(eight);
            Console.WriteLine(nine);
            Console.WriteLine(@"Verbatim com x = {0}",x);
        }
    }