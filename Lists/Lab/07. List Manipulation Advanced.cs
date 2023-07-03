using System;

partial class Program {  
  public static void Main (string[] args)
    {

      List<double> numbers  = Console.ReadLine().Split().Select(double.Parse).ToList();
      List<double> numbers_old = new List<double>();
      foreach (double number in numbers){

        numbers_old.Add(number);
      }
      bool bool1 = false;


      while (true){

        List<string> commands = Console.ReadLine().Split().ToList();

        if (commands[0] == "end"){
          break;
        }


        if (commands[0] == "Contains"){

          if (numbers.Contains(int.Parse(commands[1]))){
            Console.WriteLine("Yes");
          }
          else{
            Console.WriteLine("No such number");
          }

        }
        else if (commands[0] == "PrintEven"){
          for (int i  = 0; i < numbers.Count; i++){

            if (numbers[i] % 2 == 0){
              Console.Write($"{numbers[i]} ");
            } 
          }
          Console.WriteLine();


        }
        else if (commands[0] == "PrintOdd"){
          for (int i  = 0; i < numbers.Count; i++){

            if (numbers[i] % 2 != 0){
              Console.Write($"{numbers[i]} ");
            } 
          }
          Console.WriteLine();
        }
        else if (commands[0] == "GetSum"){

          double sum = numbers.Sum();
          Console.WriteLine(sum);

        }
        else if (commands[0] == "Filter"){
          List<double> numbers_filter = new List<double>();

          if (commands[1] == "<"){

            for (int i = 0; i < numbers.Count; i++){
              
              if (numbers[i] < int.Parse(commands[2])){
                  numbers_filter.Add(numbers[i]);
              }
            }
            Console.WriteLine(string.Join(" ", numbers_filter));
          }

          if (commands[1] == ">"){

            for (int i = 0; i < numbers.Count; i++){
              
              if (numbers[i] > int.Parse(commands[2])){
                  numbers_filter.Add(numbers[i]);
              }
            }
            Console.WriteLine(string.Join(" ", numbers_filter));
          }

          if (commands[1] == "<="){

            for (int i = 0; i < numbers.Count; i++){
              
              if (numbers[i] <= int.Parse(commands[2])){
                  numbers_filter.Add(numbers[i]);
              }
            }
            Console.WriteLine(string.Join(" ", numbers_filter));
          }

          if (commands[1] == ">="){

            for (int i = 0; i < numbers.Count; i++){
              
              if (numbers[i] >= int.Parse(commands[2])){
                  numbers_filter.Add(numbers[i]);
              }
            }
            Console.WriteLine(string.Join(" ", numbers_filter));
          }
        }

        if (commands[0] == "Add"){

          numbers.Add(int.Parse(commands[1]));
          bool1 = true;
        }
        else if (commands[0] == "Remove"){

          numbers.Remove(int.Parse(commands[1]));
          bool1 = true;
        }
        else if (commands[0] == "RemoveAt"){

          numbers.RemoveAt(int.Parse(commands[1]));
          bool1 = true;
  
        }
        else if (commands[0] == "Insert"){

          numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
          bool1 = true;
        }
      }

      if (bool1){
        Console.WriteLine(string.Join(" ", numbers));
      }   

      }
    }
