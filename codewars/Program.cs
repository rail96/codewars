using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] nums = new int[4][];
            nums[0] = new int[4] {1, 2, 3, 4 };          // выделяем память для первого подмассива
            nums[1] = new int[4] {5, 6, 7, 8 };       // выделяем память для второго подмассива
            nums[2] = new int[4] { 9, 10, 11, 12};
            nums[3] = new int[4] { 13, 14, 15, 16};
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(nums[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Kata.Rotate(nums);
            Console.WriteLine();
        }
    }
}
