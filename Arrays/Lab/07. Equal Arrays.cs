using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
    bool bool1 = true;
    
    for (int i = 0; i < array1.Length; i++){

      int int1 = array1[i];
      int int2 = array2[i];

      if (int2 != int1)
      {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        bool1 = false;
        break;
      }
     }
    
    if (bool1){
      Console.WriteLine($"Arrays are identical. Sum: {array1.Sum()}");
    }

      
  }
}
