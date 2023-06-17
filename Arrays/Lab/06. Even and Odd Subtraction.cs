using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

    int sum_even = 0;
    int sum_odd = 0;

    for (int i = 0; i < integers.Length; i++){

      if (integers[i] % 2 ==0){
        sum_even += integers[i];
      }
      else{
        sum_odd += integers[i];
      }    
    }

    int final = sum_even - sum_odd;
    Console.WriteLine(final);
  }
}
