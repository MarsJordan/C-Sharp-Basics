﻿using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int min = int.MaxValue;
            while (number != "Stop")
            {
                int input = int.Parse(number);

                if (input < min)
                {
                    min = input;
                }

                number = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
