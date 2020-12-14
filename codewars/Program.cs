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
            //var simpleQueue = new Queue<int>();
            //simpleQueue.Enqueue(1);
            //simpleQueue.Enqueue(2);
            //simpleQueue.Enqueue(3);

            //var peek = simpleQueue.Peek();

            //simpleQueue.Dequeue();

            //Console.WriteLine(peek);

            //foreach (var item in simpleQueue)
            //{
            //    Console.WriteLine(item);
            //}
            int[] arr = new int[] { 0,1,0,1,0,1,99 };
            Console.WriteLine(Kata.SingleNumber3(arr));
            Console.ReadKey();
        }
    }
}
