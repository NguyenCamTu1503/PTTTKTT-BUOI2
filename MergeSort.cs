using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            List<int> unsorted = new List<int>();
            List<int> sorted;

            Random random = new Random();

            Console.WriteLine("Sap xep Merge Sort: ");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("In mang ban dau: ");
            for (int i = 0; i < 10; i++)
            {
                unsorted.Add(random.Next(0, 100));
                Console.Write(unsorted[i] + " ");
            }
            Console.WriteLine();

            sorted = MergeSort(unsorted);

            Console.WriteLine("\nIn mang da qua sap xep: ");
            foreach (int x in sorted)
            {
                Console.Write(x + " ");
            }
            Console.Write("\n");

            Console.ReadKey();
        }

        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //chia danh sach chua qua sap xep  
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //so sanh hai phan tu dau tien  
                    {                                   //de xem phan tu nao nho hon
                        result.Add(left.First());
                        left.Remove(left.First());      //phan con lai cua list, ngoai tru  
                    }                                   //phan tu dau tien
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
