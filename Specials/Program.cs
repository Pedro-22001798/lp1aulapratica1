﻿using System;

    public class Program
    {
        public static void Main()
        {
            double x = double. PositiveInfinity;
            double y = double. NegativeInfinity;
            float w = float.NaN;

            Console.WriteLine($"X value is {x}");
            Console.WriteLine($"Y value is {y}");
            Console.WriteLine($"W value is {w}");

            int i = short.MaxValue;
            Console.WriteLine(( short) ( i + 1));
        }
    }