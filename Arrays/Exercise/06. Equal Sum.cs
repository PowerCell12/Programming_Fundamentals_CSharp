using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {


    int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
    string[] equal = new string[array1.Length];
    
    for (int i = 0; i < array1.Length; i++){
      int sum_left = 0;
      int sum_right = 0;

      for (int j  = i + 1; j < array1.Length; j++){

        sum_right += array1[j];
      }

      for (int k = i - 1; k >= 0; k--){
        sum_left += array1[k];
      }


      if (sum_left == sum_right){

        equal[0] = Convert.ToString(i);
        break;
        
      }
      
      sum_left = 0;
      sum_right = 0;
    }

    if (equal[0] == null){
      Console.WriteLine("no");
    }

    Console.WriteLine(equal[0]);
    
  }
}
