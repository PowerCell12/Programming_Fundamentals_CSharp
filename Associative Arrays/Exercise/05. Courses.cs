using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    
    Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

    while (true) {

      List<string> list = Console.ReadLine().Split(" : ").ToList();


      if (list[0] == "end"){ break; }

      if (dictionary.ContainsKey(list[0])){
        
        dictionary[list[0]].Add(list[1]);

      }
      else{

        dictionary[list[0]] = new List<string>();
        dictionary[list[0]].Add(list[1]);

      }
    }


    foreach(KeyValuePair<string, List<string>> item in dictionary){

      Console.WriteLine($"{item.Key}: {item.Value.Count}");

      foreach(string ite in item.Value){

        Console.WriteLine($"-- {ite}");

      }
    }


  }
}
