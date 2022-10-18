using System;

namespace CyclicallyRotateArray
{
    class Program
    {
        public int[] RotateArray(int[] arr, int d)
        {
            int len = Math.Abs(arr.Length - d);
            int j = 0;
            int[] TempArray = new int[arr.Length];

            for (int i = len; i < arr.Length; i++)
            {
                TempArray[j] = arr[i];
                j++;
            }

            for (int i = 0; i < len; i++)
            {
                TempArray[j] = arr[i];
                j++;
            }

            return TempArray;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int d = 10;

            arr = program.RotateArray(arr, d);

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
