using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int n = 12, key = 24, y = 6;
            int[] Array = { 1, 2, 3, 4, 5, 5, 7, 9, 13, 24, 27, 28 };
            int result = Binary_Search(Array, n, key);
            Console.WriteLine(result);
            result = Binary_Search(Array, n, y);
            Console.WriteLine(result);
        }
        public static int Binary_Search(int[] A, int n, int key)
        {
            int left = 0;
            int right = n - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (A[mid] == key)
                {
                    return mid;
                }
                else if (key < A[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
