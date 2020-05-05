using System;

namespace Challenges
{


    public class ArrayChallenges
    {
      
        public static void EsreverYarra(string[] args)
        {
            {
                int[] arr = new int[] { 1, 2, 3, 4, 5 };
                int length = arr.Length - 1;
                string strReverse = null;
                while (length >= 0)
                {
                    strReverse = strReverse + arr[length];
                    length--;
                }
                Console.WriteLine();
                Console.WriteLine("Reverse Array is " + " " + strReverse);
                Console.ReadLine();

            }
        }
    }
}
