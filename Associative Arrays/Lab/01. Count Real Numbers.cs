using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {


    List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
  
    var dict = new SortedDictionary<double, int>();


    for (int i = 0; i < numbers.Count; i++){

    if (dict.ContainsKey(numbers[i])){

      dict[numbers[i]]++;
    }
    else{
      dict[numbers[i]] = 1;
    }
    }


    foreach(KeyValuePair<double, int> pair in dict){

      Console.WriteLine($"{pair.Key} -> {pair.Value}");

    }




  }
}


