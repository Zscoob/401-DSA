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
                mirrorArray[i] = arr[arr.Length - (1 + i)];
            }
            //retuns 
            return mirrorArray;

        }


        public static int[] shiftedArr(int[] arr, int numInput)
        {
            //determin length to find middle index
            
           int mIndex = arr.Length / 2;
           int[] shifty = new int[arr.Length + 1];
            //decimal mIndex = (arr.Length +1  /2m);


            //loop for new array

            for (int i = 0; i < shifty.Length; i++)
            {
                if (i < mIndex)
                {
                    shifty[i] = arr[i];
                }
                else if (i == mIndex)
                {
                    shifty[i] = numInput;
                }
                else if (i > mIndex)
                {
                    shifty[i] = arr[i - 1];
                }
            }
            return shifty;
        }



    }
}
