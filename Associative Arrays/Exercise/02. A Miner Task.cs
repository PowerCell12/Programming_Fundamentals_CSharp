using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

    Dictionary<string, int> final = new Dictionary<string, int>();

    while (true){

      string Type = Console.ReadLine();

      if (Type == "stop"){
        break;
      }
      
      int quantity = int.Parse(Console.ReadLine());

      if (final.ContainsKey(Type)){
        final[Type] += quantity;
      }
      else{
        final[Type] = quantity;
      }
    }


    foreach(KeyValuePair<string, int> pair in final){
      Console.WriteLine($"{pair.Key} -> {pair.Value}");
    }

    
  }
}
