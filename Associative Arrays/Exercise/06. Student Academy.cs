using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {


    Dictionary<string, List<double>> final = new Dictionary<string, List<double>>();
    int rows = int.Parse(Console.ReadLine());

    for (int i = 0; i < rows; i++){

      string name = Console.ReadLine();
      double grade =double.Parse(Console.ReadLine());

      if (!final.ContainsKey(name)){
        final[name] = new List<double>();
        final[name].Add(grade);
      }
      else{
        final[name].Add(grade);
      }
      
    }

    foreach(KeyValuePair<string, List<double>> pair in final){

      double average  = pair.Value.Sum() / pair.Value.Count;

      if (average >= 4.50){
        Console.WriteLine($"{pair.Key} -> {average:F2}");
      }
      
    }
    
    
  }
}
