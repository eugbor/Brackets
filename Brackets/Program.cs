using System;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (!(n <= 20 && n%2==0)) {Console.WriteLine("Your number is not correct!"); Console.ReadKey(); return;}
            GetNumber(n);
            Console.ReadLine();
        }

        public static void GetNumber(int n)
        {
            int[] nArray1 = new int[n];
            for (int i = 1; i < nArray1.Length; i++)
            {
                nArray1[i] = 0;
            }
            int[] nArray2 = new int[n];
            for (int i = 1; i < nArray2.Length; i++)
            {
                nArray2[i] = 0;
            }
            nArray2[0] = 1;
            int sum = 0;
            while (sum != n)
            {
                for (int i = 0; i < nArray1.Length; i++)
                {
                    nArray1[i] = nArray1[i] + nArray2[i];
                    if (nArray1[nArray1.Length - 1] == 2) {nArray1[nArray1.Length - 1]=0;}
                    if (nArray1[i] == 2)
                    {
                        nArray1[i] = 0;
                        nArray1[i + 1] = nArray1[i + 1] + 1;
                    }
                }
                GetArray(nArray1);
                sum = 0;
                for (int i = 0; i < nArray1.Length; i++)
                {
                    sum += nArray1[i];
                }
            }
        }

        public static void GetArray(int[] list)
        {
            int sum1 = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum1 += list[i];
            }
            
            if (sum1 != list.Length / 2) { return; }
            if (list[0] == 0 || list[list.Length - 1] == 1) { return; }

            int[] nArray3 = new int[list.Length];
            int t = 0;
            int r = 0;
            for (int i = 0; i < nArray3.Length; i++)
            {
                nArray3[i] = list[i];
                if (nArray3[i] == 1) {t++;}
                if (nArray3[i] == 0) {r++;}
                if (t < r) { return; }
            }
            

            char[] ch = new char[list.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = char.Parse(list[i].ToString());
            }
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '0')
                    ch[i] = ')';
                if (ch[i] == '1')
                    ch[i] = '(';

            }
            for (int i = 0; i < ch.Length; i++)
            {
                Console.Write("{0}", ch[i]);
            }
            Console.WriteLine();
        }
    }
}
