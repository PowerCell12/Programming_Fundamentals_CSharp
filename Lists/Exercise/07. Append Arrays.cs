using System.Collections.Generic;
using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    List<string> arrays = Console.ReadLine().Split("|").ToList();

    for (int i = arrays.Count -1; i >= 0; i--){

      string[] print = arrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

      for (int j = 0; j < print.Length; j++){

        Console.Write(print[j] + " ");
        
      }

        
      
    }
    
  }
}
