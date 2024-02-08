using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace bsuirTesting
{
    static class ExtClass
    {
        public static void NewMethod(this string str )
        {

        }
    }

    internal class Program
    {
        public static class myClass
        {
            public static double calclulate(double x)
            {
                if (x == 1)
                {
                    return 4;
                }
                return (Math.Pow(x + 1, 2) / x) + myClass.calclulate(x - 1);
            }
            public static int FindMax(int i, int[] arr)
            {
                if (i == 9)
                {
                    return arr[i];
                }

                if (arr[i] > FindMax(i + 1, arr))
                {
                    return arr[i];

                }
                else
                {
                    return FindMax(i + 1, arr);
                }

            }
            public static double CalcSummAll(int i, int[] arr)
            {

                if (i == 9)
                {
                    return arr[i];
                }

                return arr[i] + CalcSummAll(i + 1, arr);
            }
            public static void SortArray(int[] arr)
            {
                int tmpVal;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for ( int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] < arr[i])
                        {
                            tmpVal = arr[i];
                            arr[i] = arr[j];
                            arr[j] = tmpVal;
                        }
                    }
                }
            }
            public static double Sum<TVal1, TVal2>(TVal1 a, TVal2 b)
            {
                
                double result = Convert.ToDouble(a) + Convert.ToDouble(b);

                return result;

            }
        }
        
        static void Main(string[] args)
        {
            double res = myClass.Sum(1.2, "2");

            int n = 50;
            int randomRange = 100;
            int[] myArray = new int[n];
            double sum = 0;


            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                myArray[i] = rnd.Next(1, randomRange);
            }

            myClass.SortArray(myArray);



            for (int i = 0; i < n; i++)
            {
                sum += myArray[i];
            }
            sum = 0;
            sum = myClass.CalcSummAll(0, myArray);

            int maxVal = 0;
            for (int i = 0; i < n; i++)
            {
                if (maxVal < myArray[i])
                {
                    maxVal = myArray[i];
                }
            }
            Console.WriteLine(maxVal);
            int r = myClass.FindMax(0, myArray);


            double S = 0;
            double R = 0;

            for (int i = 1; i <= 10; i++)
            {
                S += Math.Pow(i + 1, 2) / i;
            }

            Console.WriteLine(S);

            R = myClass.calclulate(n);

            Console.WriteLine(R);
        }
    }
}
