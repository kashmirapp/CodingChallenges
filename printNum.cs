using System;
using System.Collections.Generic;

namespace alternatesolution
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = { 5, 10, 2, 3, 4, 5, 6, 7 };
            int x = array.Length;
            printNums(array, x);

        }

        private static void printNums(object array, int x)
        {
            throw new NotImplementedException();
        }

        static void printNums(int[] array, int x)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < x; i++)
            {
                if (map.ContainsKey(array[i]))
                {
                    var elements = map[array[i]];
                    map.Remove(array[i]);
                    map.Add(array[i], elements + 1);
                }
                else
                {
                    map.Add(array[i], 1);
                }
            }
            foreach (KeyValuePair<int, int> a in map)
            {
                if (a.Value > 1)
                {
                    Console.WriteLine(a.Key + "");
                }
            }

        }

    }
}
