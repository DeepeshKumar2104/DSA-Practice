// Maximum consecutive one’s (or zeros) in a binary array
// Last Updated : 17 Feb, 2025
// Given an array arr[] consisting of only 0’s and 1’s, the task is to find the count of a maximum number of consecutive 1’s or 0’s present in the array.

// Examples : 

// Input: arr[] = {1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 1}
// Output: 4
// Explanation: The maximum number of consecutive 1’s in the array is 4 from index 8-11.


// Input: arr[] = {0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1}
// Output: 2
// Explanation: The maximum number of consecutive 0’s in the array is 2 from index 0-1.


// Input: arr[] = {0, 0, 0, 0}
// Output: 4

using System;
namespace  MaximumConsecutiveOne{
    class MaximumConsecutiveOne{
        static void Main(string[] args){

            int[] arr = {1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 1};
            int Count = 1;
            int MaxCount = 0;

            for(int i = 0; i<arr.Length-1; i++){
                if(arr[i]==arr[i+1]){
                    Count++;
                }else{
                    MaxCount = Math.Max(MaxCount,Count);
                    Count = 1;
                }
            }
            Console.WriteLine(Math.Max(MaxCount,Count)) ;
        }

    }
}
