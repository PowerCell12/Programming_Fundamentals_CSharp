using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int numbers = int.Parse(Console.ReadLine());
    
    
    for (int i = 0; i < array.Length; i++){

        for (int j =  i + 1; j < array.Length; j++){

           if (array[i] + array[j] == numbers){
             Console.WriteLine($"{array[i]} {array[j]}");
           }
          
        }

      
    }

    
  }
}
