using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class Program
    {
        static int array_result_min(int[] A, int max, int min, int max_key, int min_key)
        {
            for (int i = 0; i < 10; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                    min_key = i;
                }
            }
            return min_key;
        }
        static int array_result_max(int[] A, int max, int min, int max_key, int min_key)
        {
            for (int i = 0; i < 10; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                    max_key = i;
                }
            }
            return max_key;
        }
        static int output(int[] A)
        {
            Console.Write("Array: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("[" + i + "] " + A[i] + "   ");
            }
            return 1;
        }

        static void Main(string[] args)
        {
            //-------Done-------
            int[] A = { 46, 22, 39, 45, 94, 69, 53, 23, 57, 79 };
            //-------Random-------
            //int Min_Rand = 0;
            //int Max_Rand = 100;
            //int[] A = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i] = random.Next(Min_Rand, Max_Rand);
            //}
            //-------Input-------
            //int[] A = new int[10];
            //for (int i = 0; i < A.Length; i++) 
            //{
            //    Console.Write("A[" + i + "] = ");
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}

            int max = A[0];
            int min = A[0];
            int max_key = 0;
            int min_key = 0;
            Console.WriteLine("Result(min): " + array_result_min(A, max, min, max_key, min_key));
            Console.WriteLine("Result(max): " + array_result_max(A, max, min, max_key, min_key));
            Console.WriteLine("" + output(A));
            Console.ReadKey();
        }
    }
}
