using System;

namespace CyclicallyRotateArray
{
    class Program
    {
        public int[] RotateArray(int[] arr, int d)
        {
            int[] A = new int[d];
            int len = Math.Abs(arr.Length - d);
            int[] B = new int[len];
            int j = 0;

            for (int i = len; i < arr.Length; i++)
            {
                A[j] = arr[i];
                j++;
            }

            for (int i = 0; i < len; i++)
            {
                B[i] = arr[i];
            }

            j = 0;
            for (int i = 0; i < A.Length; i++)
            {
                arr[i] = A[i];
                j++;
            }

            for (int i = 0; i < B.Length; i++)
            {
                arr[j] = B[i];
                j++;
            }

            return arr;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int d = 5;

            arr = program.RotateArray(arr, d);

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
