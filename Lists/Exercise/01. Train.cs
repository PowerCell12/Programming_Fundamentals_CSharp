using System;
using System.Linq;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

    List<double> numbers  = Console.ReadLine().Split().Select(double.Parse).ToList();

    int max_cap = int.Parse(Console.ReadLine());

    while (true){
  
      string[] commands = Console.ReadLine().Split();

      if (commands[0] == "end"){
        break;
      }

      if (commands[0] == "Add"){
        numbers.Add(double.Parse(commands[1]));
      }
      else{
      
        for (int i = 0; i < numbers.Count; i++){

          if (numbers[i] + double.Parse(commands[0]) <= max_cap){
            numbers[i] += double.Parse(commands[0]);
            break;
          }
        }  
      }
    }


    Console.WriteLine(string.Join(" ", numbers));

    
  }
}
