using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

    int final  = 0;

    for (int i = 0; i < integers.Length; i++){

        if (integers[i] % 2 ==0){
        final += integers[i]; 
        }
    }

    Console.WriteLine(final);
  
  }
}
