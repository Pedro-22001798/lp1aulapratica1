using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Qual é a altura? ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o raio? ");
            float r = float.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(r,2) * a;
            double area = 2 * Math.PI * (Math.Pow(r,2) + r * a);
            Console.WriteLine($"Volume é {volume}");
            Console.WriteLine($"Area é {area}");
        }
    }
