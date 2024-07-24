using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class MultiLong
    {
        static void Main(string[] args)
        {
            long x = 12345678;
            long y = 87654321;
            int n = 8;
            long result = Big_Number_Multi(x, y, n);
            Console.WriteLine("Ket qua cua phep nhan hai so nguyen lon {0} x {1} = {2}", x, y, result);
            Console.ReadLine();
        }
        public static long Big_Number_Multi(long X, long Y, int n)
        {
            long m1, m2, m3, A, B, C, D;
            long s; // lưu dấu của tích XY
            s = sign(X) * sign(Y); // sign(X) trả về 1 nếu X dương; -1 là âm; 0 là X = 0
            X = Math.Abs(X);
            Y = Math.Abs(Y);
            if (n == 1) // X, Y có 1 chữ số
                return X * Y * s;
            else
            {
                A = left(X, n / 2); // số có n/2 chữ số đầu của X
                B = right(X, n / 2); // số có n/2 chữ số cuối của X
                C = left(Y, n / 2); // số có n/2 chữ số đầu của Y
                D = right(Y, n / 2); // số có n/2 chữ số cuối của Y
                m1 = Big_Number_Multi(A, C, n / 2);
                m2 = Big_Number_Multi(A - B, D - C, n / 2);
                m3 = Big_Number_Multi(B, D, n / 2);
                return s * (m1 * (long)Math.Pow(10, n) + (m1 + m2 + m3) * (long)Math.Pow(10, n / 2) + m3);
            }
        }

        private static long sign(long x)
        {
            if (x > 0)
                return 1;
            else if (x < 0)
                return -1;
            else
                return 0;
        }

        private static long left(long x, int n)
        {
            return x / (long)Math.Pow(10, n);
        }

        private static long right(long x, int n)
        {
            return x % (long)Math.Pow(10, n);
        }
    }
}
