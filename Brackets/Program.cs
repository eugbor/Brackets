using System;

namespace Brackets
{
    class Program
    {/// <summary>
     /// Комбинаторный алгоритм.
     /// </summary>
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (!(n <= 20 && n%2==0)) {Console.WriteLine("Your number is not correct!"); Console.ReadKey(); return;}
            GetNumber(n);
            Console.ReadLine();
        }

        public static void GetNumber(int n)
        {
            int[] nArray = new int[n];

            double countItteration = Math.Pow(2, n);
            while (countItteration-- >= 0)
            {
                nArray[0] += 1;

                for (int i = 0; i < nArray.Length - 1; i++)
                {
                    nArray[i + 1] += nArray[i]/2;
                    nArray[i] = nArray[i]%2;
                }
                
                GetArray(nArray);
            }
        }

        public static void GetArray(int[] list)
        {

            int countOpened = 0;
            foreach (int i in list)
            {
                countOpened += i == 1 ? 1 : -1;
                if (countOpened < 0)
                    return;
            }
            
            if (countOpened != 0)
                return;
            
            foreach (int item in list)
            {
                if (item == 0)
                    Console.Write(')');
                if (item == 1)
                    Console.Write('(');
            }
            Console.WriteLine();
            
        }
    }
}
