using System;

partial class Program {
  public static void Main (string[] args) {

      List<int> numbers =  Console.ReadLine().Split().Select(int.Parse).ToList();
      int all_removed = 0;
    
      while (true){

        if (numbers.Count == 0){
          break;
        }   

        int indexes = int.Parse(Console.ReadLine());


        if (indexes  < 0){
          int to_remove =  numbers[0];
          all_removed += to_remove;
          numbers.RemoveAt(0);
          // maybe error if do Count - 1
          int temp = numbers[numbers.Count - 1];
          numbers.Insert(0, temp);
          
          for (int i = 0; i < numbers.Count; i++){
        
            if (numbers[i] <= to_remove){
              numbers[i] += to_remove;
            } 
            else{
              numbers[i] -= to_remove;
            }
          }       
          continue;
        }



        if (indexes >= numbers.Count){
          int to_remove = numbers[numbers.Count - 1];
          all_removed += to_remove;
          numbers.RemoveAt(numbers.Count - 1);
          int temp  = numbers[0];
          numbers.Insert(numbers.Count, temp);
          
          for (int i = 0; i < numbers.Count; i++){
        
            if (numbers[i] <= to_remove){
              numbers[i] += to_remove;
            } 
            else{
              numbers[i] -= to_remove;
            }
          }
          continue;
        }
        
        int number = numbers[indexes];

        all_removed += number;
        numbers.RemoveAt(indexes);

        for (int i = 0; i < numbers.Count; i++){
        
          if (numbers[i] <= number){
            numbers[i] += number;
          } 
          else{
            numbers[i] -= number;
          }
        }

      }

      Console.WriteLine(all_removed);
  
    
  }
}
