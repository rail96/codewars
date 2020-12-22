using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
            Kata.PlusOne(arr);
            Console.ReadKey();
        }
    }
}
