using System;

namespace findOne
{
    class MainClass
    {
        static int findSingle (int []ar, int ar_size)
        {
            int res = ar[0];
            for (int i = 1; i < ar_size; i++)
                res = res ^ ar[i];
            return res;
        }
        public static void Main(string[] args)
        {
            int[] ar = { 4, 3, 6, 4, 5, 2, 4 };
            int n = ar.Length;

            Console.WriteLine("Element showing up only once is " + findSingle(ar, n) +  "");
        }
    }
}
