using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    Dictionary<string, List<string>> final = new Dictionary<string, List<string>>();

    while (true){

      List<string> company  = Console.ReadLine().Split(" -> ").ToList();

      
      if (company[0] == "End"){
        break;
      }

      if (final.ContainsKey(company[0])){
          bool bool1 = false;
    
        
          foreach(string now in final[company[0]]){
            if (now == company[1]){
              bool1 = true;
            }
          }

          if (!bool1){
            final[company[0]].Add(company[1]);
          }
        
        
      }
      else{
        final[company[0]] = new List<string>();
        final[company[0]].Add(company[1]);
      }     
    }


    foreach(KeyValuePair<string, List<string>> pair in final){

      Console.WriteLine(pair.Key);

      foreach(string ids in pair.Value){
        Console.WriteLine($"-- {ids}");
      }
      
    }
    
  }
}
