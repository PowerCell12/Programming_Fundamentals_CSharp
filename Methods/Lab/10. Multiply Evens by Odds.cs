using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {   


    
    string  numbers = Console.ReadLine();
    List<int> even = new List<int>();
    List<int> odd = new List<int>();
    
    for (int i = 0; i < numbers.Length; i++){
  
      if (numbers[i] % 2 == 0 && char.IsDigit(numbers[i])){
        even.Add((int)numbers[i] - '0');
      }
      else if (numbers[i] % 2 != 0 && char.IsDigit(numbers[i])){
        odd.Add((int)numbers[i] - '0');
      }
    }


    for (int i = 0; i < even.Count; i++){
     if (even[i] < 0){
        even[i] = Math.Abs(even[i]);
     }
    }

    for (int i = 0; i < odd.Count; i++){
      if (odd[i] < 0){
        odd[i] = Math.Abs(odd[i]);
      }
    }



    double fianl_even = even.Sum();
    double final_odd = odd.Sum();

    Console.WriteLine(fianl_even * final_odd);



  }
}
