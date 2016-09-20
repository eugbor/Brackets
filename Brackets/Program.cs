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
            int [] nArray = new int[n];
            for (int i = 0; i < nArray.Length; i++)
                nArray[i] = 0;
            
            for (int i = 0; i < nArray.Length-1; i++)
            {
                nArray[i] = nArray[i] + 1;
                GetArray(nArray);
                
                for (int j = i+1; j < nArray.Length-1; j++)
                {
                    nArray[j] = nArray[j] + 1;
                    GetArray(nArray);
                    nArray[j] = 0;

                }
            }
        }

        
        public static void GetArray(int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            if (sum != list.Length/2){return;}

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
