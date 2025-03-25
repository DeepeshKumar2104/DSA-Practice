using System;
namespace SecondLargestElement{
    class SecondLargestElement{
        static void Main(){
            int [] arr = {2,3,7,6,1};
            Array.Sort(arr);
            int first = int.MinValue;
            int second = int.MinValue;

            foreach(int num in arr){
                if(num>first){
                    second = first;
                    first = num;
                }else if(num>second && num!=first){
                    second = num;
                }
            }
            if(second = int.MinValue){
                Console.WriteLine("No distinct value");
            }
            else
            { 
                Console.WriteLine(second);
            }
        }
    }
}