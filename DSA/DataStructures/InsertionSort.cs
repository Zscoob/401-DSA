using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10] { 1, 3, -5, 15, 0, 12, 22, 67, 51, 6 };
            Console.WriteLine("\nOriginal Array Elements :");
            PrintIntegerArray(num);
            Console.WriteLine("\nSorted Array Elements :");
            PrintIntegerArray(InsertionSort(num));
            Console.WriteLine("\n");
        }

        static int[] InsertionSort(int[] inputArr)
        {
            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArr[j - 1] > inputArr[j])
                    {
                        int temp = inputArr[j - 1];
                        inputArr[j - 1] = inputArr[j];
                        inputArr[j] = temp;
                    }
                }
            }
            return inputArr;
        }
        public static void PrintIntegerArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i.ToString() + "  ");
            }
        }


        public static int[] InsertionSortByShift(int[] inputArr)
        {
            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                int j;
                var insertionValue = inputArr[i];
                for (j = i; j > 0; j--)
                {
                    if (inputArr[j - 1] > insertionValue)
                    {
                        inputArr[j] = inputArr[j - 1];
                    }
                }
                inputArr[j] = insertionValue;
            }
            return inputArr;
        }

    }
}