using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    
    List<string> elements  = Console.ReadLine().Split().Select(x => x.ToLower()).ToList();


    Dictionary<string, int> count = new Dictionary<string, int>();


    for (int i =0; i < elements.Count; i++) {

      if (count.ContainsKey(elements[i])) {
        count[elements[i]]++;
      }
      else{
        count[elements[i]] = 1;
      }
    }

    

    foreach(KeyValuePair<string, int> pair in count) {

      if (pair.Value % 2 != 0){
        Console.Write(pair.Key + " ");
      }
    }


  }
}


