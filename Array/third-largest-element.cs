
using System;
class HelloWorld {
  static void Main() {
    int [] arr = {2,3,7,6,1};
    Array.Sort(arr);
    
    int first = int.MinValue;
    int second = int.MinValue;
    int third = int.MinValue;
    foreach(int num in arr){
        if(num>first){
            third = second;
            second = first;
            first = num;
        }else if(num>second && num!=first){
            third = second;
            second = num;
        }
        else if(num>third && num!=second && num!=first){
            third = num;
        }
    }
    if(third == int.MinValue) {
        Console.WriteLine("No distinct value");
        
    }
    else{
    Console.WriteLine(third);
        
    }
    }
  }


