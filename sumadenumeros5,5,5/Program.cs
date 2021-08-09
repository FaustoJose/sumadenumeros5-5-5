using System;

namespace sumadenumeros5_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(sumaNum(444488888848));
        }
        public static long sumaNum(long num)
        {
            string u;
            long a = 0;
            long res = 0;
            string numString = Convert.ToString(num);
            for (int i=0;i<=numString.Length-1;i++)
            {
                u = Convert.ToString(numString[i]);
                a = Convert.ToInt32(u);
                res = res + a;

            }
            return res;
        }
    }
}
