using System;
using System.Linq;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

  
  List<double> numbers =  Console.ReadLine().Split().Select(double.Parse).ToList();

    
  while (true){

    string[] commands = Console.ReadLine().Split();

    if (commands[0] == "End"){
      break;
    }

    if (commands[0] == "Add"){
      numbers.Add(double.Parse(commands[1]));
    }
    else if (commands[0] == "Insert"){
      if (int.Parse(commands[2]) < 0 || int.Parse(commands[2]) >= numbers.Count){   
          Console.WriteLine("Invalid index");
      }
      else {
      numbers.Insert(int.Parse(commands[2]), double.Parse(commands[1]));
      }
    }
    else if (commands[0] == "Remove"){
      if (int.Parse(commands[1]) < 0 || int.Parse(commands[1]) >= numbers.Count){   
          Console.WriteLine("Invalid index");
      }
      else {
      numbers.RemoveAt(int.Parse(commands[1]));
      }
    }
    else if (commands[0] == "Shift" && commands[1] == "left"){

        for (int i = 0; i < int.Parse(commands[2]); i++){

          double first = numbers[0];
          numbers.RemoveAt(0);
          numbers.Add(first);
        }
    }
    else if (commands[0] == "Shift" && commands[1] == "right"){

      for (int i = 0; i < int.Parse(commands[2]);i++){
      
        double last  = numbers[numbers.Count - 1];
        numbers.RemoveAt(numbers.Count - 1);
        numbers.Insert(0, last);
      }
    }
  }    

  Console.WriteLine(string.Join(" ", numbers));
  }
}
