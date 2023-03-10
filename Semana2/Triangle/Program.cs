using System;

    public class Program
    {
        public static void Main(string[] stringNums)
        {
            int quantity = int.Parse(stringNums[0]);
            string single = stringNums[1];
            
            for(int i = 1; i <= quantity; i++)
            {
                Console.WriteLine();
                for(int u = 0; u < i; u++)
                {
                    Console.Write(single);
                }
            }
        }
    }