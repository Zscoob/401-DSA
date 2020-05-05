using System;

namespace Challenges
{


    public class ArrayChallenges
    {
        //function returns array of int
        public static int[] EsreverYarra(int[] arr)
        {
            //creates new array index equal to original 
            int[] mirrorArray = new int[arr.Length];

            //loops through arr
            for (int i = 0; i < arr.Length; i++)
            {
                //reverses array in mirrorArray
                mirrorArray[i] = arr[arr.Length - (1+i)];
            }
            //retuns 
            return mirrorArray;         
            
        }
    }
}
