using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {   
    


  int lines = int.Parse(Console.ReadLine());
  
  for (int number = 2; number <= lines; number++)
  {
    
    bool is_prime = true;
    
    for (int numberfinal = 2; numberfinal < number; numberfinal++)
    {
  
  
      if (number % numberfinal == 0)
      {
        is_prime = false;
        break;
      }
    
    }
  
  if (is_prime){
    Console.WriteLine($"{number} -> true");
  }
  else{
    Console.WriteLine($"{number} -> false");  
  }


  }




  }
}
