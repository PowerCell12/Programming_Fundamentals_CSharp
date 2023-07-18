using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    List<string>  all = Console.ReadLine().Split(" ").ToList();

    Dictionary<char, int> final = new Dictionary<char, int>();

    foreach (string i in all){
  
      foreach(char j in i){

        if (final.ContainsKey(j)){
          final[j] += 1;
        }
        else{
          final[j] = 1;
      }     
    }
      }


    foreach(KeyValuePair<char, int> pair in final){
      Console.WriteLine($"{pair.Key} -> {pair.Value}");
    }
      
  }
}
  
