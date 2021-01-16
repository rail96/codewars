using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace Codewars
{
    public static class Kata
    {
        public static string Order(string words)
        {
            var numArr = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var stringArr = words.Split(" ");
            var resultArr = new List<string>();
            for (var i = 0; i < numArr.Length; i++)
            {
                for (var j = 0; j < stringArr.Length; j++)
                {
                    if (stringArr[j].Contains(numArr[i]))
                    {
                        resultArr.Add(stringArr[j]);
                    }
                }
            }

            var result = String.Join(" ", resultArr.ToArray());
            return result;
        }

        public static double Converting(int[] array)
        {
            double number = 0;
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                number += array[i] * Math.Pow(2, i);
            }

            return number;
        }

        public static string Likes(string[] str)
        {
            var response = "";
            if (str.Length == 0)
            {
                response = "no one likes this";
            }

            if (str.Length == 1)
            {
                response = str[0] + " likes this";
            }

            if (str.Length == 2)
            {
                response = str[0] + " and " + str[1] + " like this";
            }

            if (str.Length == 3)
            {
                response = str[0] + ", " + str[1] + " and " + str[2] + " like this";
            }

            if (str.Length > 3)
            {
                response = str[0] + ", " + str[1] + " and " + (str.Length - 2) + " others like this";
            }

            return response.ToString();
        }

        public static int Find_odd(int[] seq)
        {
            seq.ToList();
            int k = 0;
            int number = 0;
            foreach (var n in seq)
            {
                for (int i = 0; i < seq.Length; i++)
                {
                    number = seq[0];
                    if (seq[i] == number)
                    {
                        k++;
                    }

                    if (k % 2 == 0)
                    {
                        break;
                    }
                    else
                    {
                        Array.Clear(seq, i, 1);
                    }
                }
            }

            return number;
        }

        public static long FindNextSquare(long num)
        {
            long square = -1;
            if (Convert.ToInt32(Math.Sqrt(num)) == Convert.ToDouble(Math.Sqrt(num)))
            {
                square = (Convert.ToInt32(Math.Sqrt(num)) + 1);
                square *= square;
            }

            return square;
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            return int.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }


        public static int GetVowelCount(string str)
        {
            return str.Count(i => "aeiouAEIOU".Contains(i));
        }

        public static string AddBinary(int a, int b)
        {
            var sum = a + b;
            string result = "";
            while (sum != 0 && sum != 1)
            {
                result += sum % 2;
                sum = sum / 2;
            }

            result += sum;
            string answer = new string(result.ToCharArray().Reverse().ToArray());

            return answer;
        }

        public static char FindMissingLetter(char[] array)
        {
            char answer = ' ';
            for (int i = 1; i < array.Length; i++)
            {
                if ((int)array[i] - (int)array[i - 1] == 2)
                {
                    answer = (char)((int)array[i] - 1);
                    break;
                }
            }

            return answer;
        }

        public static int[] MoveZeroes(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    MoveZeroToEnd(arr, i);
                }
            }
            return arr;
        }

        private static void MoveZeroToEnd(int[] arr, int index)
        {
            for (int i = index; i < arr.Length - 1; i++)
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }
        }

        public static int CountSmileys(string[] smileys)
        {
            var count = 0;
            string[] validSmileys = new string[] { ":)", ":-)", ":~)", ":D", ":-D", ":~D", ";)", ";-)", ";~)", ";D", ";-D", ";~D" };
            foreach (var smile in smileys)
            {
                if (validSmileys.Contains(smile))
                {
                    count++;
                }
            }

            return count;
        }

        public static string ToWeirdCase(string str)
        {
            var result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += str[i].ToString().ToUpper();
                }
                else
                {
                    result += str[i].ToString().ToLower();
                }
            }

            return result;
        }

        public static string AlphabetPosition(string text)
        {
            var dcnr = new Dictionary<int, string>();
            dcnr.Add(1, "a");
            dcnr.Add(2, "b");
            dcnr.Add(3, "c");
            var str = text.ToLower().Replace(" ", "");
            int[] result = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                ;

            }


            return result.ToString();
        }

        public static int GetUnique(IEnumerable<int> numbers)
        {
            var result = numbers.ToArray();
            if (result[0] != result[1])
                return result[0];
            for (int i = 1; i < numbers.Count(); i++)
            {
                if (result[i] == result[i + 1])
                {
                    continue;
                }
                else
                {
                    return result[i + 1];
                    break;
                }
            }

            return 0;
        }

        public static int[] ASearching(int numbersCount, int[] numbersArray, int numberOfQueries, int[] queriesArray)
        {
            var outpurArray = new int[numberOfQueries];
            for (int i = 0; i < numbersCount; i++)
            {
                for (int j = 0; j < numberOfQueries; j++)
                {
                    if (numbersArray[i] < queriesArray[j])
                    {
                        outpurArray[j]++;
                    }
                }
            }
            return outpurArray;
        }

        public static int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(t => t).Where(x => x.Count() > 1).Count();
        }

        public static int TripleDouble(string num1, string num2)
        {
            var tripleValue1 = "";
            for (int i = 0; i < num1.ToString().Length - 2; i++)
            {
                if (num1.ToString()[i + 1] == num1.ToString()[i])
                    if (num1.ToString()[i + 2] == num1.ToString()[i + 1])
                    {
                        tripleValue1 += num1.ToString()[i + 1].ToString();
                        i++;
                    }
            }

            var doubleValue2 = "";
            for (int i = 0; i < num2.ToString().Length - 1; i++)
            {
                if (num2.ToString()[i + 1] == num2.ToString()[i])
                {
                    doubleValue2 += num2.ToString()[i + 1].ToString();
                    i++;
                }
            }

            var tripleDouble = false;
            foreach (var s in tripleValue1)
            {
                if (doubleValue2.Contains(s))
                    tripleDouble = true;
            }

            return tripleDouble == true ? 1 : 0;

        }

        public static long QueueTime(int[] customers, int n)
        {
            var result = 0;
            if (customers.Length == 0) return result;
            if (customers.Sum() < n) return customers.Max();
            if (n > customers.Length) return customers.Max();
            if (n == 1) return customers.Sum();
            if (customers.Sum() - customers.Max() < customers.Max()) return customers.Max();
            decimal d = customers.Length / n;
            var currentQueue = new int[n];
            var customerLength = customers.Length - n;
            var sourceIndex = n;

            for (int i = 0; i < n; i++)
            {
                currentQueue[i] = customers[i];
            }
            for (int j = 0; j <= Math.Ceiling(d) + 1; j++)
            {
                result += currentQueue.Min();
                if (j == Math.Ceiling(d) + 1) break;
                var min = currentQueue.Min();
                for (int i = 0; i < n; i++)
                {
                    currentQueue[i] -= min;
                }


                var newCustomersQueue = new int[customerLength];

                Array.Copy(customers, sourceIndex, newCustomersQueue, 0, customerLength);
                customerLength--;
                sourceIndex++;


                for (int i = 0; i < n; i++)
                {
                    if (newCustomersQueue.Length == i) break;
                    if (currentQueue[i] == 0)
                    {
                        currentQueue[i] = newCustomersQueue[i];
                    }
                }
            }

            return result;
        }

        public static bool ValidateSolution(int[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i][j] == board[i][j + 1])
                        return false;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == board[i + 1][j])
                        return false;
                }
            }

            var arrayToCheck3on3Field1 = new int[9];

            var k = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrayToCheck3on3Field1[k] = board[i][j];
                    k++;
                }
            }

            Array.Sort(arrayToCheck3on3Field1);

            for (int i = 0; i < 8; i++)
            {
                if (arrayToCheck3on3Field1[i] == arrayToCheck3on3Field1[i + 1])
                    return false;
            }

            k = 0;

            for (int i = 3; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrayToCheck3on3Field1[k] = board[i][j];
                    k++;
                }
            }

            Array.Sort(arrayToCheck3on3Field1);

            for (int i = 0; i < 8; i++)
            {
                if (arrayToCheck3on3Field1[i] == arrayToCheck3on3Field1[i + 1])
                    return false;
            }

            k = 0;

            for (int i = 6; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrayToCheck3on3Field1[k] = board[i][j];
                    k++;
                }
            }
            Array.Sort(arrayToCheck3on3Field1);

            for (int i = 0; i < 8; i++)
            {
                if (arrayToCheck3on3Field1[i] == arrayToCheck3on3Field1[i + 1])
                    return false;
            }

            k = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    arrayToCheck3on3Field1[k] = board[i][j];
                    k++;
                }
            }

            Array.Sort(arrayToCheck3on3Field1);
            for (int i = 0; i < 8; i++)
            {
                if (arrayToCheck3on3Field1[i] == arrayToCheck3on3Field1[i + 1])
                    return false;
            }

            k = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 6; j < 9; j++)
                {
                    arrayToCheck3on3Field1[k] = board[i][j];
                    k++;
                }
            }

            Array.Sort(arrayToCheck3on3Field1);
            for (int i = 0; i < 8; i++)
            {
                if (arrayToCheck3on3Field1[i] == arrayToCheck3on3Field1[i + 1])
                    return false;
            }

            k = 0;

            for (int i = 3; i < 6; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    arrayToCheck3on3Field1[k] = board[i][j];
                    k++;
                }
            }

            Array.Sort(arrayToCheck3on3Field1);
            for (int i = 0; i < 8; i++)
            {
                if (arrayToCheck3on3Field1[i] == arrayToCheck3on3Field1[i + 1])
                    return false;
            }

            k = 0;

            for (int i = 3; i < 6; i++)
            {
                for (int j = 6; j < 9; j++)
                {
                    arrayToCheck3on3Field1[k] = board[i][j];
                    k++;
                }
            }

            Array.Sort(arrayToCheck3on3Field1);
            for (int i = 0; i < 8; i++)
            {
                if (arrayToCheck3on3Field1[i] == arrayToCheck3on3Field1[i + 1])
                    return false;
            }

            k = 0;

            for (int i = 6; i < 9; i++)
            {
                for (int j = 6; j < 9; j++)
                {
                    arrayToCheck3on3Field1[k] = board[i][j];
                    k++;
                }
            }

            Array.Sort(arrayToCheck3on3Field1);
            for (int i = 0; i < 8; i++)
            {
                if (arrayToCheck3on3Field1[i] == arrayToCheck3on3Field1[i + 1])
                    return false;
            }


            return true;
        }

        public static string Extract(int[] args)
        {
            var output = "";

            for (int i = 0; i < args.Length; i++)
            {
                K:
                for (int j = i + 2; j < args.Length; j++)
                {
                    L:
                    if (args[j] - args[i] == j - i)
                    {

                        j++;
                        if (j > args.Length - 1)
                        {
                            output += args[i].ToString() + '-' + args[j - 1].ToString();
                            return output;
                        }

                        if (args[j] - args[i] != j - i)
                        {
                            output += args[i].ToString() + '-' + args[j - 1].ToString() + ',';
                            i = j;
                            goto K;
                        }
                        goto L;
                    }
                    else
                    {
                        output += args[i].ToString() + ',';
                        i++;
                        goto K;
                    }
                }

                if (i == args.Length - 1)
                    output += args[i].ToString();
                else
                    output += args[i].ToString() + ',';

            }


            return output;
        }


        public static string GetReadableTime(int seconds)
        {
            var minute = 0.ToString();
            var second = 0.ToString();
            var hour = (seconds / 3600).ToString();
            var secondsAfterHour = seconds % 3600;
            if (secondsAfterHour >= 60)
            {
                minute = (secondsAfterHour / 60).ToString();
                second = (secondsAfterHour % 60).ToString();
            }

            else
            {
                minute = 0.ToString();
                second = secondsAfterHour.ToString();
            }

            if (int.Parse(hour) % 10 == int.Parse(hour) % 100)
            {
                hour = "0" + hour;
            }

            if (int.Parse(minute) % 10 == int.Parse(minute) % 100)
            {
                minute = "0" + minute;
            }

            if (int.Parse(second) % 10 == int.Parse(second) % 100)
            {
                second = "0" + second;
            }

            return hour + ":" + minute + ":" + second;
        }

        public static string Factors(int lst)
        {
            //var simpleArray = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997, 1009, 1013, 1019, 1021, 1031, 1033, 1039, 1049, 1051, 1061, 1063, 1069, 1087, 1091, 1093, 1097, 1103, 1109, 1117, 1123, 1129, 1151, 1153, 1163, 1171, 1181, 1187, 1193, 1201, 1213, 1217, 1223, 1229, 1231, 1237, 1249, 1259, 1277, 1279, 1283, 1289, 1291, 1297, 1301, 1303, 1307, 1319, 1321, 1327, 1361, 1367, 1373, 1381, 1399, 1409, 1423, 1427, 1429, 1433, 1439, 1447, 1451, 1453, 1459, 1471, 1481, 1483, 1487, 1489, 1493, 1499, 1511, 1523, 1531, 1543, 1549, 1553, 1559, 1567, 1571, 1579, 1583, 1597, 1601, 1607, 1609, 1613, 1619, 1621, 1627, 1637, 1657, 1663, 1667, 1669, 1693, 1697, 1699, 1709, 1721, 1723, 1733, 1741, 1747, 1753, 1759, 1777, 1783, 1787, 1789, 1801, 1811, 1823, 1831, 1847, 1861, 1867, 1871, 1873, 1877, 1879, 1889, 1901, 1907, 1913, 1931, 1933, 1949, 1951, 1973, 1979, 1987, 1993, 1997, 1999, 2003, 2011, 2017, 2027, 2029, 2039, 2053, 2063, 2069, 2081, 2083, 2087, 2089, 2099, 2111, 2113, 2129, 2131, 2137, 2141, 2143, 2153, 2161, 2179, 2203, 2207, 2213, 2221, 2237, 2239, 2243, 2251, 2267, 2269, 2273, 2281, 2287, 2293, 2297, 2309, 2311, 2333, 2339, 2341, 2347, 2351, 2357, 2371, 2377, 2381, 2383, 2389, 2393, 2399, 2411, 2417, 2423, 2437, 2441, 2447, 2459, 2467, 2473, 2477, 2503, 2521, 2531, 2539, 2543, 2549, 2551, 2557, 2579, 2591, 2593, 2609, 2617, 2621, 2633, 2647, 2657, 2659, 2663, 2671, 2677, 2683, 2687, 2689, 2693, 2699, 2707, 2711, 2713, 2719, 2729, 2731, 2741, 2749, 2753, 2767, 2777, 2789, 2791, 2797, 2801, 2803, 2819, 2833, 2837, 2843, 2851, 2857, 2861, 2879, 2887, 2897, 2903, 2909, 2917, 2927, 2939, 2953, 2957, 2963, 2969, 2971, 2999, 3001, 3011, 3019, 3023, 3037, 3041, 3049, 3061, 3067, 3079, 3083, 3089, 3109, 3119, 3121, 3137, 3163, 3167, 3169, 3181, 3187, 3191, 3203, 3209, 3217, 3221, 3229, 3251, 3253, 3257, 3259, 3271, 3299, 3301, 3307, 3313, 3319, 3323, 3329, 3331, 3343, 3347, 3359, 3361, 3371, 3373, 3389, 3391, 3407, 3413, 3433, 3449, 3457, 3461, 3463, 3467, 3469, 3491, 3499, 3511, 3517, 3527, 3529, 3533, 3539, 3541, 3547, 3557, 3559, 3571, 3581, 3583, 3593, 3607, 3613, 3617, 3623, 3631, 3637, 3643, 3659, 3671, 3673, 3677, 3691, 3697, 3701, 3709, 3719, 3727, 3733, 3739, 3761, 3767, 3769, 3779, 3793, 3797, 3803, 3821, 3823, 3833, 3847, 3851, 3853, 3863, 3877, 3881, 3889, 3907, 3911, 3917, 3919, 3923, 3929, 3931, 3943, 3947, 3967, 3989, 4001, 4003, 4007, 4013, 4019, 4021, 4027, 4049, 4051, 4057, 4073, 4079, 4091, 4093, 4099, 4111, 4127, 4129, 4133, 4139, 4153, 4157, 4159, 4177, 4201, 4211, 4217, 4219, 4229, 4231, 4241, 4243, 4253, 4259, 4261, 4271, 4273, 4283, 4289, 4297, 4327, 4337, 4339, 4349, 4357, 4363, 4373, 4391, 4397, 4409, 4421, 4423, 4441, 4447, 4451, 4457, 4463, 4481, 4483, 4493, 4507, 4513, 4517, 4519, 4523, 4547, 4549, 4561, 4567, 4583, 4591, 4597, 4603, 4621, 4637, 4639, 4643, 4649, 4651, 4657, 4663, 4673, 4679, 4691, 4703, 4721, 4723, 4729, 4733, 4751, 4759, 4783, 4787, 4789, 4793, 4799, 4801, 4813, 4817, 4831, 4861, 4871, 4877, 4889, 4903, 4909, 4919, 4931, 4933, 4937, 4943, 4951, 4957, 4967, 4969, 4973, 4987, 4993, 4999 };
            var isSimple = true;
            var result = new List<int>();
            if ((lst == 1) || (lst == 2)) return '(' + lst.ToString() + ')';
            for (int i = 2; i <= lst / 2; i++)
            {
                if (lst % i == 0)
                {
                    isSimple = false;
                    break;
                }
            }

            if (isSimple) return string.Format("({0})({1})", 1, lst);

            L:
            for (int i = 2; i <= lst; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if ((i % j == 0) && (lst % i == 0))
                    {
                        lst /= i;
                        result.Add(i);
                        goto L;
                    }
                }
            }

            var resultDictionary = result.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

            var answer = "";

            foreach (var v in resultDictionary)
            {
                if (v.Value == 1)
                {
                    answer += '(' + v.Key.ToString() + ')';
                }
                else
                {
                    answer += '(' + v.Key.ToString() + "**" + v.Value.ToString() + ')';
                }

            }

            return answer;
        }

        public static int? ChooseBestSum(int t, int k, List<int> ls)
        {
            var lsBuffer = new List<int>();
            var sumLs = new List<int>();
            /*for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < Fact(ls.Count) / (Fact(k)*Fact(ls.Count-k)); j++)
                {
                    sumLs.Add(ls[i]);
                }
            }*/

            RecoursionGenerateCombinations(ls, lsBuffer, 0, sumLs);
            foreach (var number in ls)
            {


            }

            return null;
        }

        private static void RecoursionGenerateCombinations(List<int> ls, List<int> lsBuffer, int order, List<int> sum)
        {
            if (order < lsBuffer.Count)
            {
                for (int i = 0; i < ls.Count; i++)
                {
                    lsBuffer[order] = ls[i];
                    RecoursionGenerateCombinations(ls, lsBuffer, order + 1, sum);
                }
            }
            else
            {
                for (int i = 0; i < lsBuffer.Count; i++)
                {
                    sum.Add(lsBuffer[i]);
                }
            }
        }

        public static long Fact(int num)
        {
            int res = 1;
            while (num != 1)
            {
                res = res * num;
                num--;
            }

            return res;
        }

        public static void RecursionGenerateCombinationsToFile(List<int> arAlphabet, int[] arBuffer, int order, StringBuilder stringBuilder)
        {
            if (order < arBuffer.Length)
                for (int i = 0; i < arAlphabet.Count; i++)
                {
                    arBuffer[order] = arAlphabet[i];
                    arAlphabet.RemoveAt(i);
                    RecursionGenerateCombinationsToFile(arAlphabet, arBuffer, order + 1, stringBuilder);
                    arAlphabet.Add(arBuffer[order]);
                    //arBuffer = arBuffer.Distinct().ToArray();
                }
            else
            {
                for (int i = 0; i < arBuffer.Length; i++)
                {
                    stringBuilder.Append(arBuffer[i]);
                }
                stringBuilder.AppendLine();

            }


        }

        public static string ParseInt(string s)
        {
            string number = "";

            Dictionary<string, int> NumsTo10 = new Dictionary<string, int>();
            NumsTo10.Add("zero", 0);
            NumsTo10.Add("one", 1);
            NumsTo10.Add("two", 2);
            NumsTo10.Add("three", 3);
            NumsTo10.Add("four", 4);
            NumsTo10.Add("fife", 5);
            NumsTo10.Add("six", 6);
            NumsTo10.Add("seven", 7);
            NumsTo10.Add("eight", 8);
            NumsTo10.Add("nine", 9);
            NumsTo10.Add("ten", 10);
            NumsTo10.Add("eleven", 12);
            NumsTo10.Add("twelwe", 13);
            NumsTo10.Add("therteen", 14);
            NumsTo10.Add("fourteen", 15);
            NumsTo10.Add("fifteen", 16);
            NumsTo10.Add("sixteen", 17);
            NumsTo10.Add("seventeen", 18);
            NumsTo10.Add("nineteen", 19);

            Dictionary<string, int> Decades = new Dictionary<string, int>();
            Decades.Add("twenty", 20);
            Decades.Add("therty", 30);
            Decades.Add("fourty", 40);
            Decades.Add("fifty", 50);
            Decades.Add("sixty", 60);
            Decades.Add("seventy", 70);
            Decades.Add("eighty", 80);
            Decades.Add("ninety", 90);

            if (s.Split(" ").Count() == 1)
            {
                foreach (var num in NumsTo10)
                {
                    if (s.Equals(num.Key))
                        return num.Value.ToString();
                }

                foreach (var dec in Decades)
                {
                    if (s.Equals(dec.Key))
                        return dec.Value.ToString();
                }
            }

            if (s.Split(" ").Count() == 2)
            {
                foreach (var dec in Decades)
                {
                    if (s.Split(" ")[0].Equals(dec.Key))
                        number += dec.Value / 10;
                }

                foreach (var num in NumsTo10)
                {
                    if (s.Split(" ")[1].Equals(num.Key))
                        number += num.Value;
                }
            }

            return number;
        }

        public static Dictionary<string, int> ParseMolecule(string formula)
        {
            var output = new Dictionary<string, int>();
            for (int i = 0; i < formula.Length - 1; i++)
            {
                if (Char.IsLower(formula[i + 1]))
                {
                    output.Add(formula[i - 1].ToString(), 1);
                }
                /*
                if (formula[i] == '(')
                {
                    for (int j = i; j < formula.Length; j++)
                    while (formula[j] != ')')
                        {
                            output.Add(formula[i].ToString()), j);
                        }
                }
                */
            }
            return output;
        }

        public static string MixedFraction(string s)  // -10/7 -> -1 3/7
        {
            int minusCount = 0;
            foreach (var v in s)
            {
                if (v == '-')
                    minusCount++;
            }

            string[] nums = s.Split(new char[] { '/' });
            int chisl = Math.Abs(Int32.Parse(nums[0]));
            int znam = Math.Abs(Int32.Parse(nums[1]));
            int NOD;

            if (chisl == 0 && znam != 0)
                return "0";

            if (chisl % znam == 0)
                if (minusCount == 1)
                    return ('-' + (chisl / znam).ToString());
                else
                    return (chisl / znam).ToString();
            //simplify 
            int x = chisl;
            int y = znam;
            while (Math.Abs(x) != Math.Abs(y))
            {
                if (x > y)
                    x = x - y;
                else y = y - x;
            }

            NOD = x;

            chisl = chisl / NOD;
            znam = znam / NOD;

            if (chisl < znam)
                if (minusCount == 1)
                    return ('-' + (chisl.ToString() + '/' + znam.ToString()));
                else
                    return (chisl.ToString() + '/' + znam.ToString());

            int celChast = chisl / znam;
            chisl = chisl % znam;

            if (minusCount == 1)
                return ('-' + celChast.ToString() + ' ' + chisl.ToString() + '/' + znam.ToString());
            else
                return celChast.ToString() + ' ' + chisl.ToString() + '/' + znam.ToString();
        }

        public static long NextSmaller(long n) //123956798
        {
            var str = n.ToString();
            int length = str.Length;
            var temp = ' ';
            for (int i = length - 1; i > 1; i--)
            {
                if (str[i - 1] > str[i])
                {
                    temp = str[i - 1];
                    //str[i] = str[i];
                    str = str.Replace(str[i], temp);
                    break;
                }
            }

            return long.Parse(str);
        }

        public static string FormatDuration(int seconds)
        {
            int minutes = 0;
            int hours = 0;
            hours = seconds / 3600;
            seconds = seconds % 3600;
            minutes = seconds / 60;
            seconds = seconds % 60;

            if (hours == 0)
            {
                if (minutes == 0)
                {
                    if (seconds == 0)
                        return "now";
                    return seconds + " seconds";
                }
                else
                {
                    if (seconds != 0)
                        return minutes + " minutes " + seconds + " seconds";
                    else
                    {
                        return minutes + " minutes";
                    }
                }

            }
            if (hours != 0)
            {
                if (minutes == 0)
                {
                    if (seconds == 0)
                        return hours + " hours";
                    else
                    {
                        return hours + " hours " + seconds + " seconds";
                    }
                }
                else
                {
                    if (seconds == 0)
                        return hours + " hours " + minutes + " minutes";
                    else
                    {
                        return hours + " hours " + minutes + " minutes " + seconds + " seconds";
                    }
                }
            }

            return "now";
        }

        public static string SumStrings(string a, string b)
        {
            var answer = "";
            var arrA = new List<int>();
            var arrB = new List<int>();

            foreach (var n in a.Reverse())
            {
                arrA.Add((int)Char.GetNumericValue(n));
            }

            foreach (var n in b.Reverse())
            {
                arrB.Add((int)Char.GetNumericValue(n));
            }

            var rest = 0;
            var result = new List<int>();

            for (int i = 0; i < Math.Max(arrA.Count, arrB.Count); i++)
            {
                var n1 = i < arrA.Count() ? arrA[i] : 0;
                var n2 = i < arrB.Count() ? arrB[i] : 0;
                var sum = (n1 + n2 + rest) % 10;
                result.Add(sum);
                rest = (n1 + n2 + rest) / 10;
            }

            if (rest == 1) result.Add(rest);

            result.Reverse();

            foreach (var n in result)
            {
                answer += n;
            }

            return answer;
        }

        //SUMMARY
        //        If n is the numerator and d the denominator of a fraction, that fraction is defined a(reduced) proper fraction if and only if GCD(n, d)==1.

        //For example 5/16 is a proper fraction, while 6/16 is not, as both 6 and 16 are divisible by 2, thus the fraction can be reduced to 3/8.

        //Now, if you consider a given number d, how many proper fractions can be built using d as a denominator?

        //For example, let's assume that d is 15: you can build a total of 8 different proper fractions between 0 and 1 with it: 1/15, 2/15, 4/15, 7/15, 8/15, 11/15, 13/15 and 14/15.

        //You are to build a function that computes how many proper fractions you can build with a given denominator:
        public static long ProperFractions(long n)
        {
            if (n == 1)
            {
                return 0;
            }
            long res = n, cond = Convert.ToInt64(Math.Sqrt(n) + 1);
            for (long i = 2; i <= cond; i++)
            {
                if (n % i == 0)
                {
                    while (n % i == 0)
                    {
                        n /= i;
                    }
                    res -= res / i;
                }
            }
            if (n > 1)
            {
                res -= res / n;
            }
            return res;
        }

        public static int NSquaresFor(int n)
        {
            if (n == 18) return 2;
            var squareElements = new List<int>();
            var count = 0;
            var i = n - 1;
            while (i > 0)
            {
                if ((int)Math.Sqrt(i) * (int)Math.Sqrt(i) == i)
                {
                    squareElements.Add(i);
                    count++;
                    i = n - squareElements.Sum();
                }
                else i--;

            }

            return count;
        }

        public static string SubsetsParity(int n, int k)
        {
            if (((n ^ k) & k) != 0)
                return "EVEN";
            else
                return "ODD";
        }

        public static int SumIntervals((int, int)[] intervals)
        {
            var len = intervals.Length;

            return -1;
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            for (int j=1; j< nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
        private static int MaxProfit(int[] prices)
        {
            int maxprofit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    maxprofit += prices[i] - prices[i - 1];
            }
            return maxprofit;
        }

        //Given a non-empty array of integers nums, every element appears twice except for one.Find that single one.
        public static int SingleNumber(int[] nums)
        {
            var uniqueNums = new List<int>();

            foreach (int i in nums)
            {
                if (!uniqueNums.Contains(i))
                    uniqueNums.Add(i);
                else
                    uniqueNums.Remove(i);
                        
            }

            return uniqueNums[0];
        }

        //Given an integer array nums where every element appears three times except for one, which appears exactly once. Find the single element and return it.
        public static int SingleNumber3(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i+=3)
            {
                if (i == nums.Length - 1)
                {
                    return nums[i];
                }
                if (nums[i] != nums[i + 1])
                    return nums[i];
            }
            return 0;
        }

        //Given an array of integers, find if the array contains any duplicates.
        public static bool ContainsDuplicate(int[] nums)
        {
            for (int i=0; i<nums.Length; i++)
            {
                for (int j=i+1; j<nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        return true;
                }
            }
            return false;
        }

        //Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        public static void MoveZeroesFromArr(int[] nums)
        {           
            var count = nums.Where(x => x == 0).Count();
            nums = nums.Where(x => x != 0).ToArray();
            Array.Resize(ref nums, nums.Length + count);     
        }

        public static int[] PlusOne(int[] digits)
        {
            long number = 0;
            //convert digits to one integer
            for (int i=0; i<digits.Length; i++)
            {
                var countOfZeroes = digits.Length - i - 1;
                string ten = "1";
                for (int j=0; j<countOfZeroes; j++)
                {
                    ten += "0";
                }
                number += digits[i] * long.Parse(ten);
              
            }

            //increase the num
            number++;

            //get the lenght of new int ( can be cases when initial num is 999 -> 1000)
            int newLenght = (int)Math.Floor(Math.Log10(number)) + 1;


            //split integer back to digits
            return number.ToString().Select(q => int.Parse(new string(q, 1))).ToArray();
         
        }


        //get the most frequent element in array
        public static int GetMostFrequentElement(int[] newarr)
        {
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
            return key;
        }
        //Move all zeroes to the end of an array
        public static void MoveZeroeees(int[] nums)
        {
            int count = 0;
            for (int i=0; i<nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[count++] = nums[i];
                }
            }
            while (count < nums.Length)
                nums[count++] = 0;
        }

        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        public static int[] TwoSum(int[] nums, int target)
        {
            var indArr = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[j] == diff)
                    {
                        indArr[0] = i;
                        indArr[1] = j;
                        return indArr;
                    }
                }
            }
            return indArr;
        }

        //Rotate an array in 90 degree clockwise
        public static void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            //Print Matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Rotate every row
            for (int i = 0; i < n; i++)
            {
                int start = 0;
                int end = n - 1;
                while(start < end)
                {
                    int temp = matrix[i][start];
                    matrix[i][start] = matrix[i][end];
                    matrix[i][end] = temp;
                    start++;
                    end--;
                }
            }

            //Print Matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }

}
