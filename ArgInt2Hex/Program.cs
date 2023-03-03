using System;

    public class Program
    {
        public static void Main(string[] stringNums)
        {
            foreach(string s in stringNums)
            {
                int num;
                bool checkInt = int.TryParse(s, out num);

                if(checkInt)
                {
                    string numHex = num.ToString("X");
                    Console.WriteLine($"{num} -> é um número inteiro. Hexa = {numHex}.");
                }
                else
                {
                    Console.WriteLine($"{s} -> não é um número inteiro.");
                }
            }
        }
    }