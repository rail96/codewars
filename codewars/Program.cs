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
            int[] newarr = new int[] { 1, 2, 0, 44, 3, 3 };
            
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < newarr.Length; i++)
            {
                if (!dic.ContainsKey(newarr[i]))
                    dic.Add(newarr[i], 1);
                else
                    dic[newarr[i]]++;
            }
            int key = dic.FirstOrDefault(x => x.Value == dic.Values.Max()).Key;

            /*
            var list = new List<int>();
            foreach(var el in newarr)
            {
                list.Add(el);
            }
            var most = list.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
            */
            Console.WriteLine(key);
        }
    }
}
