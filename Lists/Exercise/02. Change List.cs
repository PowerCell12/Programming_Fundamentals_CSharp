using System;
using System.Linq;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

    List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

  
    while (true){

      string[] commands =  Console.ReadLine().Split();

      if (commands[0] == "end"){
        break;
        }
      
      if (commands[0] == "Delete"){
        double remove = double.Parse(commands[1]);
        for (int i = 0; i < numbers.Count; i++){
        if (numbers[i] == remove){
            numbers.Remove(numbers[i]);
            i -= 1;
          }
        }
      }

      if (commands[0] == "Insert"){
        numbers.Insert(int.Parse(commands[2]), double.Parse(commands[1]));
      }
      
      
    }

    Console.WriteLine(string.Join(" ", numbers));
    
  }
  
}
