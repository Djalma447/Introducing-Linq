﻿using System;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
